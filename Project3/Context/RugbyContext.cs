using Project3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Project3.Context
{
    public class RugbyContext : DbContext
    {
        public DbSet<Team> Team { get; set; }
        public DbSet<Player> Player { get; set; }

        public System.Data.Entity.DbSet<Project3.Models.Stat> Stats { get; set; }

        public System.Data.Entity.DbSet<Project3.Models.Manager> Managers { get; set; }
    }
}