using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public partial class Operators
    {
        public decimal Summation(decimal firstNumber, decimal seccondNumber)
        {
            decimal sum = firstNumber + seccondNumber;
            return sum;
        }
        public decimal Subtraction(decimal firstNumber, decimal seccondNumber)
        {
            decimal sub = firstNumber - seccondNumber;
            return sub;
        }
    }
}
