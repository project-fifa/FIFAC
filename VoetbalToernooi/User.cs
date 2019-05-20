using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace VoetbalToernooi
{
    public class User
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string username { get; set; }
        public string lastname { get; set; }
        public string password { get; set; }

    }
}
    