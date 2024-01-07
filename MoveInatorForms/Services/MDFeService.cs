using MoveInatorForms.Domains.Entities.DocumentosFiscais;
using MoveInatorForms.Domains.Entities.Importacao;
using MoveInatorForms.Domains.Enums;
using MoveInatorForms.Domains.Models;
using MoveInatorForms.Services.Interfaces;

namespace MoveInatorForms.Services
{
    public class MDFeService : IMDFeService
    {
        public string Generate(List<MDFeCTeViewModel> mdfeCtes)
        {
            var mdfe = ConvertToMDFe(mdfeCtes);

            throw new NotImplementedException();
        }

        #region Private
        
        public MDFe ConvertToMDFe(List<MDFeCTeViewModel> mdfeCTes)
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

        #endregion
    }
}
