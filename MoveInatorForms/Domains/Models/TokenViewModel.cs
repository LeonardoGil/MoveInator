using MoveInatorForms.Domains.Entities.Cadastros;
using MoveInatorForms.Domains.Enums;
using System.ComponentModel;

namespace MoveInatorForms.Domains.Models
{
    public class TokenViewModel
    {
        public TokenAPIEnum API { get; set; }

        public Uri Url { get; set; }

        public string Token { get; set; }

        public DateTime ExpiraEm { get; set; }

        [Browsable(false)]
        public Empresa Empresa { get; set; }

        [Browsable(false)]
        public Motorista Motorista { get; set; }
    }
}
