using MoveInatorForms.Domains.Enums;

namespace MoveInatorForms.Domains.Models
{
    public class TokenViewModel
    {
        public TokenAPIEnum API { get; set; }

        public string Url { get; set; }

        public string Token { get; set; }
        
        public bool Sucess { get; set; }

        public string Fail { get; set; }
    }
}
