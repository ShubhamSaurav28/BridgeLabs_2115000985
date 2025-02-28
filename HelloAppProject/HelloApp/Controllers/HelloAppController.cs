using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Service;
using System.Reflection.Metadata.Ecma335;
using ModelLayer.DTO;

namespace HelloApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloAppController : ControllerBase
    {
        RegisterHelloBL _registerHelloBL;
        ResponseModel<string> response;
        public HelloAppController(RegisterHelloBL registerHelloBL)
        {
            _registerHelloBL = registerHelloBL;
        }

        [HttpGet]
        public string Get()
        {
            return _registerHelloBL.registration("value from controller");
        }

        [HttpPost]
        public IActionResult LoginUser(LoginDTO loginDTO)
        {
            try
            {
                response = new ResponseModel<string>();
                bool result = _registerHelloBL.loginuser(loginDTO);
                if (result)
                {
                    response.Success = true;
                    response.Message = "Data Received Successfully";
                    response.Data = loginDTO.username;
                    return Ok(response);
                }
                response.Success = true;
                response.Message = "Login Failed";
                response.Data = "";
                return NotFound();
            }
            catch (Exception ex)
            {
                response.Success = true;
                response.Message = "Login Failed";
                response.Data = ex.Message;
                return BadRequest();
            }
        }
    }
}
