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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
            addUserButton.DialogResult = DialogResult.OK;
            cancelButton.DialogResult = DialogResult.Cancel;
        }

        public string getItem()
        {
            return usernameTextBox.Text;
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {

        }
    }
}
