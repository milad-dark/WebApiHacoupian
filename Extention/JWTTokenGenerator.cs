using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace WepApiHacoupian.Extention
{
    public class JWTTokenGenerator
    {
        private readonly byte[] secret;
        public JWTTokenGenerator(string secretKey)
        {
            secret = Encoding.ASCII.GetBytes(secretKey);
        }
        public string GeneratorToken(string UserName, string Password)
        {
            //var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Key"]));
            //var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            ////Get UserName
            //var claims = new[]
            //{
            //    new Claim(ClaimTypes.Name,UserName),
            //    new Claim(JwtRegisteredClaimNames.Sub,UserName)
            //};

            var claims = new ClaimsIdentity();
            claims.AddClaim(new Claim(ClaimTypes.NameIdentifier, UserName));

            var tokenDescription = new SecurityTokenDescriptor()
            {
                Subject = claims,
                Expires = DateTime.Now.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secret), SecurityAlgorithms.HmacSha256Signature)
            };

            //var token = new JwtSecurityToken(_configuration["JWT:Issuer"], _configuration["JWT:Issuer"], claims, expires: DateTime.Now.AddHours(1), signingCredentials: credentials);

            var tokenHondler = new JwtSecurityTokenHandler();
            var createdToken = tokenHondler.CreateToken(tokenDescription);

            return tokenHondler.WriteToken(createdToken);
        }
    }
}
