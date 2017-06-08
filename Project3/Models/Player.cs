using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project3.Models
{
    public class Player
    {

        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public string PlayerTeam{get; set;}
        public int Appereances { get; set; }
        public int Tires { get; set; }

        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
      
    }
}