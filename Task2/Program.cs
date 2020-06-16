using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
		static void Main(string[] args)
		{
			Polynomial a = new Polynomial(new double[4] { 1, -2, 3, -4 });
			Polynomial b = new Polynomial(new double[5] { 5, 4, 3, 2, 1 });
			Polynomial c = new Polynomial(new double[4] { 1, 2, 3, 4 });
			Polynomial d = new Polynomial(new double[1] { 2 });
			Console.WriteLine(a + b);
			Console.WriteLine(c * d);
		}
	}
}
