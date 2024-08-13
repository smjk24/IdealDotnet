using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace LinkTin.Data.Helpers
{
    public  class Token
    {
        private readonly IConfiguration _configuration;
        public Token(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string GenerateJwtTokenAsync(long userid,string username)
        {
            string mainName = "";
            var claims = new List<Claim> {
                new Claim(ClaimTypes.NameIdentifier,userid.ToString()),
                new Claim(ClaimTypes.Name, username),
                new Claim(ClaimTypes.GivenName, username)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8
                //.GetBytes("Auth:Token"));
                .GetBytes(_configuration.GetSection("Auth:Token").Value));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
