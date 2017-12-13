using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool operatorPressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button numberButton = (Button)sender;
            if ((tbResult.Text == "0") || (operatorPressed == true))
                tbResult.Clear();

            operatorPressed = false;

            if (numberButton.Text == ".")
            {
                if(!(tbResult.Text.Contains(".")))
                    tbResult.Text += numberButton.Text; 
            }
            else
                tbResult.Text += numberButton.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbResult.Text = "0";
            value = 0;
        }

        private void operatorClick(object sender, EventArgs e)
        {
            operatorPressed = true;
            Button operatorButton = (Button)sender;
            operation = operatorButton.Text;
            value = Double.Parse(tbResult.Text);
            lblEquation.Text = value + " " + operation;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblEquation.Text = "";
            switch (operation)
            {
                case "+":
                    tbResult.Text = (value + Double.Parse(tbResult.Text)).ToString();
                    break;
                case "-":
                    tbResult.Text = (value - Double.Parse(tbResult.Text)).ToString();
                    break;
                case "*":
                    tbResult.Text = (value * Double.Parse(tbResult.Text)).ToString();
                    break;
                case "/":
                    tbResult.Text = (value / Double.Parse(tbResult.Text)).ToString();
                    break;
                default:
                    break; 
            } // end of switch    
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            tbResult.Text = "0";
        }

        private void btnNegate_Click(object sender, EventArgs e)
        {
            tbResult.Text = (-1 * Double.Parse(tbResult.Text)).ToString();
        }
    }
}
