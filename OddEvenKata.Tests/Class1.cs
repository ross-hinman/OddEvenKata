using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace OddEvenKata.Tests
{
    [TestFixture]
    public class Class1
    {
        [TestCase(4)]
        [TestCase(2)]
        public void Should_Return_True_When_Number_Is_Divisible_By_2(int i)
        {
            var result = Number.IsEven(i);
            Assert.AreEqual(true, result);
        }
        [TestCase(1)]
        [TestCase(3)]
        public void Should_Return_True_When_Number_Is_Odd(int i)
        {
            var result = Number.IsOdd(i);
            Assert.AreEqual(true, result);
        }
        [TestCase(7)]
        [TestCase(13)]
        public void Should_Return_True_When_Number_Is_Prime(int i)
        {
            var result = Number.IsPrime(i);
            Assert.AreEqual(true, result);
        }
    }
}
