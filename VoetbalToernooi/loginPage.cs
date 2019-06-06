using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.IO;

namespace VoetbalToernooi
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void addUsersButton_Click(object sender, EventArgs e)
        {
            AddUser add = new AddUser();
            if (add.ShowDialog(this) == DialogResult.OK)
            {
                userListBox.Items.Add(add.getItem());

            }
            add.Close();
            add.Dispose();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userListBox.SelectedIndex >= 0)
            {
                StreamWriter SaveFile = new StreamWriter("user.txt");
                foreach (var item in userListBox.Items)
                {

                    SaveFile.WriteLine(item.ToString());
                    SaveFile.Write("\r");

                }
                    SaveFile.Close();

                
                HomePage home = new HomePage();
                home.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Je moet een gebruiker selecteren");
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            if (File.Exists("user.txt"))
            {
                StreamReader txt = new StreamReader("user.txt");

                string[] lines = File.ReadAllLines("user.txt");
                userListBox.Items.AddRange(lines);
                txt.Close();
            }
        }
    }
}
