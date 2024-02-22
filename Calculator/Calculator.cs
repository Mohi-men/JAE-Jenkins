using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator<T> where T: INumber<T>
    {
        public static T Add(T num1, T num2)
        {
            return num1 + num2;
        }

        public static T Subtract(T num1, T num2)
        {
            return num1 - num2;
        }

        public static T Divide(T num1, T num2)
        {
            return num1 / num2;
        }

        public static T Multiply(T num1, T num2)
        {
            return num1 * num2;
        }
    }
}
