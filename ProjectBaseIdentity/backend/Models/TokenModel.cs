using Microsoft.IdentityModel.Tokens;
using ProjectBaseIdentity.Helpers;

namespace ProjectBaseIdentity.Models;

public class TokenModel
{
    public string Scheme { get; } = "Bearer";

    public long ExpiryDateUtc { get; }

    public string AccessToken { get; set; }

    public TokenModel(string token, DateTime expiryDate)
    {
        AccessToken = token;
        ExpiryDateUtc = DateTimeHelper.DateTimeToUnixTimestamp(expiryDate);
    }

    public TokenModel(string token, DateTime expiryDate, string scheme)
    {
        AccessToken = token;
        ExpiryDateUtc = DateTimeHelper.DateTimeToUnixTimestamp(expiryDate);
        Scheme = scheme;
    }

    public TokenModel(string accessToken, TokenValidationParameters tokenValidationParameters)
    {
        AccessToken = accessToken;
    }

}
