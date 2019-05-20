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

            matchListBox.Items.Add("team 1 - team 2");
            matchListBox.Items.Add("team 3 - team 4");
            matchListBox.Items.Add("team 1 - team 3");
            matchListBox.Items.Add("team 4 - team 2");
            matchListBox.Items.Add("team 1 - team 4");
            matchListBox.Items.Add("team 3 - team 2");
        }

        private void betscreenButton_Click(object sender, EventArgs e)
        {
            if (matchListBox.SelectedIndex <= 0)
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
    }
}
