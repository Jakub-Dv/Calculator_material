///-------------------------------------------------------------------------------------------------
// file:	UnitMathTests.cs
//
// summary:	Implements the unit mathematics tests class
///-------------------------------------------------------------------------------------------------

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MathLibTests
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary> (Unit Test Class) a unit mathematics tests.</summary>
    ///-------------------------------------------------------------------------------------------------

    [TestClass]
    public class UnitMathTests
    {
        /// <summary> The mathematics.</summary>
        Mathematics.Math Math = new Mathematics.Math();

        ///-------------------------------------------------------------------------------------------------
        /// <summary> SUM.</summary>
        ///-------------------------------------------------------------------------------------------------
        
        [TestMethod]
        public void positive_positive_Sum()
        {
            double positive;
            positive = 1000.00;
            Assert.AreEqual(positive * 2, Math.Sum(positive, positive));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> (Unit Test Method) positive negative sum.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void positive_negative_Sum()
        {
            double negative, positive;
            negative = -1000;
            positive = 1000;
            Assert.AreEqual(positive*0,Math.Sum(positive,negative));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> (Unit Test Method) negative positive sum.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void negative_positive_Sum()
        {
            double negative, positive;
            negative = -1000.000;
            positive = 1000;
            Assert.AreEqual(negative * 0, Math.Sum(negative, positive));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> (Unit Test Method) negative sum.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void negative_negative_Sum()
        {
            double negative;
            negative = -1000.000;
            Assert.AreEqual(negative * 2, Math.Sum(negative, negative));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> SUB.</summary>
        ///-------------------------------------------------------------------------------------------------
        
        [TestMethod]
        public void positive_positive_Sub()
        {
            double positive;
            positive = 1000;
            Assert.AreEqual(0, Math.Sub(positive, positive));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> (Unit Test Method) negative sub.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void negative_negative_Sub()
        {
            double negative;
            negative = -1000.001;
            Assert.AreEqual(negative*0, Math.Sub(negative,negative));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> (Unit Test Method) positive negative sub.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void positive_negative_Sub()
        {
            double positive,negative;
            positive = 1000;
            negative = -1000;
            Assert.AreEqual(2000, Math.Sub(positive, negative));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> (Unit Test Method) negative positive sub.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void negative_positive_Sub()
        {
            double positive,negative;
            positive = 1000.000;
            negative = -1000.000;
            Assert.AreEqual(-2000, Math.Sub(negative, positive));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> MUL.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void positive_positive_Mul()
        {
            double positive;
            positive = 1000.000;
            Assert.AreEqual(1000*1000, Math.Mul(positive, positive));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> (Unit Test Method) negative mul.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void negative_negative_Mul()
        {
            double negative;
            negative = -1000.000;
            Assert.AreEqual(1000000, Math.Mul(negative, negative));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> (Unit Test Method) negative positive mul.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void negative_positive_Mul()
        {
            double positive, negative;
            positive = 1000.000;
            negative = -1000.000;
            Assert.AreEqual(positive*negative, Math.Mul(negative, positive));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> (Unit Test Method) positive negative mul.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void positive_negative_Mul()
        {
            double positive, negative;
            positive = 1000.000;
            negative = -1000.000;
            Assert.AreEqual(-1000000, Math.Mul(positive,negative));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> DIV.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void positive_positive_Div()
        {
            double positive;
            positive = 1000.000;
            Assert.AreEqual(1, Math.Div(positive, positive));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> (Unit Test Method) negative div.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void negative_negative_Div()
        {
            double negative;
            negative = -1000.000;
            Assert.AreEqual(1, Math.Div(negative, negative));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> (Unit Test Method) negative positive div.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void negative_positive_Div()
        {
            double positive, negative;
            positive = 1000.000;
            negative = -1000.000;
            Assert.AreEqual(positive / negative, Math.Div(negative, positive));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> (Unit Test Method) positive negative div.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void positive_negative_Div()
        {
            double positive, negative;
            positive = 1000.000;
            negative = -1000.000;
            Assert.AreEqual(-1, Math.Div(positive, negative));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> (Unit Test Method) div by zero positive.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void divByZero_Positive()
        {
            double number = 10;
            Assert.AreEqual(Double.PositiveInfinity, Math.Div(number, 0));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> (Unit Test Method) div by zero negative.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void divByZero_Negative()
        {
            double number = -10;
            Assert.AreEqual(Double.NegativeInfinity, Math.Div(number, 0));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> (Unit Test Method) div by zero NaN.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void divByZero_NaN()
        {
            double number = 0;
            Assert.AreEqual(Double.NaN, Math.Div(number, 0));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> MOD.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void positive_positive_Mod()
        {
            double positive;
            positive = 1000.000;
            Assert.AreEqual(0, Math.Mod(positive, positive));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> (Unit Test Method) negative modifier.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void negative_negative_Mod()
        {
            double negative;
            negative = -1000.000;
            Assert.AreEqual(0, Math.Mod(negative, negative));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> (Unit Test Method) negative positive modifier.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void negative_positive_Mod()
        {
            double positive, negative;
            positive = 1000.000;
            negative = -1000.000;
            Assert.AreEqual(positive % negative, Math.Mod(negative, positive));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> (Unit Test Method) positive negative modifier.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void positive_negative_Mod()
        {
            double positive, negative;
            positive = 1000.000;
            negative = -1000.000;
            Assert.AreEqual(0, Math.Mod(positive, negative));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> (Unit Test Method) div by zero.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void divByZero()
        {
            double number = 10;
            Assert.AreEqual(Double.NaN, Math.Mod(number, 0));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> FAC.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void decPoint_Fac()
        {
            double number = 10.5;
            Assert.AreEqual(Double.NaN, Math.Fac(number));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> (Unit Test Method) negative fac.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void Negative_Fac()
        {
            double number = -10;
            Assert.AreEqual(Double.NaN, Math.Fac(number));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> (Unit Test Method) zero fac.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void Zero_Fac()
        {
            double number = 0;
            Assert.AreEqual(1, Math.Fac(number));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> (Unit Test Method) positive fac.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void Positive_Fac()
        {
            double number = 7;
            Assert.AreEqual(7*6*5*4*3*2*1, Math.Fac(number));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> (Unit Test Method) overflow fac.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void Overflow_Fac()
        {
            double number = 1000;
            Assert.AreEqual(Double.PositiveInfinity, Math.Fac(number));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> FLOOR.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void decPoint_Floor()
        {
            double number = 10.05;
            Assert.AreEqual(10.00, Math.Floor(number));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> (Unit Test Method) decrement point 2 floor.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void decPoint2_Floor()
        {
            double number = 10.1489655;
            Assert.AreEqual(10.00, Math.Floor(number));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> POW.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void positive_positive_Pow()
        {
            double positive;
            positive = 3.00;
            Assert.AreEqual(positive * positive * positive, Math.Pow(positive, positive));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> (Unit Test Method) positive negative pow.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void positive_negative_Pow()
        {
            double negative, positive;
            negative = -5;
            positive = 5;
            Assert.AreEqual(0.00032, Math.Pow(positive, negative));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> (Unit Test Method) negative positive pow.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void negative_positive_Pow()
        {
            double negative, positive;
            negative = -5;
            positive = 5;
            Assert.AreEqual(-3125, Math.Pow(negative, positive));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> (Unit Test Method) negative pow.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void negative_negative_Pow()
        {
            double negative;
            negative = -4;
            Assert.AreEqual(0.003906, Math.Pow(negative, negative),0.000001);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> (Unit Test Method) executes the zero pow action.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void OnZero_Pow()
        {
            double number = 256826;
            Assert.AreEqual(1, Math.Pow(number, 0));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> (Unit Test Method) zero pow.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void Zero_Pow()
        {
            double number = 0;
            Assert.AreEqual(0, Math.Pow(number, 55));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> SQRT.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void Positive_Sqrt()
        {
            double number;
            number = 100;
            Assert.AreEqual(10, Math.Sqrt(number, 2));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Negative sqrt.</summary>
        ///-------------------------------------------------------------------------------------------------

        public void Negative_Sqrt()
        {
            double number;
            number = -100;
            Assert.AreEqual(Double.NaN, Math.Sqrt(number, 2));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Zero sqrt.</summary>
        ///-------------------------------------------------------------------------------------------------

        public void Zero_Sqrt()
        {
            double number;
            number = 0;
            Assert.AreEqual(0, Math.Sqrt(number, 2));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Executes the zero sqrt action.</summary>
        ///-------------------------------------------------------------------------------------------------

        public void OnZero_Sqrt()
        {
            double number;
            number = 100;
            Assert.AreEqual(10, Math.Sqrt(number, 0));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Executes the negative sqrt action.</summary>
        ///-------------------------------------------------------------------------------------------------

        public void OnNegative_Sqrt()
        {
            double number;
            number = 10;
            Assert.AreEqual(100,Math.Sqrt(number,-2));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Executes the positive sqrt action.</summary>
        ///-------------------------------------------------------------------------------------------------

        public void OnPositive_Sqrt()
        {
            double number;
            number = 1000;
            Assert.AreEqual(10,Math.Sqrt(number,3));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> X_count.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void positive_xcount()
        {
            double[] arr = { 1, 2, 3, 4, 5.00 };
            Assert.AreEqual(3, Math.X_count(arr));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> (Unit Test Method) negative xcount.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void negative_xcount()
        {
            double[] arr = { -1.00, -2, -3, -4.00, -5 };
            Assert.AreEqual(-3, Math.X_count(arr),0.01);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> (Unit Test Method) mix xcount.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void mix_xcount()
        {
            double[] arr = { 1, -2.5, 3, 4.4, -5 };
            Assert.AreEqual(0.18, Math.X_count(arr),0.01);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> S_count.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void positive_scount()
        {
            double[] arr = { 1.00, 2, 3, 4, 5 };
            double x = 2;
            Assert.AreEqual(Double.NaN, Math.S_count(x, arr));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> (Unit Test Method) negative scount.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void negative_scount()
        {
            double[] arr = { -1.00, -2.00, -3.00, -4, -5 };
            double x = 2;
            Assert.AreEqual(Double.NaN, Math.S_count(x, arr));
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> (Unit Test Method) mix scount.</summary>
        ///-------------------------------------------------------------------------------------------------

        [TestMethod]
        public void mix_scount()
        {
            double[] arr = { 1, 2, 3, -4, 5 };
            double x = -1;
            Assert.AreEqual(2.738612, Math.S_count(x, arr),0.000001);
        }

    }
}
