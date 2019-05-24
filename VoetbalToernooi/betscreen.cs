using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        decimal balance = 0;


        private void betButton_Click(object sender, EventArgs e)
        {

            decimal.TryParse(balanceLabel.Text, out balance);
            decimal bet = betUpDown.Value;
            if (balance < 5)
            {
                MessageBox.Show("U heeft niet genoeg geld");
            }
            else if (balance < bet)
            {
                MessageBox.Show("U wilt meer inzetten dan dat u heeft");
            }
            else
            {
                decimal total = balance - bet;
                balanceLabel.Text = total.ToString();

                StreamWriter txt = new StreamWriter("data.txt");
                txt.Write(balanceLabel.Text);
                txt.Write("\n");
                txt.Close();
                this.Close();

            }
        }


        private void betscreen_Load(object sender, EventArgs e)
        {
            if (File.Exists("data.txt"))
            {
                StreamReader txt = new StreamReader("data.txt");
                balanceLabel.Text = txt.ReadLine();
                txt.Close();
            }
            else
            {
                balance = 50;
            }
        }
    }
}
