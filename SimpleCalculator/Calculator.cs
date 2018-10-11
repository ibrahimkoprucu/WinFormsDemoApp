using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        // violation of DRY (Don't Repeat Yourself) principle
        private void btnPlus_Click(object sender, EventArgs e)
        {
            string firstNumberText = txtFirstNumber.Text;
            string secondNumberText = txtSecondNumber.Text;

            int firstNumber = Convert.ToInt32(firstNumberText);
            int secondNumber = Convert.ToInt32(secondNumberText);

            txtResult.Text = (firstNumber + secondNumber).ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            string firstNumberText = txtFirstNumber.Text;
            string secondNumberText = txtSecondNumber.Text;

            int firstNumber = Convert.ToInt32(firstNumberText);
            int secondNumber = Convert.ToInt32(secondNumberText);

            txtResult.Text = (firstNumber - secondNumber).ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            string firstNumberText = txtFirstNumber.Text;
            string secondNumberText = txtSecondNumber.Text;

            int firstNumber = Convert.ToInt32(firstNumberText);
            int secondNumber = Convert.ToInt32(secondNumberText);

            txtResult.Text = (firstNumber * secondNumber).ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            string firstNumberText = txtFirstNumber.Text;
            string secondNumberText = txtSecondNumber.Text;

            int firstNumber = Convert.ToInt32(firstNumberText);
            int secondNumber = Convert.ToInt32(secondNumberText);

            txtResult.Text = (firstNumber / secondNumber).ToString();
        }

    }
}