using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApp.Server.DataBaseModels
{
    public class Users
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string  EmailAdress { get; set; }
        public string Password { get; set; }
    }
}
