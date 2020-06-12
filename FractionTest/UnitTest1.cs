using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;

namespace FractionTest
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void tostringtest()
		{
			var v1 = new Fraction(2, 0);
			Assert.AreEqual("0/0", v1.ToString());
		}

		[TestMethod]
		public void equalstest1()
		{
			var v1 = new Fraction(2, -4);
			var v2 = new Fraction(-4, 8);
			Assert.AreEqual(Convert.ToBoolean(Fraction.Equals(v1, v2)), true);
		}
		[TestMethod]
		public void equalstest2()
		{
			var v1 = new Fraction(5, -7);
			var v2 = new Fraction(-8, 6);
			Assert.AreEqual(Convert.ToBoolean(Fraction.Equals(v1, v2)), false);
		}

		[TestMethod]
		public void equalstest3()
		{
			var v1 = new Fraction(2, 4);
			var v2 = v1;
			Assert.AreEqual(v1, v2);
		}

		[TestMethod]
		public void nodtsest()
		{
			int v1 = 2;
			int v2 = 4;
			var v3 = Fraction.NOD(v1, v2);
			var expected = 2;
			Assert.AreEqual(v3, expected);

		}

		[TestMethod]
		public void nodtestwithzero()
		{
			int v1 = 2;
			int v2 = 0;
			int v3 = Fraction.NOD(v1, v2);
			int expected = 0;
			Assert.AreEqual(v3, expected);
		}

		[TestMethod]
		public void numeratortest()
		{
			var v1 = new Fraction(2, 4);
			int expected = 1;
			Assert.AreEqual(v1.Numerator, expected);
		}
		[TestMethod]
		public void denominatortest()
		{
			var v1 = new Fraction(2, 4);
			int expected = 2;
			Assert.AreEqual(v1.Denominator, expected);
		}
		[TestMethod]
		public void reductiontest()
		{
			var v1 = new Fraction(2, 4);
			Assert.AreEqual(v1.Reduction().ToString(), "1/2");

		}
		[TestMethod]
		public void plus_opearatortest()
		{
			var v1 = new Fraction(1, 3);
			var v2 = new Fraction(1, 3);
			Assert.AreEqual((v1 + v2).ToString(), "2/3");
		}

		[TestMethod]
		public void plus_operatorwithzero()
		{
			var v1 = new Fraction(0, 0);
			var v2 = new Fraction(1, 2);
			Assert.AreEqual((v1 + v2).ToString(), "1/2");
		}
		[TestMethod]
		public void minus_operatortest()
		{
			var v1 = new Fraction(3, 4);
			var v2 = new Fraction(1, 4);
			Assert.AreEqual((v1 - v2).ToString(), "1/2");
		}

		[TestMethod]
		public void minus_operatorwithzero()
		{
			var v1 = new Fraction(0, 0);
			var v2 = new Fraction(3, 5);
			Assert.AreEqual((v1 - v2).ToString(), "-3/5");
		}

		[TestMethod]
		public void minus_testoperator1()
		{
			var v1 = new Fraction(1, 2);
			var v2 = new Fraction(1, 2);
			Assert.AreEqual((v1 - v2).ToString(), "0/0");
		}

		[TestMethod]
		public void multiplication_operatortest()
		{
			var v1 = new Fraction(1, 5);
			var v2 = new Fraction(2, 4);
			Assert.AreEqual((v1 * v2).ToString(), "1/10");
		}

		[TestMethod]
		public void multiplication_operatorwithzero()
		{
			var v1 = new Fraction(1, 5);
			var v2 = new Fraction(0, 0);
			Assert.AreEqual((v1 * v2).ToString(), "0/0");
		}

		[TestMethod]
		public void division_operatortest()
		{
			var v1 = new Fraction(3, 5);
			var v2 = new Fraction(7, 11);
			Assert.AreEqual((v1 / v2).ToString(), "33/35");
		}

		[TestMethod]
		public void division_operatorwithzero()
		{
			var v1 = new Fraction(0, 0);
			var v2 = new Fraction(1, 5);
			Assert.AreEqual((v1 / v2).ToString(), "0/0");
		}

		[TestMethod]
		public void pow_operatortwithzero1()
		{
			var v1 = new Fraction(3, 4);
			Assert.AreEqual((Fraction.Pow(v1, 0)).ToString(), "1/1");
		}

		[TestMethod]
		public void pow_operatorwithzero2()
		{
			var v1 = new Fraction(0, 0);
			Assert.AreEqual((Fraction.Pow(v1, 0)).ToString(), "1/1");
		}

		[TestMethod]
		public void pow_operatortest()
		{
			var v1 = new Fraction(1, 2);
			Assert.AreEqual((Fraction.Pow(v1, 2)).ToString(), "1/4");
		}
	}
}