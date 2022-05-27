﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXIE.Model.Account
{
    public class AccountDTO
    {
        public Guid NftAccountPK { get; set; }
        public Guid UserFK { get; set; }
        public Guid AccountStatusFK { get; set; }
        public Guid TeamFK { get; set; }
        public Guid AccountRoninFK { get; set; }
        public DateTime DateOfEntry { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string AccName { get; set; }
        public string MMR { get; set; }
    }
}
