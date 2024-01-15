using UtilityLib.Domains.Entities.DocumentosFiscais;

namespace MoveInatorForms.Domains.Entities.Importacao
{
    public class CTe
    {
        public ChaveAcesso ChaveAcesso { get; set; }

        public string CnpjEmissor { get; set; }

        public DateTime DataEmissao { get; set; }

        public ChaveAcesso ChaveAcessoNFe { get;set;}

    }
}
