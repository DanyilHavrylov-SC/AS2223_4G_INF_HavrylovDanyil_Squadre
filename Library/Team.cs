using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Team
    {
        string name;
        int rosaPlayers = 0;
        int riservaPlayers = 0;

        /// <summary>
        /// List of players of the Team
        /// </summary>
        List<Player> players;

        /// <summary>
        /// Team captain
        /// </summary>
        Player? captain;
        
        /// <summary>
        /// Maximum number of players for each role
        /// </summary>
        const int MAX_RISERVA_PLAYERS = 3;
        const int MAX_ROSA_PLAYERS = 11;

        public Team(string name)
        {
            // TODO T.1
            this.name = name;
            players = new List<Player>();
        }

        /// <summary>
        /// Adding player to a Team
        /// 
        /// We can have a maximum of MAX_ROSA_PLAYERS rosa's players and MAX_RISERVA_PLAYERS riserva's player
        /// </summary>
        /// <param name="player"></param>
        /// <returns>True if player has been inserted</returns>
        public bool AddPlayer(Player player)
        {
            // TODO T.2
            switch (player.Role)
            {
                case Player.ERole.Rosa:
                    if (rosaPlayers <= MAX_ROSA_PLAYERS) 
                    {
                        players.Add(player);
                        rosaPlayers++;
                        return true;
                    }
                    else return false;
                case Player.ERole.Riserva:
                    if (riservaPlayers <= MAX_RISERVA_PLAYERS)
                    {
                        players.Add(player);
                        riservaPlayers++;
                        return true;
                    }
                    else return false;
                default: return false;
            }
        }

        /// <summary>
        /// Setting captain of the Team
        /// 
        /// Captain must be in the Rosa role
        /// </summary>
        /// <param name="captain"></param>
        /// <returns>True if captain has been setted</returns>
        public bool AddCaptain(Player captain)
        {
            // TODO T.3
            if (captain.Role == Player.ERole.Rosa && rosaPlayers <= MAX_ROSA_PLAYERS)
            {
                players.Add(captain);
                rosaPlayers++;
                return true;
            }
            else return false;
            
        }

        /// <summary>
        /// Get a list of players of the team
        /// </summary>
        /// <returns></returns>
        public string GetPlayers()
        {
            // TODO T.4
            string ris = "";
            int i = 0;
            foreach(Player player in players)
            {
                ris += $"{player.Description()}";
                if (i != players.Count()) ris += ", \n" ;
            }
            return ris;
        }

        public string Name { get { return name; } }

        public Player? Captain { get { return captain; } }
    }
}
