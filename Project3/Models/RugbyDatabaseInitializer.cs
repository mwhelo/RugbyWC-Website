using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project3.Models;

//namespace Project3.Models
//{
//    public class RugbyDatabaseInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<Project3.Context.RugbyContext>
//    {
//        protected override void Seed(Context.RugbyContext context)
//        {
//            GetPlayer().ForEach(p => context.Player.Add(p));
//            GetTeams().ForEach(t => context.Team.Add(t));
//            GetManagers().ForEach(m => context.Managers.Add(m));
//            GetStats().ForEach(s => context.Stats.Add(s));
//        }

//       private static List<Player> GetPlayer()
//        {
//            var players = new List<Player>
//            {
//                new Player{
//                    PlayerId = 1,
//                    PlayerName = "Paul O'Connell",
//                    PlayerTeam = "Ireland",
//                    Appereances = 67,
//                    Tires = 13
//            },
//            new Player
//            {
//                       PlayerId = 2,
//                    PlayerName = "Johnny Sexton",
//                    PlayerTeam = "Ireland",
//                    Appereances = 57,
//                    Tires = 20
//            },
//            new Player
//            {
//                 PlayerId = 3,
//                    PlayerName = "Cian Healy",
//                    PlayerTeam = "Ireland",
//                    Appereances = 37,
//                    Tires = 6
//            },
//            };
//            return players;
//        }

//        private static List<Team> GetTeams()
//       {
//           var teams = new List<Team> {
//                new Team
//                {
//                    TeamId = 1,
//                    TeamName = "Ireland",
//                    ManagerName = "Joe Schimdt",
//                    NumOfWorldCups = 0,
//                    WorldRank = "6"
//                },
//                new Team
//                {
//                    TeamId = 2,
//                    TeamName = "New Zealand",
//                    ManagerName = "Larry Barry",
//                    NumOfWorldCups = 3,
//                    WorldRank = "1"
//                },
//                new Team
//                {
//                    TeamId = 3,
//                    TeamName = "Australia",
//                    ManagerName = "Steve Martin",
//                    NumOfWorldCups = 2,
//                    WorldRank = "2"
//                },
//                new Team
//                {
//                    TeamId = 4,
//                    TeamName = "Wales",
//                    ManagerName = "Warren Gatland",
//                    NumOfWorldCups = 0,
//                    WorldRank = "4"

//                }
//            };
//           return teams;
//       }

//        private static List<Manager> GetManagers()
//        {
//            var managers = new List<Manager>
//            {
//                new Manager
//                {
//                    ManagerId = 1,
//                    ManagerName = "Joe Schmidt",
//                    TeamManaged = "Ireland",
//                    Appereances = 30,
//                    GamesWon = 20
//                },
//                new Manager
//                {
//                    ManagerId = 2,
//                    ManagerName = "Warren Gatland",
//                    TeamManaged = "Wales",
//                    Appereances = 40,
//                    GamesWon = 28
//                },
//                new Manager
//                {
//                    ManagerId = 3,
//                    ManagerName = "Larry Barry",
//                    TeamManaged = "New Zealand",
//                    Appereances = 35,
//                    GamesWon = 30
//                },
//                new Manager
//                {
//                    ManagerId = 4,
//                    ManagerName = "Joe Schmidt",
//                    TeamManaged = "Ireland",
//                    Appereances = 30,
//                    GamesWon = 20
//                },

//            };
//            return managers;
//        }

//        private static List<Stat> GetStats()
//        {
//            var stats = new List<Stat>{
//                new Stat
//                {
//                    StatId = 1,
//                    PlayerName = "Johnny Sexton",
//                    PlayerTeam = "Ireland",
//                    Appereances = 34,
//                    Tires = 18,
//                    Points = 100
//                },
//                 new Stat
//                {
//                    StatId = 2,
//                    PlayerName = "Paul O'Connell",
//                    PlayerTeam = "Ireland",
//                    Appereances = 65,
//                    Tires = 18,
//                    Points = 45
//                },
//                 new Stat
//                {
//                    StatId = 3,
//                    PlayerName = "Dan Carter",
//                    PlayerTeam = "New Zealand",
//                    Appereances = 78,
//                    Tires = 30,
//                    Points = 1200
//                },

//            };
//            return stats;
//        }
//    }
//}