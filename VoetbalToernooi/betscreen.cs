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
    public partial class betscreen : Form
    {
        public betscreen(ListBox list)
        {
            InitializeComponent();

            foreach (var item in list.Items)
            {
                matchInfoLabel.Text = item.ToString();
            }
        }


        private void betButton_Click(object sender, EventArgs e)
        {
            decimal balance = 0;
            decimal.TryParse(balanceLabel.Text, out balance);
            decimal bet = betUpDown.Value;
            if (balance < 5)
            {
                MessageBox.Show("U heeft niet genoeg geld meer");
            }
            else if (balance < bet)
            {
                MessageBox.Show("U wilt meer inzetten dan dat u heeft");
            }
            else
            {
                decimal total = balance - bet;
                balanceLabel.Text = total.ToString();

                this.Close();
            }
        }

    }
}
