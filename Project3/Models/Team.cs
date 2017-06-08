using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project3.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string ManagerName { get; set; }
        public string WorldRank { get; set; }
        public int NumOfWorldCups { get; set; }

        public virtual List<Team> Teams { get; set; }
    }
}