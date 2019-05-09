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
    public partial class Homepage : Form
    {
        public Competition competition = new Competition();
        public int TeamID = 1;
        public int StudentID = 1;

        public List<Pool> pools = new List<Pool>();

        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            BuildBaseTeams();
            
            PreparePools();

            DisplayTeams();
        }

        public void BuildBaseTeams()
        {
            Team newTeam01 = new Team();
            newTeam01.Name = "Dragons";
            newTeam01.AddPlayer("Sven", 1, 1);
            newTeam01.AddPlayer("Tom", 2, 1);
            newTeam01.AddPlayer("Romy", 3, 1);
            competition.Teams.Add(newTeam01);

            Team newTeam02 = new Team();
            newTeam02.Name = "Serpents";
            newTeam02.AddPlayer("Eric", 4, 2);
            newTeam02.AddPlayer("Jax", 5, 2);
            newTeam02.AddPlayer("Kayle", 6, 2);
            competition.Teams.Add(newTeam02);

            Team newTeam03 = new Team();
            newTeam03.Name = "Vikings";
            newTeam03.AddPlayer("Thresh", 7, 3);
            newTeam03.AddPlayer("Guthix", 8, 3);
            newTeam03.AddPlayer("Armadyl", 9, 3);
            competition.Teams.Add(newTeam03);

            Team newTeam04 = new Team();
            newTeam04.Name = "Ravens";
            newTeam04.AddPlayer("Bandos", 10, 4);
            newTeam04.AddPlayer("Zamorak", 11, 4);
            newTeam04.AddPlayer("Saradomin", 12, 4);
            competition.Teams.Add(newTeam04);
        }

        public void DisplayTeams()
        {
            for (int i = 0; i < competition.Teams.Count; i++)
            {
                teamsListView.Items.Add(competition.Teams[i].Name + competition.Teams[i].poolIndex.ToString());
            }
        }

        private void teamsListView_ItemActivate(object sender, EventArgs e)
        {
            playersListView.Clear();
            int index = teamsListView.SelectedIndices[0];

            for (int i = 0; i < competition.Teams[index].players.Count; i++)
            {
                playersListView.Items.Add(competition.Teams[index].players[i].Name);
            }
        }

        private void playersListView_ItemActivate(object sender, EventArgs e)
        {

            int playerIndex = playersListView.SelectedIndices[0];
            int TeamIndex = teamsListView.SelectedIndices[0];

            Team selectedTeam = new Team();
            selectedTeam = competition.Teams[TeamIndex];

            Player selectedPlayer = new Player();
            selectedPlayer = competition.Teams[TeamIndex].players[playerIndex];

            PNameLabel.Text = selectedPlayer.Name;
            PGoalsLabel.Text = selectedPlayer.GoalsScored.ToString();
            PAssistsLabel.Text = selectedPlayer.AssistsGiven.ToString();
            PWinsLabel.Text = selectedTeam.gamesWon.ToString();
            PLostLabel.Text = selectedTeam.gamesLost.ToString();
            PDrawLabel.Text = selectedTeam.gamesTied.ToString();
            PTeamPointsLabel.Text = selectedTeam.points.ToString();
        }

        public void PreparePools()
        {
            int teamsAmount = competition.Teams.Count;

            if (teamsAmount % 2 == 0)
            {
                BuildSelectorList(teamsAmount);
            }
            else
            {
                MessageBox.Show("Uneven Amount of Teams!");
            }
        }


        public void BuildSelectorList(int amount)
        {
            List<int> Selectors = new List<int>();
            int selector = 1;
            int counter = 0;

            for (int i = 0; i < competition.Teams.Count; i++)
            {
                if (counter == 2)
                {
                    selector++;
                    competition.Teams[i].poolIndex = selector;
                    counter = 0;
                }
                else
                {
                    counter++;
                    competition.Teams[i].poolIndex = selector;
                }
            }
        }

        public void AssignSelector(int amount, List<int> poolSelector)
        {
            Random rnd = new Random();

            for (int i = 0; i < amount; i++)
            {
                int selector = rnd.Next(1, poolSelector.Count);

                competition.Teams[i].poolIndex = poolSelector[selector];
            }
        }
    }
}
