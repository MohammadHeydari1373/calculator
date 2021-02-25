using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        ICalculator calculator; 
        public Form1()
        {
            InitializeComponent();
            calculator = new Calculator(); 
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (ValidationNumber())
            {
                int number1 = (int)txtNumber1.Value;
                int number2 = (int)txtNumber2.Value; 
                MessageBox.Show(calculator.Plus(number1 , number2).ToString());
            }
        }
      

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (ValidationNumber())
            {
                int number1 = (int)txtNumber1.Value;
                int number2 = (int)txtNumber2.Value;
                MessageBox.Show(calculator.Minus(number1, number2).ToString());
            }
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            if (ValidationNumber())
            {
                int number1 = (int)txtNumber1.Value;
                int number2 = (int)txtNumber2.Value;
                MessageBox.Show(calculator.Multiple(number1, number2).ToString());
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (ValidationNumber())
            {
                int number1 = (int)txtNumber1.Value;
                int number2 = (int)txtNumber2.Value;
                MessageBox.Show(calculator.Divide(number1, number2).ToString());
            }
        }


        // method 
        bool ValidationNumber()
        {
            bool status = true;
            if (txtNumber1.Value <= 0 || txtNumber2.Value <= 0)
            {
                status = false;
                MessageBox.Show("لطفا فیلد ها را خالی و یا صفر قرار ندهید");
            }
            return status;
        }
    }
}
