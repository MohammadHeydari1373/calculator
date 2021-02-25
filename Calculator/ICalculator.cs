using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    interface ICalculator
    {
        int Minus(int number1, int number2);
        int Plus(int number1, int number2);
        int Divide(int number1, int number2);
        int Multiple(int number1, int number2); 

    }
}
