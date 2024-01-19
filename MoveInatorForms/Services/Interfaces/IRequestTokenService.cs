using MoveInatorForms.Domains.Entities.Tokens;

namespace MoveInatorForms.Services.Interfaces
{
    public interface IRequestTokenService
    {
        Task<TokenPortalResponse> RequestTokenPortal(TokenPortalRequest token, Uri url);
        Task<TokenMobileResponse> RequestTokenMobile(TokenMobileRequest token, Uri url);
    }
}
