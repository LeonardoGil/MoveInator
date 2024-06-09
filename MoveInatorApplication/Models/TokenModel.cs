using MoveInatorDomain.Entities.Cadastros;
using MoveInatorDomain.Enums;
using System.ComponentModel;

namespace MoveInatorApplication.Models
{
    public class TokenModel
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
