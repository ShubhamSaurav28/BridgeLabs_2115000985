using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;

namespace RepositoryLayer.Service
{
    public class RegisterHelloRL
    {
        private string databaseusername = "root";
        private string databasepassword = "root";
        public RegisterHelloRL()
        {

        }
        public string getHello(string name)
        {
            return name + "Hello from Repository layer";
        }
        public LoginDTO getUsernamePassword(LoginDTO loginDTO) 
        {
            loginDTO.username = databaseusername;
            loginDTO.password = databasepassword;
            return loginDTO;
        }
    }
}

