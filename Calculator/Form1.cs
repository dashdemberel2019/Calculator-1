using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double firstNumber = 0;
        string operation = "";
        bool newNumber = true;
        public Form1()
        {
            InitializeComponent();
        }
        private void Number_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null)
                return;
            string number = btn.Text;

            if (newNumber || txtDisplay.Text == "0")
            {
                txtDisplay.Text = number;
                newNumber = false;
            }
            else
            {
                txtDisplay.Text += number;
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Number_Click(btn1, e);
            // Энэ функцийн бие нь хаана байна
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            Number_Click(btn5, e);
        }
        private void button6_Click_1(object sender, EventArgs e)
        {
            Number_Click(btn6, e);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }
        private void Operation_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtDisplay.Text, out firstNumber))
                return;

            Button btn = sender as Button;
            if (btn == null)
                return;
            operation = btn.Text;
            newNumber = true;
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(operation))
                return;

            if (!double.TryParse(txtDisplay.Text, out double secondNumber))
                return;

            double result;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;

                case "-":
                    result = firstNumber - secondNumber;
                    break;

                case "×":
                case "*":
                    result = firstNumber * secondNumber;
                    break;

                case "÷":
                case "/":
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("0-д хувааж болохгүй!");
                        return;
                    }

                    result = firstNumber / secondNumber;
                    break;

                default:
                    return;
            }

            txtDisplay.Text = result.ToString();
            firstNumber = result;
            operation = "";
            newNumber = true;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            firstNumber = 0;
            operation = "";
            newNumber = true;
        }
        private void txtDisplay_MaskInputRejected(
            object sender,
            MaskInputRejectedEventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Number_Click(btn1, e);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Number_Click(btn6, e);
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            Number_Click(btn5, e);
        }
    }
}
