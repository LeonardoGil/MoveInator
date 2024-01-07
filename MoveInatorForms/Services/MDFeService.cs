using MoveInatorForms.Domains.Entities.DocumentosFiscais;
using MoveInatorForms.Domains.Entities.Importacao;
using MoveInatorForms.Domains.Enums;
using MoveInatorForms.Domains.Models;
using MoveInatorForms.Services.Interfaces;
using System.Text;

namespace MoveInatorForms.Services
{
    public class MDFeService : IMDFeService
    {
        public string Generate(string path, List<MDFeCTeViewModel> mdfeCtes)
        {
            var mdfe = ConvertToMDFe(mdfeCtes);

            var taskMDFe = GenerateMDFe(path, mdfe);
            
            var taskCTes = GenerateCTes(path, mdfe.CTes);

            Task.WaitAll(taskCTes, taskMDFe);

            throw new NotImplementedException();
        }

        #region Private
        
        private MDFe ConvertToMDFe(List<MDFeCTeViewModel> mdfeCTes)
        {
            var single = mdfeCTes.First();

            var mdfe = new MDFe
            {
                ChaveAcesso = new ChaveAcesso(ModeloDocumentoEnum.MDFe, 42, single.DataEmissao, long.Parse(single.CnpjEmissor), single.SerieMDFe, single.NumeroMDFe),
                CnpjEmissor = single.CnpjEmissor,
                DataEmissao = single.DataEmissao,
                Motorista = single.NomeMotorista,
                CpfMotorista = single.CpfMotorista
            };

            foreach (var cte in mdfeCTes)
            {
                mdfe.CTes.Add(new CTe
                {
                    ChaveAcesso = new ChaveAcesso(ModeloDocumentoEnum.CTe, 42, cte.DataEmissao, long.Parse(cte.CnpjEmissor), cte.SerieCTe, cte.NumeroCTe),
                    CnpjEmissor = cte.CnpjEmissor,
                    DataEmissao = cte.DataEmissao
                });
            }

            return mdfe;
        }

        private async Task GenerateMDFe(string path, MDFe mdfe)
        {
            var template = File.ReadAllText(string.Concat(Directory.GetCurrentDirectory(), "\\MDfeModelo.xml"));

            template.Replace("[ChaveAcesso]", mdfe.ChaveAcesso.ToString());
            template.Replace("[DigitoVerificar]", mdfe.ChaveAcesso.DigitoVerificador);
            template.Replace("[Estado]", mdfe.ChaveAcesso.UF);
            template.Replace("[Serie]", mdfe.ChaveAcesso.Serie);
            template.Replace("[Numero]", mdfe.ChaveAcesso.Numero);
            template.Replace("[DataEmissao]", mdfe.DataEmissao.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"));
            template.Replace("[CnpjEmissor]", mdfe.CnpjEmissor);
            template.Replace("[NomeMotorista]", mdfe.Motorista);
            template.Replace("[CpfMotorista]", mdfe.CpfMotorista);

            var ctes = string.Empty;

            foreach (var cte in mdfe.CTes)
            {
                ctes += "<infCTe>";
                ctes += Environment.NewLine;

                ctes += $"<chCTe>{cte.ChaveAcesso}</chCTe>";
                ctes += Environment.NewLine;

                ctes += "</infCTe>";
                ctes += Environment.NewLine;
            }

            template.Replace("[CTes]", ctes);

            var fileName = $"MoveInator_MDFe{mdfe.ChaveAcesso}.xml";

            await GenerateFile(fileName, template);
        }

        private async Task GenerateCTes(string path, List<CTe> CTes)
        {
            throw new NotImplementedException();
        }

        private async Task GenerateFile(string pathFile, string content)
        {
            using (var file = File.Create(pathFile))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(content);
                file.Write(info, 0, info.Length);
            }
        }

        #endregion
    }
}
