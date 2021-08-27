
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApp.Client.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="User Name Required !")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password Name Required !")]
        [DataType (DataType.Password)]
        public string Password { get; set; }
    }
}
