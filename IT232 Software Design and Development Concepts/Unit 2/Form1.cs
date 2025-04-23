using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT232_Crooks_Unit2
{
    public partial class Calc : Form
    {
        int num1 = 0;
        int total = 0;
        string OperatorLastClicked = "nothing";
        int noNumsSelected = 1;
        public Calc()
        {
            InitializeComponent();
        }
        private int calculate()
        {
            if (OperatorLastClicked == "nothing")
            {
                total = num1;
                num1 = 0;
            }

            if (OperatorLastClicked == "add")
            {
                total = total + num1;
                num1 = 0;
            }

            if (OperatorLastClicked == "multiply")
            {
                total = total * num1;
                num1 = 0;
            }

            if (OperatorLastClicked == "subtract")
            {
                total = total - num1;
                num1 = 0;
            }

            if (OperatorLastClicked == "divide")
            {
                total = total / num1;
                num1 = 0;
            }
            return total;
        }
        private void cmd1_Click(object sender, EventArgs e)
        {
            if (noNumsSelected == 1)
            {
                lblDisplay.Text = "";
                noNumsSelected = 0;
            }
            lblDisplay.Text += "1";
            num1 = (num1 * 10) + 1;
        }

        private void cmd2_Click(object sender, EventArgs e)
        {
            if (noNumsSelected == 1)
            {
                lblDisplay.Text = "";
                noNumsSelected = 0;
            }
            lblDisplay.Text += "2";
            num1 = (num1 * 10) + 2;
        }

        private void cmd3_Click(object sender, EventArgs e)
        {
            if (noNumsSelected == 1)
            {
                lblDisplay.Text = "";
                noNumsSelected = 0;
            }
            lblDisplay.Text += "3";
            num1 = (num1 * 10) + 3;
        }

        private void cmd4_Click(object sender, EventArgs e)
        {
            if (noNumsSelected == 1)
            {
                lblDisplay.Text = "";
                noNumsSelected = 0;
            }
            lblDisplay.Text += "4";
            num1 = (num1 * 10) + 4;
        }
        private void cmd5_Click(object sender, EventArgs e)
        {
            if (noNumsSelected == 1)
            {
                lblDisplay.Text = "";
                noNumsSelected = 0;
            }
            lblDisplay.Text += "5";
            num1 = (num1 * 10) + 5;
        }

        private void cmd6_Click(object sender, EventArgs e)
        {
            if (noNumsSelected == 1)
            {
                lblDisplay.Text = "";
                noNumsSelected = 0;
            }
            lblDisplay.Text += "6";
            num1 = (num1 * 10) + 6;
        }

        private void cmd7_Click(object sender, EventArgs e)
        {
            if (noNumsSelected == 1)
            {
                lblDisplay.Text = "";
                noNumsSelected = 0;
            }
            lblDisplay.Text += "7";
            num1 = (num1 * 10) + 7;
        }

        private void cmd8_Click(object sender, EventArgs e)
        {
            if (noNumsSelected == 1)
            {
                lblDisplay.Text = "";
                noNumsSelected = 0;
            }
            lblDisplay.Text += "8";
            num1 = (num1 * 10) + 8;
        }

        private void cmd9_Click(object sender, EventArgs e)
        {
            if (noNumsSelected == 1)
            {
                lblDisplay.Text = "";
                noNumsSelected = 0;
            }
            lblDisplay.Text += "9";
            num1 = (num1 * 10) + 9;
        }

        private void cmd0_Click(object sender, EventArgs e)
        {
            if (noNumsSelected == 1)
            {
                lblDisplay.Text = "";
                noNumsSelected = 0;
            }
            lblDisplay.Text += "0";
            num1 = (num1 * 10);
        }
        private void cmdClr_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
            lblOperation.Text = "";
            OperatorLastClicked = "nothing";
            noNumsSelected = 1;
            total = 0;
            num1 = 0;
        }
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (noNumsSelected == 1)
            {
                lblDisplay.Text = "You need to click a number before an operation";
            }
            else
            {
                lblDisplay.Text += "+";
                lblOperation.Text += lblDisplay.Text;
                lblDisplay.Text = "";
                total = calculate();
                OperatorLastClicked = "add";
            }

        }

        private void cmdMul_Click(object sender, EventArgs e)
        {
            if (noNumsSelected == 1)
            {
                lblDisplay.Text = "You need to click a number before an operation";
                lblOperation.Text = "";
            }
            else
            {
                lblDisplay.Text += "*";
                lblOperation.Text += lblDisplay.Text;
                lblDisplay.Text = "";
                total = calculate();
                OperatorLastClicked = "multiply";
            }
        }

        private void cmdSub_Click_1(object sender, EventArgs e)
        {
            if (noNumsSelected == 1)
            {
                lblDisplay.Text = "You need to click a number before an operation";
                lblOperation.Text = "";
            }
            else
            {
                lblDisplay.Text += "-";
                lblOperation.Text += lblDisplay.Text;
                lblDisplay.Text = "";
                total = calculate();
                OperatorLastClicked = "subtract";
            }
        }

        private void cmdDiv_Click_1(object sender, EventArgs e)
        {
            if (noNumsSelected == 1)
            {
                lblDisplay.Text = "You need to click a number before an operation";
                lblOperation.Text = "";
            }
            else
            {
                lblDisplay.Text += "/";
                lblOperation.Text += lblDisplay.Text;
                lblDisplay.Text = "";
                total = calculate();
                OperatorLastClicked = "divide";
            }
        }
   

        private void cmdEqual_Click_1(object sender, EventArgs e)
        {
            if (noNumsSelected == 1)
            {
                lblDisplay.Text = "You need to click a number before an operation";
                lblOperation.Text = "";
            }
            else
            {
                lblOperation.Text += lblDisplay.Text;
                calculate();
                lblDisplay.Text = "Result: " + total.ToString();
                num1 = 0;
                total = 0;
                noNumsSelected = 1;
            }
        }
    }
}
