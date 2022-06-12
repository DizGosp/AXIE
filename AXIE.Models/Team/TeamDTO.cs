using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXIE.Models.Team
{
    public class TeamDTO
    {
        public Guid TeamPK { get; set; }
        public Guid TeamRoninFK { get; set; }
        public string TeamName { get; set; }
        public string Ronin { get; set; }
        public DateTime DateOfEntry { get; set; }
    }
}
