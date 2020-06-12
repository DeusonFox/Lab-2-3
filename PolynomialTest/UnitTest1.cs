using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2;
namespace PolynomialTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Degree()
        {
            Polynomial p = new Polynomial(new double[3] { 3, -2, 2 });
            Assert.AreEqual(2, p.Degree);
        }
        [TestMethod]
        public void DegreeWithZeroInTheMiddle()
        {
            Polynomial p = new Polynomial(new double[3] { 3, 0, 2 });
            Assert.AreEqual(2, p.Degree);
        }
        [TestMethod]
        public void DegreeWithZeroAtTheEnd()
        {
            Polynomial p = new Polynomial(new double[4] { 3, -2, 0, 0 });
            //Assert.AreEqual(3, p[0]);
            Assert.AreEqual("-2x+3", p.ToString());
            Assert.AreEqual(1, p.Degree);
        }
        [TestMethod]
        public void DegreeOfZeroPolynomial()
        {
            Polynomial p = new Polynomial(new double[4]);
            Assert.AreEqual(0, p.Degree);
        }
        [TestMethod]
        public void ToStringTest()
        {
            Polynomial p = new Polynomial(new double[3] { 3, -2, 2 });
            Assert.AreEqual("2x^2-2x+3", p.ToString());
        }
        [TestMethod]
        public void ToStringWithOne()
        {
            Polynomial p = new Polynomial(new double[3] { 3, -2, 1 });
            Assert.AreEqual("x^2-2x+3", p.ToString());
        }
        [TestMethod]
        public void ToStringWithOneAtTheEnd()
        {
            Polynomial p = new Polynomial(new double[3] { 1, -2, 3 });
            Assert.AreEqual("3x^2-2x+1", p.ToString());
        }
        [TestMethod]
        public void ToStringWithMinusOne()
        {
            Polynomial p = new Polynomial(new double[3] { 3, -2, -1 });
            Assert.AreEqual("-x^2-2x+3", p.ToString());
        }
        [TestMethod]
        public void ToStringWithMinusOneAtTheEnd()
        {
            Polynomial p = new Polynomial(new double[3] { -1, -2, 3 });
            Assert.AreEqual("3x^2-2x-1", p.ToString());
        }
        [TestMethod]
        public void ToStringWithZeroInTheMiddle()
        {
            Polynomial p = new Polynomial(new double[3] { 3, 0, 1 });
            Assert.AreEqual("x^2+3", p.ToString());
        }
        [TestMethod]
        public void ToStringWithZeroAtTheEnd()
        {
            Polynomial p = new Polynomial(new double[3] { 3, 2, 0 });
            Assert.AreEqual("2x+3", p.ToString());
        }
        [TestMethod]
        public void ToStringWithZeroAtTheBeginning()
        {
            Polynomial p = new Polynomial(new double[3] { 0, 2, 3 });
            Assert.AreEqual("3x^2+2x", p.ToString());
        }
        [TestMethod]
        public void ToStringWithZeroDegree()
        {
            Polynomial p = new Polynomial(new double[1] { 3 });
            Assert.AreEqual("3", p.ToString());
        }
        [TestMethod]
        public void ToStringOfZeroPolynomial()
        {
            Polynomial p = new Polynomial(new double[4]);
            Assert.AreEqual("0", p.ToString());
        }
        [TestMethod]
        public void GetValue()
        {
            Polynomial p = new Polynomial(new double[4] { 3, 2, 0, 1 });
            Assert.AreEqual(15, p.GetValue(2));
        }
        [TestMethod]
        public void GetValueWithZeroDegreePolynomial()
        {
            Polynomial p = new Polynomial(new double[1] { 3 });
            Assert.AreEqual(3, p.GetValue(4));
        }
        [TestMethod]
        public void AdditionDegree()
        {
            Polynomial p1 = new Polynomial(new double[3] { 2, 0, 3 });
            Polynomial p2 = new Polynomial(new double[4] { -1, 5, 2, 1 });
            Assert.AreEqual(3, (p1 + p2).Degree);
        }
        [TestMethod]
        public void Addition()
        {
            Polynomial p1 = new Polynomial(new double[3] { 2, 0, 3 });
            Polynomial p2 = new Polynomial(new double[4] { -3, 5, 2, 1 });
            Assert.AreEqual("x^3+5x^2+5x-1", (p1 + p2).ToString());
        }
        [TestMethod]
        public void AdditionWithDegreeDecreaseDegree()
        {
            Polynomial p1 = new Polynomial(new double[3] { 2, 0, 3 });
            Polynomial p2 = new Polynomial(new double[3] { -1, 0, -3 });
            Assert.AreEqual(0, (p1 + p2).Degree);
        }
        [TestMethod]
        public void AdditionWithDegreeDecrease()
        {
            Polynomial p1 = new Polynomial(new double[3] { 2, 0, 3 });
            Polynomial p2 = new Polynomial(new double[3] { -1, 0, -3 });
            Assert.AreEqual("1", (p1 + p2).ToString());
        }
        [TestMethod]
        public void SubstractionDegree()
        {
            Polynomial p1 = new Polynomial(new double[3] { 2, 0, 3 });
            Polynomial p2 = new Polynomial(new double[4] { -1, 5, 2, 1 });
            Assert.AreEqual(3, (p1 - p2).Degree);
        }
        [TestMethod]
        public void Substraction()
        {
            Polynomial p1 = new Polynomial(new double[3] { 2, 0, 3 });
            Polynomial p2 = new Polynomial(new double[4] { -3, 5, 2, 1 });
            Assert.AreEqual("-x^3+x^2-5x+5", (p1 - p2).ToString());
        }
        [TestMethod]
        public void SubstractionWithDegreeDecreaseDegree()
        {
            Polynomial p1 = new Polynomial(new double[3] { 2, 0, 3 });
            Polynomial p2 = new Polynomial(new double[3] { -1, 0, 3 });
            Assert.AreEqual(0, (p1 - p2).Degree);
        }
        [TestMethod]
        public void SubstractionWithDegreeDecrease()
        {
            Polynomial p1 = new Polynomial(new double[3] { 2, 0, 3 });
            Polynomial p2 = new Polynomial(new double[3] { -1, 0, 3 });
            Assert.AreEqual("3", (p1 - p2).ToString());
        }
        [TestMethod]
        public void MultiplicationDegree()
        {
            Polynomial p1 = new Polynomial(new double[3] { 2, 0, 3 });
            Polynomial p2 = new Polynomial(new double[4] { -3, 5, 2, 1 });
            Assert.AreEqual(5, (p1 * p2).Degree);
        }
        [TestMethod]
        public void Multiplication()
        {
            Polynomial p1 = new Polynomial(new double[3] { 2, 0, 3 });
            Polynomial p2 = new Polynomial(new double[4] { -3, 5, 2, 1 });
            Assert.AreEqual("3x^5+6x^4+17x^3-5x^2+10x-6", (p1 * p2).ToString());
        }
        [TestMethod]
        public void Equality()
        {
            Polynomial p1 = new Polynomial(new double[3] { 2, 0, 3 });
            Polynomial p2 = new Polynomial(new double[3] { 2, 0, 3 });
            Assert.AreEqual(true, p1 == p2);
        }
        [TestMethod]
        public void EqualityWithDegreeDecreace()
        {
            Polynomial p1 = new Polynomial(new double[3] { 2, 0, 3 });
            Polynomial p2 = new Polynomial(new double[4] { 2, 0, 3, 0 });
            Assert.AreEqual(true, p1 == p2);
        }
        [TestMethod]
        public void InequalityWithSameDegrees()
        {
            Polynomial p1 = new Polynomial(new double[3] { 1, 2, 4 });
            Polynomial p2 = new Polynomial(new double[3] { 2, 0, 3 });
            Assert.AreEqual(true, p1 != p2);
        }
        [TestMethod]
        public void InequalityWithDifferentDegrees()
        {
            Polynomial p1 = new Polynomial(new double[4] { 2, 0, 3, 4 });
            Polynomial p2 = new Polynomial(new double[3] { 2, 0, 3 });
            Assert.AreEqual(true, p1 != p2);
        }
        [TestMethod]
        public void MoreWithSameDegrees()
        {
            Polynomial p1 = new Polynomial(new double[3] { 2, 1, 3 });
            Polynomial p2 = new Polynomial(new double[3] { 2, 0, 3 });
            Assert.AreEqual(true, p1 > p2);
        }
        [TestMethod]
        public void MoreWithDifferentDegrees()
        {
            Polynomial p1 = new Polynomial(new double[4] { 2, 0, 3, 4 });
            Polynomial p2 = new Polynomial(new double[3] { 2, 0, 3 });
            Assert.AreEqual(true, p1 > p2);
        }
        [TestMethod]
        public void MoreOrEqualWithSameDegrees()
        {
            Polynomial p1 = new Polynomial(new double[3] { 2, 0, 3 });
            Polynomial p2 = new Polynomial(new double[3] { 2, 0, 3 });
            Assert.AreEqual(true, p1 >= p2);
        }
        [TestMethod]
        public void MoreOrEqualWithDifferentDegrees()
        {
            Polynomial p1 = new Polynomial(new double[4] { 2, 0, 3, 4 });
            Polynomial p2 = new Polynomial(new double[3] { 2, 0, 3 });
            Assert.AreEqual(true, p1 >= p2);
        }
        [TestMethod]
        public void LessWithSameDegrees()
        {
            Polynomial p1 = new Polynomial(new double[3] { 2, 0, 3 });
            Polynomial p2 = new Polynomial(new double[3] { 2, 1, 3 });
            Assert.AreEqual(true, p1 < p2);
        }
        [TestMethod]
        public void LessWithDifferentDegrees()
        {
            Polynomial p1 = new Polynomial(new double[3] { 2, 0, 3 });
            Polynomial p2 = new Polynomial(new double[4] { 2, 0, 3, 4 });
            Assert.AreEqual(true, p1 < p2);
        }
        [TestMethod]
        public void LessOrEqualWithSameDegrees()
        {
            Polynomial p1 = new Polynomial(new double[3] { 2, 0, 3 });
            Polynomial p2 = new Polynomial(new double[3] { 2, 0, 3 });
            Assert.AreEqual(true, p1 <= p2);
        }
        [TestMethod]
        public void LessOrEqualWithDifferentDegrees()
        {
            Polynomial p1 = new Polynomial(new double[3] { 2, 1, 3 });
            Polynomial p2 = new Polynomial(new double[4] { 2, 0, 3, 4 });
            Assert.AreEqual(true, p1 <= p2);
        }
        [TestMethod]
        public void IndexOperator()
        {
            Polynomial p = new Polynomial(new double[3] { 2, 1, 3 });
            Assert.AreEqual(3, p[2]);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void IndexOperatorFailLessThanZero()
        {
            Polynomial p = new Polynomial(new double[3] { 2, 1, 3 });
            Assert.Equals(typeof(ArgumentException), p[-1]);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void IndexOperatorFailMoreThanDegree()
        {
            Polynomial p = new Polynomial(new double[5] { 2, 1, 3, 0, 0 });
            Assert.Equals(typeof(ArgumentException), p[3]);
        }
    }
}