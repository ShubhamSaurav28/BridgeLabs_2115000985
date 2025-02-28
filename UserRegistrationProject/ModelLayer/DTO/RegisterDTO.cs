using System.ComponentModel.DataAnnotations;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.DTO
{
    public class RegistrationDTO
    {
        //[Required]
        public string Username { get; set; }

        //[Required]
        //[MinLength(6, ErrorMessage = "Password must be at least 6 characters long.")]
        public string Password { get; set; }

        //[Required]
        //[EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; }

        //[Required]
        public string FullName { get; set; }

        public override string ToString()
        {
            return $"Username: {Username}, Email: {Email}, Full Name: {FullName}";
        }
    }
}
