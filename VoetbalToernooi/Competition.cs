using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalToernooi
{
    public class Competition
    {
        public List<Team> Teams = new List<Team>();

        public void AddTeam(string name)
        {
            Team newTeam = new Team();
            newTeam.teamName = name;

            Teams.Add(newTeam);
        }

        
    }
}
