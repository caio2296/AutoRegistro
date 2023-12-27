using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRegistro.Token
{
    public class TokenJWT
    {
        private JwtSecurityToken _token;

        internal TokenJWT(JwtSecurityToken token)
        {
            _token = token;
        }
        public DateTime ValidTO => _token.ValidTo;

        public string value => new JwtSecurityTokenHandler().WriteToken(_token);
    }
}
