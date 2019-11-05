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
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAddName_Click(object sender, EventArgs e)
        {
            

            if(lboxNames.SelectedItem != null)
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

        private void BtnRemoveName_Click(object sender, EventArgs e)
        {
            if (lbRoundNames.SelectedItem != null)
                lbRoundNames.Items.Remove(lbRoundNames.SelectedItem);

            else if (lbRoundNames.Items.Count == 0)
                MessageBox.Show("There are no more items.");

            else
                MessageBox.Show("Select an item.");
        }

        private void BtnBuyRound_Click(object sender, EventArgs e)
        {
            if(lbRoundNames.Items.Count != 0)
            {

                if(txtRndPrice.Text != "" && lbRoundNames.SelectedItem != null)
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
