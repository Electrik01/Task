using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.EF
{
    public class AuthOptions
    {
        public const string ISSUER = "TokenServer"; 
        public const string AUDIENCE = "ServerClient"; 
        const string KEY = "qwerty1234567890abcd";   
        public const int LIFETIME = 1; 
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
