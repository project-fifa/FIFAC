using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalToernooi
{
    public class Player
    {
        public string Name { get; set; }
        public int StudentID { get; set; }
        public int TeamID { get; set; }
        public int GoalsScored = 0;
        public int AssistsGiven = 0;
    }
}
