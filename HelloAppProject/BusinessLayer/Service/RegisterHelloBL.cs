﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;
using RepositoryLayer.Service;

namespace BusinessLayer.Service
{
    public class RegisterHelloBL
    {
        RegisterHelloRL _registerHelloRL;
        public RegisterHelloBL(RegisterHelloRL registerHelloRL)
        {
            _registerHelloRL = registerHelloRL;
        }
        public string registration(string name)
        {
            return "Data from business layer " + _registerHelloRL.getHello(name);
        }
        public bool loginuser(LoginDTO loginDTO)
        {
            string frontendUsername = loginDTO.username;
            string frontendPassword = loginDTO.password;
            LoginDTO result = _registerHelloRL.getUsernamePassword(loginDTO);
            bool res = checkUsernamePassword(frontendUsername, frontendPassword, result);
            return res;
        }

        private bool checkUsernamePassword(string frontendUsername, string frontendPassword, LoginDTO result)
        {
            if(frontendUsername.Equals(result.username) && frontendPassword.Equals(result.password))
            {
                return true;
            }
            return false;
        }
    }
}




