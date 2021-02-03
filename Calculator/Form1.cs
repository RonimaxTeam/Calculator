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
        int statusInput = 1;
        int statusOperator;
        public enum Status
        {
            Mult = 1,
            Div = 2,
            Sum = 3,
            Sub = 4
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
            statusOperator = 0;
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
            statusOperator = 1;
            textBoxInputAndResult.Text = String.Empty;
            statusInput = 2;
            status = (int)Status.Mult;
        }
        
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            CheckStatus(status);
        }
        #endregion

        #region Methods
        public void AddNumberToTextBox(int j)
        {
            if(statusInput == 1)
            {
                
                input1 = input1 += objectNumberClass.Numbern(j).ToString().Trim();
                textBoxInputAndResult.Text = input1;
            }
            else
            {
                
                input2 = input2 += objectNumberClass.Numbern(j).ToString().Trim();
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
                statusInput = 1;
            }
            else if (a == 2)
            {
                decimal result = ObjectOperatorsClass.Div(Convert.ToDecimal(input1), Convert.ToDecimal(input2));
                textBoxInputAndResult.Text = result.ToString();
                status = 0;
                
                
                    input1 = String.Empty;
                    input2 = String.Empty;
                    statusInput = 1;
               
                
            }
            else if (a == 3)
            {
                decimal result = ObjectOperatorsClass.Summation(Convert.ToDecimal(input1), Convert.ToDecimal(input2));
                textBoxInputAndResult.Text = result.ToString();
                status = 0;
                statusInput = 1;
            }
            else if (a == 4)
            {
                decimal result = ObjectOperatorsClass.Subtraction(Convert.ToDecimal(input1), Convert.ToDecimal(input2));
                textBoxInputAndResult.Text = result.ToString();
                status = 0;
                statusInput = 1;
            }
        }

        #endregion
        private void buttonBack_Click(object sender, EventArgs e)
        {

            if (textBoxInputAndResult.Text != String.Empty && statusInput == 1)
            {
                textBoxInputAndResult.Text = input1.Substring(0, input1.Length - 1);
            }

            //int lenght = textBoxInputAndResult.Text.Length - 1;
            //string text = textBoxInputAndResult.Text;
            //textBoxInputAndResult.Clear();

            //for (int i = 0; i < length; i++)
            //{
            //    te
            //}
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            textBoxInputAndResult.Text = String.Empty;
            status = (int)Status.Sum;
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            textBoxInputAndResult.Text = String.Empty;
            status = (int)Status.Sub;
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if (true)
            {

            }
        }
    }
}
