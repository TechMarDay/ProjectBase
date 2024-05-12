using ProjectBaseIdentity.Models;

namespace ProjectBaseIdentity.Services;

public interface ITokenService
{
    TokenModel GenerateAccessTokenFromPosInfo(string loginName);
}