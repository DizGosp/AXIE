using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXIE.Models.AppUsers
{
    public class AppUserDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string RoleFK { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CreatedOn { get; set; }
        public string RoleName { get; set; }
    }
}
