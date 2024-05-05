using Microsoft.IdentityModel.Tokens;
using ProjectBaseIdentity.Contants;
using ProjectBaseIdentity.Helpers;
using ProjectBaseIdentity.Models;
using ProjectBaseIdentity.Services;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace IdealposIdentity.Services
{
    public class TokenService : ITokenService
    {
        private readonly long _accessTokenDurationInHours;
        private readonly string _issuer;
        private readonly string _tokenSecretKey;
        public TokenService(IConfiguration config)
        {
            _accessTokenDurationInHours = config.GetValue<long>("AccessTokenOptions:AccessTokenDurationInHours");
            _issuer = config.GetValue<string>("AccessTokenOptions:Issuer") ?? "";
            _tokenSecretKey = config.GetValue<string>("AccessTokenOptions:TokenSecretKey") ?? "";
        }

        public TokenModel GenerateAccessTokenFromPosInfo(string loginName)
        {
            var claims = new List<Claim>()
            {
                new Claim(CustomClaimNames.LoginName, loginName),
            };

            return GenerateToken(claims, _accessTokenDurationInHours);
        }

        private TokenModel GenerateToken(List<Claim> claims, long hoursToExpire)
        {
            var expiryDate = DateTime.UtcNow.Add(TimeSpan.FromHours(hoursToExpire));
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Issuer = _issuer,
                NotBefore = DateTime.UtcNow,
                IssuedAt = DateTime.UtcNow,
                Expires = expiryDate,
                Subject = new ClaimsIdentity(claims),
                SigningCredentials = JwtTokenHelper.GetSigningCredential(_tokenSecretKey)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            var tokenString = tokenHandler.WriteToken(token);

            return new TokenModel(tokenString, expiryDate);
        }
    }
}
