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
            balanceLabel.Text = "50";
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
        string[] team = new string[] { "team 1", "team 2", "team 3", "team 4" };
        private void winOrLoseButton_Click(object sender, EventArgs e)
        {
            decimal bet;
            decimal.TryParse(betLabel.Text, out bet);
            decimal balance;
            decimal.TryParse(balanceLabel.Text, out balance);
            if (matchListBox.SelectedIndex == 0)
            {
                if (teamBetLabel.Text == team[0])
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
                if (teamBetLabel.Text == team[1])
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
                if (teamBetLabel.Text == team[2])
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
                if (teamBetLabel.Text == team[3])
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
                    MessageBox.Show("gelukt");

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
    }
    }

