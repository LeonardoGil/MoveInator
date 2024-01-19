using System.Text.Json.Serialization;

namespace MoveInatorForms.Domains.Entities.Tokens
{
    public class TokenPortalResponse
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        [JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }
    }
}
