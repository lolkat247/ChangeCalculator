using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // try to get int input
            int usrin;
            try
            {
                usrin = Convert.ToInt32(tbIn.Text);
            }
            catch (Exception) {
                MessageBox.Show("Invaid Input");

                return;
            }

            // do calculation
            int amount = 0; // reused var

            // quarters
            amount = 0;
            while (usrin > 24) {
                amount++;
                usrin -= 25;
            }
            tbQ.Text = Convert.ToString(amount);

            // dimes
            amount = 0;
            while (usrin > 9)
            {
                amount++;
                usrin -= 10;
            }
            tbD.Text = Convert.ToString(amount);

            // nickels
            amount = 0;
            while (usrin > 4)
            {
                amount++;
                usrin -= 5;
            }
            tbN.Text = Convert.ToString(amount);

            // pennies
            amount = 0;
            while (usrin > 0)
            {
                amount++;
                usrin -= 1;
            }
            tbP.Text = Convert.ToString(amount);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
