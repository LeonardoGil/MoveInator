using System.Text.Json.Serialization;

namespace MoveInatorForms.Domains.Entities.Tokens
{
    public class TokenPortalRequest
    {
        [JsonPropertyName("grant_type")]
        public string GrantType { get; set; } = "client_credentials";

        [JsonPropertyName("client_id")]
        public string ClientId { get; set; }

        [JsonPropertyName("client_secret")]
        public string ClientSecret { get; set; }
    }
}
