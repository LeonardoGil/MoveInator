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
        public async Task<string> GenerateAsync(string path, List<MDFeCTeViewModel> mdfeCtes)
        {
            var taskConvertMDFe = ConvertToMDFeAsync(mdfeCtes);

            if (!Directory.Exists(path))
                throw new Exception("Diretório não existe!");

            var single = mdfeCtes.First();
            var newFolder = Path.Combine(path, $"MDFe {single.NumeroMDFe}-{single.SerieMDFe}");

            Directory.CreateDirectory(newFolder);

            var mdfe = await taskConvertMDFe;

            var tasksGenerate = new List<Task>();

            tasksGenerate.AddRange(mdfe.CTes.Select(cte => GenerateCTeAsync(newFolder, cte)));
            tasksGenerate.Add(GenerateMDFeAsync(newFolder, mdfe));

            Task.WaitAll(tasksGenerate.ToArray());

            return newFolder;
        }

        #region Private
        
        private async Task<MDFe> ConvertToMDFeAsync(List<MDFeCTeViewModel> mdfeCTes)
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
                    ChaveAcessoNFe = new ChaveAcesso(ModeloDocumentoEnum.NFe, 42, cte.DataEmissao, long.Parse(cte.CnpjEmissor), cte.SerieCTe, cte.NumeroCTe),
                    CnpjEmissor = cte.CnpjEmissor,
                    DataEmissao = cte.DataEmissao
                });
            }

            return mdfe;
        }

        private async Task GenerateMDFeAsync(string path, MDFe mdfe)
        {
            var template = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "MDfeModelo.xml"));

            template = template.Replace("[ChaveAcesso]", mdfe.ChaveAcesso.ToString())
                               .Replace("[DigitoVerificar]", mdfe.ChaveAcesso.DigitoVerificador)
                               .Replace("[Estado]", mdfe.ChaveAcesso.UF)
                               .Replace("[Serie]", mdfe.ChaveAcesso.Serie.TrimStart('0'))
                               .Replace("[Numero]", mdfe.ChaveAcesso.Numero.TrimStart('0'))
                               .Replace("[DataEmissao]", mdfe.DataEmissao.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"))
                               .Replace("[CnpjEmissor]", mdfe.CnpjEmissor)
                               .Replace("[NomeMotorista]", mdfe.Motorista)
                               .Replace("[CpfMotorista]", mdfe.CpfMotorista);
                               
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

            template = template.Replace("[QuantidadeCTes]", mdfe.QuantidadeCTes.ToString())
                               .Replace("[CTes]", ctes);

            var filePath = Path.Combine(path, $"MoveInator_MDFe{mdfe.ChaveAcesso}.xml");

            await GenerateFileAsync(filePath, template);
        }

        private async Task GenerateCTeAsync(string path, CTe cte)
        {
            var template = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "CTeModelo.xml"));

            template = template.Replace("[ChaveAcesso]", cte.ChaveAcesso.ToString())
                               .Replace("[ChaveAcessoNFe]", cte.ChaveAcessoNFe.ToString())
                               .Replace("[DigitoVerificador]", cte.ChaveAcesso.DigitoVerificador)
                               .Replace("[Estado]", cte.ChaveAcesso.UF)
                               .Replace("[Serie]", cte.ChaveAcesso.Serie.TrimStart('0'))
                               .Replace("[Numero]", cte.ChaveAcesso.Numero.TrimStart('0'))
                               .Replace("[DataEmissao]", cte.DataEmissao.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"))
                               .Replace("[CnpjEmissor]", cte.CnpjEmissor);

            var filePath = Path.Combine(path, $"MoveInator_CTe{cte.ChaveAcesso}.xml");

            await GenerateFileAsync(filePath, template);
        }

        private async Task GenerateFileAsync(string pathFile, string content)
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
