using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;
using RepositoryLayer.Service;

namespace BusinessLayer.Service
{
    public class UserRegistrationBL
    {
        private UserRegistrationRL _userRegistrationRL;

        public UserRegistrationBL(UserRegistrationRL userRegistrationRL)
        {
            _userRegistrationRL = userRegistrationRL;
        }

        public string Registration(string name)
        {
            return "Data from business layer " + _userRegistrationRL.GetHello(name);
        }

        public bool RegisterUser(RegistrationDTO registrationDTO)
        {
            return _userRegistrationRL.SaveUser(registrationDTO);
        }

        public bool LoginUser(LoginDTO loginDTO)
        {
            var result = _userRegistrationRL.GetUsernamePassword(loginDTO);
            return result != null && loginDTO.Username.Equals(result.Username) && loginDTO.Password.Equals(result.Password);
        }
    }
}
