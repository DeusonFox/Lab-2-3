using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class NS16
    {
        private const string Dictionary = "0123456789ABCDEF";

        private static int _16to10(string num)
        {
            int result = 0;
            int exponent = 1;
            bool isNegative = num[0] == '-';
            for (int i = num.Length - 1; i >= (isNegative ? 1 : 0); i--)
                if (Dictionary.Contains(num[i]))
                {
                    result += Dictionary.IndexOf(num[i]) * exponent;
                    exponent *= 16;
                }
                else
                    throw new ArgumentException();
            if (isNegative)
                result = -result;
            return result;
        }

        private static string _10to16(int num)
        {
            string result = "";
            bool isNegative = num < 0;
            num = Math.Abs(num);
            while (num != 0)
            {
                result = result.Insert(0, Dictionary[num % 16].ToString());
                num /= 16;
            }
            if (result == "")
                result = "0";
            if (isNegative)
                result = result.Insert(0, "-");
            return result;
        }

        public static string Sum(string num1, string num2)
        {
            return _10to16(_16to10(num1) + _16to10(num2));
        }

        public static string Sum(string num1, int num2)
        {
            return _10to16(_16to10(num1) + num2);
        }

        public static string Sum(int num1, string num2)
        {
            return _10to16(num1 + _16to10(num2));
        }

        public static string Sub(string num1, string num2)
        {
            return _10to16(_16to10(num1) - _16to10(num2));
        }

        public static string Sub(string num1, int num2)
        {
            return _10to16(_16to10(num1) - num2);
        }

        public static string Sub(int num1, string num2)
        {
            return _10to16(num1 - _16to10(num2));
        }

        public static string And(string num1, string num2)
        {
            int op1 = _16to10(num1);
            int op2 = _16to10(num2);
            if (op1 < 0 || op2 < 0)
                throw new ArithmeticException();
            return _10to16(op1 & op2);
        }

        public static string And(string num1, int num2)
        {
            int op1 = _16to10(num1);
            if (op1 < 0 || num2 < 0)
                throw new ArithmeticException();
            return _10to16(op1 & num2);
        }

        public static string And(int num1, string num2)
        {
            int op2 = _16to10(num2);
            if (num1 < 0 || op2 < 0)
                throw new ArithmeticException();
            return _10to16(num1 & op2);
        }

        public static string Or(string num1, string num2)
        {
            int op1 = _16to10(num1);
            int op2 = _16to10(num2);
            if (op1 < 0 || op2 < 0)
                throw new ArithmeticException();
            return _10to16(op1 | op2);
        }

        public static string Or(string num1, int num2)
        {
            int op1 = _16to10(num1);
            if (op1 < 0 || num2 < 0)
                throw new ArithmeticException();
            return _10to16(op1 | num2);
        }

        public static string Or(int num1, string num2)
        {
            int op2 = _16to10(num2);
            if (num1 < 0 || op2 < 0)
                throw new ArithmeticException();
            return _10to16(num1 | op2);
        }
    }
}

