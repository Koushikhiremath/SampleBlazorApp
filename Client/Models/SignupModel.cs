using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApp.Client.Models
{
    public class SignupModel
    {
        [Required(ErrorMessage = "UserName Required !")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email Required !")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password Required !")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
   
}
