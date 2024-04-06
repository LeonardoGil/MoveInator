using UtilityLib.Domains.Entities.DocumentosFiscais;

namespace MoveInatorDomain.Entities.Importacao
{
    public class CTe
    {
        public ChaveAcesso ChaveAcesso { get; set; }

        public string CnpjEmissor { get; set; }

        public DateTime DataEmissao { get; set; }

        public ChaveAcesso ChaveAcessoNFe { get;set;}

    }
}
