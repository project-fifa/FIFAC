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
        public static List<User> UserList = new List<User>();

        public int id { get; set; }
        public string firstname { get; set; }
        public string username { get; set; }
        public string lastname { get; set; }
        public string password { get; set; }

        public User(string Username)
        {
            this.username = Username;
        }

        public static void AddUserToList(User user)
        {
            UserList.Add(user);
        }
    }
}
    