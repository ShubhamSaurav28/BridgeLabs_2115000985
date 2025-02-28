using BusinessLayer.Service;
using Microsoft.AspNetCore.Mvc;

namespace UserRegistration.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserRegistrationController : ControllerBase
    {
        private readonly UserRegistrationBL _businessLayer;

        public UserRegistrationController()
        {
            _businessLayer = new UserRegistrationBL();
        }

        [HttpGet]
        public IActionResult Registration()
        {
            string username = "root";
            string password = "root";

            string result = _businessLayer.RegistrationBL(username, password);
            return Ok(result);
        }
    }
}
