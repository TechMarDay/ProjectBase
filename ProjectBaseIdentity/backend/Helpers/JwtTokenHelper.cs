using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace ProjectBaseIdentity.Helpers;

public static class JwtTokenHelper
{

    public static SigningCredentials GetSigningCredential(string secretKey)
    {
        return new SigningCredentials(GetSymmetricKeyFromSecretKey(secretKey), SecurityAlgorithms.HmacSha256Signature);
    }

    public static SymmetricSecurityKey GetSymmetricKeyFromSecretKey(string tokenSecretKey)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenSecretKey));

        return securityKey;
    }
}