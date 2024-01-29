using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class UserObject
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public static List<UserObject> listAccount = new List<UserObject>()
    {
        new UserObject() { Email = "admin@fstore.com", Password = "admin@@", IsAdmin = true },
        new UserObject() { Email = "hieunh@fstore.com", Password = "admin@@", IsAdmin = false }
    };


    }
}
