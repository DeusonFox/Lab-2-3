using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
			Fraction one = new Fraction(3, 9);
			Fraction two = new Fraction(3, 3);
			Fraction three = new Fraction(0, 2);
			Fraction four = new Fraction(5, 0);
			Fraction five = new Fraction(0, 0);
			Console.WriteLine("Сложение");
			Console.WriteLine(one + two);
			Console.WriteLine(three + four);
			Console.WriteLine(three + five);
			Console.WriteLine("Вычитание");
			Console.WriteLine(one - two);
			Console.WriteLine(one - five);
			Console.WriteLine(two - one);
			Console.WriteLine(five - one);
			Console.WriteLine(three - five);
			Console.WriteLine("Умножение");
			Console.WriteLine(one * two);
			Console.WriteLine(one * three);
			Console.WriteLine(three * three);
			Console.WriteLine(five * one);
			Console.WriteLine("Деление");
			Console.WriteLine(one / two);
			Console.WriteLine(one / three);
			Console.WriteLine(two / one);
			Console.WriteLine(three / three);
			Console.WriteLine(five / one);
			Console.WriteLine("Возведение в степень");
			Console.WriteLine(Fraction.Pow(one, 3));
			Console.WriteLine(Fraction.Pow(two, 0));
			Console.WriteLine(Fraction.Pow(three, 2));
			Console.WriteLine(Fraction.Pow(five, 0));
			Console.WriteLine("Строка");
			Console.WriteLine(one.ToString());
		}
    }
}
