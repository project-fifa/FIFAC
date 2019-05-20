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
    public partial class loginForm : Form
    {
        User user;
        public loginForm()
        {
            InitializeComponent();
        }

        string[] username = { "username1", "username2" };
        string[] password = { "password1", "password2" };
        List<string> users = new List<string>();
        List<string> pass = new List<string>();

        public void LoadInfo()
        {
            if (File.Exists(@".\FifaInformation.data"))
            {
                List<User> username = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText(@".\VehicleInformation.dat"));
            }
        }

        public void SaveInfo()
        {
            File.WriteAllText(@".\InformationUser.data", JsonConvert.SerializeObject(user));
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            LoadInfo();
            SaveInfo();

            StreamReader reader = new StreamReader("vars.txt");
            string line = "";
            while ((line = reader.ReadLine()) != null)
            {
                string[] components = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                users.Add(components[0]);
                pass.Add(components[0]);
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(username.Contains(usernameTextBox.Text) && password.Contains(passwordTextBox.Text) && Array.IndexOf(username, usernameTextBox.Text) == Array.IndexOf(password, passwordTextBox.Text))
            {
                Homepage team = new Homepage();
                team.ShowDialog();
            }
            else if (users.Contains(usernameTextBox.Text) && (pass.Contains(passwordTextBox.Text) && Array.IndexOf(users.ToArray(), usernameTextBox.Text) == Array.IndexOf(pass.ToArray(), passwordTextBox.Text)))
            {
                Homepage team = new Homepage();
                team.ShowDialog();
            }
            
            else
            {
                MessageBox.Show("Verkeerde gebruikersnaam en / of verkeerde wachtwoord combinatie");
            }
        }
    }
}
