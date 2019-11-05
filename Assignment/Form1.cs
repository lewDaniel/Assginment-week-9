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
        List<string> team = new List<string>() {"Matthew", "Tom", "John", "Jane", "Kate", "Michael"};
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
    }
}
