using Newtonsoft.Json;
using System;
using System.Collections;
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
            balanceLabel.Text = "50";
        }



        private void matchButton_Click(object sender, EventArgs e)
        {
            matchListBox.Items.Clear();
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

            foreach (Match match in matches)
            {
                
                matchListBox.Items.Add(match.home_team + " - " + match.away_team);
            }
        }
        
        private void winOrLoseButton_Click(object sender, EventArgs e)
        {
            

            decimal bet;
            decimal.TryParse(betLabel.Text, out bet);
            decimal balance;
            decimal.TryParse(balanceLabel.Text, out balance);
            if (matchListBox.SelectedIndex == 0)
            {
                if (teamBetLabel.Text == "Uitteam")
                {
                    decimal total = balance + bet + bet;
                    balanceLabel.Text = total.ToString();
                    MessageBox.Show("Gefelictiteerd u heeft gewonnen");

                }

                else
                 {
                    MessageBox.Show("Helaas u heeft op het verkeerde team gewed");
               
                 }
            }
            if (matchListBox.SelectedIndex == 1)
            {
                if (teamBetLabel.Text == "Gelijkspel")
                {
                    decimal total = balance + bet + bet;
                    balanceLabel.Text = total.ToString();
                    MessageBox.Show("Gefelictiteerd u heeft gewonnen");
                }

                else
                {
                    MessageBox.Show("Helaas u heeft op het verkeerde team gewed");
                }
            }
            if (matchListBox.SelectedIndex == 2)
            {
                if (teamBetLabel.Text == "Gelijkspel")
                {
                   decimal total = balance + bet + bet;
                   balanceLabel.Text = total.ToString();
                    MessageBox.Show("Gefelictiteerd u heeft gewonnen");
                }

                else
                {
                    MessageBox.Show("Helaas u heeft op het verkeerde team gewed");
                }
            }
            if (matchListBox.SelectedIndex == 3)
            {
                if (teamBetLabel.Text == "Gelijkspel")
                {
                    decimal total = balance + bet + bet;
                    balanceLabel.Text = total.ToString();
                    MessageBox.Show("Gefelictiteerd u heeft gewonnen");
                }

                else
                {
                    MessageBox.Show("Helaas u heeft op het verkeerde team gewed");
                }
            }

            if (matchListBox.SelectedIndex == 4)
            {
                if (teamBetLabel.Text == "Uitteam")
               {
                 decimal total = balance + bet + bet;
                 balanceLabel.Text = total.ToString();
                 MessageBox.Show("Gefelictiteerd u heeft gewonnen");
               }

                else
                {
                    MessageBox.Show("Helaas u heeft op het verkeerde team gewed");
                }
            }
            if (matchListBox.SelectedIndex == 5)
            {
                if (teamBetLabel.Text == "Thuisteam")
                {
                    decimal total = balance + bet + bet;
                    balanceLabel.Text = total.ToString();
                    MessageBox.Show("Gefelictiteerd u heeft gewonnen");
                }

               else
               {
                   MessageBox.Show("Helaas u heeft op het verkeerde team gewed");
                }
            }


            matchLabel.Text = "";
            betLabel.Text = "";
            teamBetLabel.Text = "";
            euroLabel.Text = "";
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            {
                decimal balance;
                decimal bet;
                bet = betNumericUpDown.Value;
                decimal.TryParse(balanceLabel.Text, out balance);
                if (teamComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecteer een team");
                }
                else if (balance < betNumericUpDown.Value)
                {
                    MessageBox.Show("U heeft niet genoeg geld meer");
                }
                else
                {

                    matchLabel.Text = matchListBox.SelectedItem.ToString();
                    betLabel.Text = betNumericUpDown.Value.ToString();
                    teamBetLabel.Text = teamComboBox.SelectedItem.ToString();
                    euroLabel.Text = "€";
                    decimal total = balance - betNumericUpDown.Value;
                    balanceLabel.Text = total.ToString();
                    teamComboBox.Items.Clear();
                    betNumericUpDown.Value = 1;


                }
            }
        }

        private void matchListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            System.Net.WebClient downloader = new System.Net.WebClient();
            string teamJson;

            try
            {
                teamJson = downloader.DownloadString("http://localhost/PHP/FIFA-PHP/teamAPI.php");
            }
            catch 
            {
                MessageBox.Show("Er is iets fout gegaan");
                return;
            }

            IList<Team> teams = JsonConvert.DeserializeObject<IList<Team>>(teamJson);
            

            teams.ToArray();
            
            if (matchListBox.SelectedIndex == 0)
            {
                teamComboBox.Items.Clear();
                teamComboBox.Items.Add("Thuisteam");
                teamComboBox.Items.Add("Gelijkspel");
                teamComboBox.Items.Add("Uitteam");
            }
            if (matchListBox.SelectedIndex == 1)
            {
                teamComboBox.Items.Clear();
                teamComboBox.Items.Add("Thuisteam");
                teamComboBox.Items.Add("Gelijkspel");
                teamComboBox.Items.Add("Uitteam");
            }
            if (matchListBox.SelectedIndex == 2)
            {
                teamComboBox.Items.Clear();
                teamComboBox.Items.Add("Thuisteam");
                teamComboBox.Items.Add("Gelijkspel");
                teamComboBox.Items.Add("Uitteam");
            }
            if (matchListBox.SelectedIndex == 3)
            {
                teamComboBox.Items.Clear();
                teamComboBox.Items.Add("Thuisteam");
                teamComboBox.Items.Add("Gelijkspel");
                teamComboBox.Items.Add("Uitteam");
            }
            if (matchListBox.SelectedIndex == 4)
            {
                teamComboBox.Items.Clear();
                teamComboBox.Items.Add("Thuisteam");
                teamComboBox.Items.Add("Gelijkspel");
                teamComboBox.Items.Add("Uitteam");
            }
            if (matchListBox.SelectedIndex == 5)
            {
                teamComboBox.Items.Clear();
                teamComboBox.Items.Add("Thuisteam");
                teamComboBox.Items.Add("Gelijkspel");
                teamComboBox.Items.Add("Uitteam");
            }
        }

        private void teamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }


