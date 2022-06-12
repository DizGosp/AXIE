using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXIE.Models.AccountRonin
{
    public class AccountRoninDTO
    {
        public Guid AccountRoninPK { get; set; }
        public string Ronin { get; set; }
        public DateTime DateOfEntry { get; set; }
    }
}
