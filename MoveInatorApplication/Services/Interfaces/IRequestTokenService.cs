using MoveInatorDomain.Entities.Tokens;

namespace MoveInatorApplication.Services.Interfaces
{
    public interface IRequestTokenService
    {
        Task<TokenPortalResponse> RequestTokenPortal(TokenPortalRequest token, Uri url);
        Task<TokenMobileResponse> RequestTokenMobile(TokenMobileRequest token, Uri url);
    }
}
