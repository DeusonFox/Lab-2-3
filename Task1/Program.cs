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
			Fraction one = new Fraction(-3, 9);
			Fraction two = new Fraction(3, -9);
			Fraction three = new Fraction(0, 2);
			Fraction dsf = new Fraction(5, 0);
			//	Console.WriteLine("Сложение");
			//	Console.WriteLine(one + two);
			//	Console.WriteLine(one + three);
			Console.WriteLine("Вычитание");
			Console.WriteLine(one - two);
			Console.WriteLine(two - one);
			//	Console.WriteLine("Умножение");
			//	Console.WriteLine(one * two);
			//	Console.WriteLine(one * three);
			//	Console.WriteLine(three * three);
			//	Console.WriteLine("Деление");
			//	Console.WriteLine(one / two);
			//	Console.WriteLine(one / three);
			//	Console.WriteLine(two / one);
			//	Console.WriteLine(three / three);
			//	Console.WriteLine("Возведение в степень");
			//	Console.WriteLine(Fraction.Pow(one, 3));
			//	Console.WriteLine(Fraction.Pow(two, 0));
			//	Console.WriteLine(Fraction.Pow(three, 0));
			//	Console.WriteLine("Строка");
			//	Console.WriteLine(one.ToString());
			//	Console.WriteLine(two.ToString());
			//	Console.WriteLine(three.ToString());
		}
	}
}
