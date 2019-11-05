using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign_Week_9
{
    public partial class Form1 : Form
    {
        List<string> team = new List<string>() { "Matthew", "Tom", "John", "Jane", "Kate", "Michael" };
        List<double> balance = new List<double>() { 0, 0, 0, 0, 0, 0 };

        void lboxRefill()
        {
            int teamLength = team.Count();
            lboxNames.Items.Clear();
            lboxBalance.Items.Clear();

            for (int i = 0; i < teamLength; i++)
            {
                lboxNames.Items.Add(team[i]);
                lboxBalance.Items.Add(balance[i]);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            lboxRefill();
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            int currentIndex = lboxNames.SelectedIndex;

            if (currentIndex >= 0)
            {
                team.RemoveAt(currentIndex);
                lboxRefill();
            }
            else
            {
                MessageBox.Show("You need to select somebody");
            }
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            string member = tboxMember.Text;

            if (member != "")
            {
                team.Add(member);
                balance.Add(0);

                lboxRefill();
            }
            else
            {
                MessageBox.Show("You must enter the name");
            }
        }

        private void btnRemoveName_Click(object sender, EventArgs e)
        {
            string member = tboxMember.Text;

            if (member != "")
            {
                team.Remove(member);
                balance.RemoveAt(0);
                lboxRefill();
            }
            else
            {
                MessageBox.Show("You must enter the name");
            }

        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            if (lboxNames.SelectedItem != null)
            {
                string name = lboxNames.SelectedItem.ToString();

                if (lbRoundNames.Items.Contains(name) == false)
                    lbRoundNames.Items.Add(name);
                else
                    MessageBox.Show("Name already added.");

            }
            else
            {
                MessageBox.Show("Please select a name!");
            }
        }

        private void btnRemoveName_Click_1(object sender, EventArgs e)
        {
            if (lbRoundNames.SelectedItem != null)
                lbRoundNames.Items.Remove(lbRoundNames.SelectedItem);

            else if (lbRoundNames.Items.Count == 0)
                MessageBox.Show("There are no more items.");

            else
                MessageBox.Show("Select an item.");
        }

        private void btnBuyRound_Click(object sender, EventArgs e)
        {
            if (lbRoundNames.Items.Count != 0)
            {

                if (txtRndPrice.Text != "" && lbRoundNames.SelectedItem != null)
                {
                    string roundBuyer = lbRoundNames.SelectedItem.ToString();
                    double roundPrice = Convert.ToDouble(txtRndPrice.Text);
                    int moneyRoundBuyer = lboxNames.Items.IndexOf(roundBuyer);
                    double sumRoundBuyer = Convert.ToDouble(lboxBalance.Items[moneyRoundBuyer]);

                    lboxBalance.Items[moneyRoundBuyer] = sumRoundBuyer + roundPrice;

                    int roundPeople = lbRoundNames.Items.Count;
                    double priceAfter = roundPrice / roundPeople;

                    for (int i = 0; i < lboxNames.Items.Count; i++)
                    {
                        for (int n = 0; n < lbRoundNames.Items.Count; n++)
                        {
                            if (lbRoundNames.Items[n] == lboxNames.Items[i] && lboxNames.Items[i] != roundBuyer)
                            {
                                double amountOfMoney = Convert.ToDouble(lboxBalance.Items[i]) + priceAfter;
                                lboxBalance.Items[i] = amountOfMoney.ToString("00.00");
                            }
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Select a Round Buyer or enter a price, please.");
                }

            }
            else
            {
                MessageBox.Show("There are no people to select.");
            }
        }
    }
}