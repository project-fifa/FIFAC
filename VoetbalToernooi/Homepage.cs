using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace VoetbalToernooi
{
    public partial class HomePage : Form
    {

        public HomePage()
        {
            InitializeComponent();
            GetUserData();
            GetPlayerData();
            GetTeamData();
        }

        public void GetUserData()
        {
            System.Net.WebClient downloader = new System.Net.WebClient();
            string userJson;

            try
            {
                userJson = downloader.DownloadString("http://localhost/PHP/FIFA-PHP/usersAPI.php");
            }
            catch
            {
                MessageBox.Show("Something went wrong");
                return;
            }

            IList<User> Users = JsonConvert.DeserializeObject<IList<User>>(userJson);

            for (int i = 0; i < Users.Count; i++)
            {
                usersListBox.Items.Add(Users[i].firstname + " " + Users[i].lastname);
            }
        }
        public void GetPlayerData()
        {
            System.Net.WebClient downloader = new System.Net.WebClient();
            string playerJson;

            try
            {
                playerJson = downloader.DownloadString("http://localhost/PHP/FIFA-PHP/playerAPI.php");
            }
            catch
            {
                MessageBox.Show("Something went wrong");
                return;
            }

            IList<Player> Players = JsonConvert.DeserializeObject<IList<Player>>(playerJson);

            for (int i = 0; i < Players.Count; i++)
            {
                playersListBox.Items.Add(Players[i].fullName);
            }
        }

        public void GetTeamData()
        {
            System.Net.WebClient downloader = new System.Net.WebClient();
            string teamJson;

            try
            {
                teamJson = downloader.DownloadString("http://localhost/PHP/FIFA-PHP/teamAPI.php");
            }
            catch
            {
                MessageBox.Show("Something went wrong");
                return;
            }

            IList<Team> Teams = JsonConvert.DeserializeObject<IList<Team>>(teamJson);

            for (int i = 0; i < Teams.Count; i++)
            {
                teamsListBox.Items.Add(Teams[i].teamName);
            }
        }

        private void teamListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void LoadInfo()
        {
            if (File.Exists(@".\FifaInformation.data"))
            {
                List<User> username = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText(@".\VehicleInformation.dat"));
            }
        }


        private void Homepage_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }

        private void betscreenButton_Click(object sender, EventArgs e)
        {
            gameview form = new gameview();
            form.ShowDialog();

        }
    }
}
