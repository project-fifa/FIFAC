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
        private object user;
        public loginForm()
        {
            InitializeComponent();
        }

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
        }
    }
}
