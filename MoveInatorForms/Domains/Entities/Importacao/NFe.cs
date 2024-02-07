using UtilityLib.Domains.Entities.DocumentosFiscais;

namespace MoveInatorForms.Domains.Entities.Importacao
{
    public class NFe
    {
        public ChaveAcesso ChaveAcesso { get; set; }

        public string CnpjEmissor { get; set; }

        public DateTime DataEmissao { get; set; }
    }
}
