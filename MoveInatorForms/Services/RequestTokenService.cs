using MoveInatorForms.Domains.Entities.Tokens;
using MoveInatorForms.Services.Interfaces;
using MoveInatorForms.Utilities.Extensions;
using System.Text.Json;

namespace MoveInatorForms.Services
{
    public class RequestTokenService : IRequestTokenService
    {
        public async Task<TokenPortalResponse> RequestTokenPortal(TokenPortalRequest token, Uri url)
        {
            var body = new List<KeyValuePair<string, string>>
            {
                new(token.GetJsonPropertyName(nameof(TokenPortalRequest.GrantType)), token.GrantType),
                new(token.GetJsonPropertyName(nameof(TokenPortalRequest.ClientId)), token.ClientId),
                new(token.GetJsonPropertyName(nameof(TokenPortalRequest.ClientSecret)), token.ClientSecret)
            };

            var request = new HttpRequestMessage(HttpMethod.Post, url);
            request.Content = new FormUrlEncodedContent(body);

            var response = await new HttpClient().SendAsync(request);
            response.EnsureSuccessStatusCode();

            return JsonSerializer.Deserialize<TokenPortalResponse>(await response.Content.ReadAsStringAsync());
        }
    }
}
