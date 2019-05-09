using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalToernooi
{
    public class Team
    {
        public string Name { get; set; }
        public List<Player> players = new List<Player>();
        public int poolIndex;
        public int gamesWon = 0;
        public int gamesLost = 0;
        public int gamesTied = 0;
        public int points = 0;

        public void AddPlayer(string name, int studentID, int teamID)
        {
            Player newPlayer = new Player();
            newPlayer.Name = name;
            newPlayer.StudentID = studentID;
            newPlayer.TeamID = teamID;

            players.Add(newPlayer);
        }
    }
}
