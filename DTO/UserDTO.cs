using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.DTO
{
    public class UserDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }

        public UserDTO() { }

        public UserDTO(string username, string password, string fullname)
        {
            this.Username = username;
            this.Password = password;
            this.FullName = fullname;
        }
    }
}
