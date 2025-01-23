 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part_02_Q2
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        public BasicAuthenticationService(string? userName, string? password, string? role)
        {
            UserName = userName;
            Password = password;
            Role = role;
        }

        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }

        public bool AuthenticateUser(string _UserName, string _Password)
        {
            return(UserName == _UserName && Password == _Password);
        }

        public bool AuthorizeUser(string username , string role)
        {
            return (UserName == username && Role == role);
        }
    }
}
