using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoetbalToernooi
{
    public partial class gameview : Form
    {
        public gameview()
        {
            InitializeComponent();
        }


        private void gameview_Load(object sender, EventArgs e)
        {
            matchListBox.Items.Add("klik op de knop voor het wedstrijdschema");

        }

        private void betscreenButton_Click(object sender, EventArgs e)
        {
            if (matchListBox.SelectedIndex <= -1)
            {
                MessageBox.Show("Selecteer een wedstrijd");
            }
            else
            {
                betscreen form = new betscreen(matchListBox);
                form.ShowDialog();

                this.Close();
            }
        }

        private void matchButton_Click(object sender, EventArgs e)
        {
            System.Net.WebClient downloader = new System.Net.WebClient();
            string matchJson;

            try
            {
                matchJson = downloader.DownloadString("http://localhost/PHP/FIFA-PHP/gameAPI.php");
            }
            catch
            {
                MessageBox.Show("Something went wrong");
                return;
            }

            IList<Match> matches = JsonConvert.DeserializeObject<IList<Match>>(matchJson);

            matchListBox.Items.Clear();

            foreach (Match match in matches)
            {
                
                matchListBox.Items.Add(match.home_team + " - " + match.away_team);
            }
        }

        private void matchListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
