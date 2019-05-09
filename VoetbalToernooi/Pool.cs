using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalToernooi
{
    public class Pool
    {
        public List<Team> Pool01 = new List<Team>();
        public List<Team> Pool02 = new List<Team>();

        public void BuildPool(List<Team> teams)
        {
            for (int i = 0; i < teams.Count; i++)
            {
                if (teams[i].poolIndex == 1)
                {
                    Pool01.Add(teams[i]);
                }
                else
                {
                    Pool02.Add(teams[i]);
                }
            }
        }
    }
}
