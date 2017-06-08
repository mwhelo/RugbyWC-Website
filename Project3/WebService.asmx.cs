using Project3.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Project3
{
    /// <summary>
    /// Summary description for RugbySearch
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class RugbySearch : System.Web.Services.WebService
    {
        private RugbyContext db = new RugbyContext();

        [WebMethod]
        public string [] GetPlayersByPlayerName(string namePart)
        {
            List<string> players = new List<string>();

            if (namePart !="")
            {
                foreach (var player in db.Player
                                         .Where(a => a.PlayerName.Contains(namePart))
                                         .ToList())
                {
                    players.Add(player.PlayerName);
                }
            }

            return players.ToArray();
        }
    }
}
