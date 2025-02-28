using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;
using System.Collections.Generic;

namespace RepositoryLayer.Service
{
    public class UserRegistrationRL
    {
        private List<RegistrationDTO> _users = new List<RegistrationDTO>();

        public string GetHello(string name)
        {
            return $"{name}, Hello from Repository Layer!";
        }

        public bool SaveUser(RegistrationDTO registrationDTO)
        {
            if (_users.Exists(u => u.Username.Equals(registrationDTO.Username)))
            {
                return false; // User already exists
            }

            _users.Add(registrationDTO);
            return true; // Registration successful
        }

        public LoginDTO GetUsernamePassword(LoginDTO loginDTO)
        {
            var user = _users.Find(u => u.Username.Equals(loginDTO.Username) && u.Password.Equals(loginDTO.Password));
            if (user != null)
            {
                loginDTO.Username = user.Username;
                loginDTO.Password = user.Password;
                return loginDTO;
                //return new LoginDTO { Username = user.Username, Password = user.Password };
            }
            return null; // User not found
        }
    }
}
