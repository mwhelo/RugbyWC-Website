using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project3.Models
{
    public class Manager
    {
        public int ManagerId { get; set; }
        public string ManagerName { get; set; }
        public string TeamManaged { get; set; }
        public int Appereances { get; set; }
        public int GamesWon { get; set; }

        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
    }
}