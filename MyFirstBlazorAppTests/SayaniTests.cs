using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace MyFirstBlazorApp.Pages.Tests
{
    [TestClass()]
    public class SayaniTests
    {
        [TestMethod()]
        public void YrsInARangeTest()
        {
            var sayani = new Sayani();
            var years = new List<int>() { 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020 };
            var yearsNegative = new List<int>() { -2012 };
            var result = sayani.YrsInARange(years);

            Assert.AreEqual(2, result);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => sayani.YrsInARange(yearsNegative));
        }

        [TestMethod()]
        public void GetSumOfDigitsSquaredTest()
        {
            var sayani = new Sayani();
            var result = sayani.GetSumOfDigitsSquared(2);
            var result2 = sayani.GetSumOfDigitsSquared(5);
            var result3 = sayani.GetSumOfDigitsSquared(13);
            var result4 = sayani.GetSumOfDigitsSquared(15);
            var result5 = sayani.GetSumOfDigitsSquared(156);
            var result6 = sayani.GetSumOfDigitsSquared(14567);

            Assert.AreEqual(4, result);
            Assert.AreEqual(25, result2);
            Assert.AreEqual(10, result3);
            Assert.AreEqual(26, result4);
            Assert.AreEqual(62, result5);
            Assert.AreEqual(127, result6);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => sayani.GetSumOfDigitsSquared(-6));

        }

        [TestMethod()]
        public void ProductTest()  
        {
            var sayani = new Sayani();
            var result1 = sayani.Product(15,4);
            var result2 = sayani.Product(9, 4);
            var result3 = sayani.Product(150, 4);

            Assert.AreEqual(60, result1);
            Assert.AreEqual(36, result2);
            Assert.AreEqual(600, result3);

        }

        [TestMethod()]
        public void IsPalindromeTest()
        {
            var sayani = new Sayani();
            var result1 = sayani.IsPalindrome("hello");
            var result2 = sayani.IsPalindrome("racecar");
            var result3 = sayani.IsPalindrome("ava");
            var result4 = sayani.IsPalindrome("bye");
            var result5 = sayani.IsPalindrome("Racecar");

            Assert.IsFalse(result1);
            Assert.IsTrue(result2);
            Assert.IsTrue(result3);
            Assert.IsFalse(result4);
            Assert.IsTrue(result5);

        }

        [TestMethod()]
        public void IsHappyNumber()
        {
            var sayani = new Sayani();
            var result1 = sayani.IsHappyNumber(7);
            var result2 = sayani.IsHappyNumber(56);
            var result3 = sayani.IsHappyNumber(109);
            var result4 = sayani.IsHappyNumber(5);
            var result5 = sayani.IsHappyNumber(13);

            // 7, 13, 19, 23, 31, 79, 97, 103, 109, 139

            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
            Assert.IsTrue(result3);
            Assert.IsFalse(result4);
            Assert.IsTrue(result5);

        }

    }
}