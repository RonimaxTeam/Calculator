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
        Number objectNumberClass = new Number();
        Operators ObjectOperatorsClass = new Operators();
        string input1;
        string input2;
        int status;
        public enum Status
        {
            Mult = 1,
            Div = 2,
        }

       
        public Form1()
        {
            InitializeComponent();
            textBoxInputAndResult.Text = "0";
        }

        #region Number Button Events
        private void button0_Click(object sender, EventArgs e)
        {
            AddNumberToTextBox(0);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddNumberToTextBox(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddNumberToTextBox(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddNumberToTextBox(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            AddNumberToTextBox(4);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            AddNumberToTextBox(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddNumberToTextBox(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddNumberToTextBox(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddNumberToTextBox(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddNumberToTextBox(10);
        }
        #endregion

        #region Operator Button Events
        private void buttonDiv_Click(object sender, EventArgs e)
        {
            textBoxInputAndResult.Text = String.Empty;
            status = (int)Status.Div;

        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBoxInputAndResult.Text = "0";
            input1 = String.Empty;
            input2 = String.Empty;
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            textBoxInputAndResult.Text = String.Empty;
            status = (int)Status.Mult;
        }
        
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            CheckStatus(status);
        }
        #endregion

        public void AddNumberToTextBox(int i)
        {
            if (textBoxInputAndResult.Text != String.Empty)
            {
                input1 = input1 += objectNumberClass.Numbern(i).ToString().Trim();
                textBoxInputAndResult.Text = input1;
            }
            else
            {
                textBoxInputAndResult.Text = String.Empty;
                input2 = input2 += objectNumberClass.Numbern(i).ToString().Trim();
                textBoxInputAndResult.Text = input2;
            }
        }
        public void CheckStatus(int a)
        {
            if (a == 1)
            {
                decimal result = ObjectOperatorsClass.Mult(Convert.ToDecimal(input1), Convert.ToDecimal(input2));
                textBoxInputAndResult.Text = result.ToString();
                status = 0;
                input1 = String.Empty;
                input2 = String.Empty;
            }
            else if (a == 2)
            {
                decimal result = ObjectOperatorsClass.Div(Convert.ToDecimal(input1), Convert.ToDecimal(input2));
                textBoxInputAndResult.Text = result.ToString();
                status = 0;
                input1 = String.Empty;
                input2 = String.Empty;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {

        }
    }
}
