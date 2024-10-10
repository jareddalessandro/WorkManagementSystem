using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkManagementSystem.Models
{
    public class LoginUser
    {
        public string UserName {  get; set; }
        public string Password { get; set; }
        public string Location { get; set; }

        public string TimeZone { get; set; }

        public int UserId { get; set; }
        
    }
}
