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
    public partial class AddTeam : Form
    {
        public List<string> newPlayers = new List<string>();
        public string newTeamName;

        public AddTeam()
        {
            InitializeComponent();

            MakePlayers();
            BuildTeam();
        }

        public void MakePlayers()
        {
            newPlayers.Add(player1Textbox.Text);
            newPlayers.Add(player2Textbox.Text);
            newPlayers.Add(player3Textbox.Text);
            newPlayers.Add(player4Textbox.Text);
            newPlayers.Add(player5Textbox.Text);
            newPlayers.Add(player6Textbox.Text);
            newPlayers.Add(player7Textbox.Text);
            newPlayers.Add(player8Textbox.Text);
            newPlayers.Add(player9Textbox.Text);
            newPlayers.Add(player10Textbox.Text);
        }

        public void BuildTeam()
        {
            newTeamName = teamNameTexbox.Text;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (teamNameTexbox.Text != "" && player1Textbox.Text != "")
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Choose a name, and add atleast 1 player");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddTeam_Load(object sender, EventArgs e)
        {

        }
    }
}
