using System.Text.Json.Serialization;

namespace MoveInatorForms.Domains.Entities.Tokens
{
    public class TokenMobileRequest
    {
        [JsonPropertyName("grant_type")]
        public string GrantType { get; set; } = "password";

        [JsonPropertyName("client_id")]
        public string ClientId { get; set; }

        [JsonPropertyName("userName")]
        public string User { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}
