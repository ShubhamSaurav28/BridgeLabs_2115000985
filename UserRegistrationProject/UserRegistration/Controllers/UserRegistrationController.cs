using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Service;
using ModelLayer.DTO;
using System;

namespace UserRegistration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserRegistrationController : ControllerBase
    {
        private readonly UserRegistrationBL _userRegistrationBL;
        private ResponseModel<string> response;

        public UserRegistrationController(UserRegistrationBL registerHelloBL)
        {
            _userRegistrationBL = registerHelloBL;
        }

        [HttpGet]
        public string Get()
        {
            return _userRegistrationBL.Registration("Value from Controller");
        }

        [HttpPost("register")]
        public IActionResult RegisterUser(RegistrationDTO registrationDTO)
        {
            try
            {
                response = new ResponseModel<string>();
                bool result = _userRegistrationBL.RegisterUser(registrationDTO);

                if (result)
                {
                    response.Success = true;
                    response.Message = "User Registered Successfully!";
                    response.Data = registrationDTO.Username;
                    return Ok(response);
                }

                response.Success = false;
                response.Message = "User Already Exists!";
                return Conflict(response);
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "An error occurred during registration.";
                response.Data = ex.Message;
                return BadRequest(response);
            }
        }

        [HttpPost("login")]
        public IActionResult LoginUser(LoginDTO loginDTO)
        {
            try
            {
                response = new ResponseModel<string>();
                bool result = _userRegistrationBL.LoginUser(loginDTO);

                if (result)
                {
                    response.Success = true;
                    response.Message = "Login Successful";
                    response.Data = loginDTO.Username;
                    return Ok(response);
                }

                response.Success = false;
                response.Message = "Invalid Credentials";
                return Unauthorized(response);
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "An error occurred during login.";
                response.Data = ex.Message;
                return BadRequest(response);
            }
        }
    }
}
