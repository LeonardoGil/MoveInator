using System.Text.Json.Serialization;

namespace MoveInatorDomain.Entities.Tokens
{
    public class TokenPortalResponse
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        [JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }
    }
}
