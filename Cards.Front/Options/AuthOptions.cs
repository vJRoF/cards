using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Front.Options
{
    public class AuthOptions
    {
        public string Issuer { get; set; }

        public string Audience { get; set; }

        public TimeSpan TokenLifetime { get; set; }

        public string SecurityKeyBase64 { get; set; }

        public SecurityKey GetSymmetricSecurityKey()
        {
            return GetSymmetricSecurityKey(SecurityKeyBase64);
        }

        public static SecurityKey GetSymmetricSecurityKey(string securityKeyBase64)
        {
            return new SymmetricSecurityKey(Convert.FromBase64String(securityKeyBase64));
        }

        internal static string GenerateKey()
        {
            var rng = new Random((int)DateTime.Now.Ticks);
            var bytes = new byte[64];
            rng.NextBytes(bytes);
            return Convert.ToBase64String(bytes);
        }
    }
}
