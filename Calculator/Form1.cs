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
            Button operatorButton = (Button)sender;
            operatorPressed = true;
            operation = operatorButton.Text;

            if (value != 0)
            {
                if (operatorButton.Text == "sqrt")
                    tbResult.Text = Math.Sqrt(Double.Parse(tbResult.Text)).ToString();
                btnCalculate.PerformClick();
            }
            else if (operatorButton.Text == "sqrt")
            {
                tbResult.Text = Math.Sqrt(Double.Parse(tbResult.Text)).ToString();
                value = Math.Sqrt(Double.Parse(tbResult.Text));
            }
            else
            {
                value = Double.Parse(tbResult.Text);
            }
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
            value = Double.Parse(tbResult.Text);
            operation = "";
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            tbResult.Text = "0";
        }

        private void btnNegate_Click(object sender, EventArgs e)
        {
            tbResult.Text = (-1 * Double.Parse(tbResult.Text)).ToString();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    btn0.PerformClick();
                    break;
                case "1":
                    btn1.PerformClick();
                    break;
                case "2":
                    btn2.PerformClick();
                    break;
                case "3":
                    btn3.PerformClick();
                    break;
                case "4":
                    btn4.PerformClick();
                    break;
                case "5":
                    btn5.PerformClick();
                    break;
                case "6":
                    btn6.PerformClick();
                    break;
                case "7":
                    btn7.PerformClick();
                    break;
                case "8":
                    btn8.PerformClick();
                    break;
                case "9":
                    btn9.PerformClick();
                    break;
                case "+":
                    btnPlus.PerformClick();
                    break;
                case "-":
                    btnMinus.PerformClick();
                    break;
                case "*":
                    btnMultiply.PerformClick();
                    break;
                case "/":
                    btnDivision.PerformClick();
                    break;
                case ".":
                    btnDecimalPoint.PerformClick();
                    break;
                default:
                    break;
            }
        }
    }
}
