using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecursiveTry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveTry.Tests
{
    [TestClass()]
    public class myjinxin
    {
        [TestMethod()]
        public void PrimeStringTest()
        {
            // empty string should be prime
            Assert.AreEqual(true, Kata.PrimeString(""));

            // string length below 2 should be prime
            Assert.AreEqual(true, Kata.PrimeString("a"));
            Assert.AreEqual(true, Kata.PrimeString("z"));

            // length 2 and char the same, Not prime
            Assert.AreEqual(false, Kata.PrimeString("aa"));

            // length 2 and char different, Prime
            Assert.AreEqual(true, Kata.PrimeString("ac"));

            // some case should be prime
            Assert.AreEqual(true, Kata.PrimeString("abac"));
            Assert.AreEqual(true, Kata.PrimeString("abc"));


            // some case should NOT be prime
            Assert.AreEqual(false, Kata.PrimeString("abab"));
            Assert.AreEqual(false, Kata.PrimeString("abcabc"));

            // cases on codewars
            Assert.AreEqual(true, Kata.PrimeString("abac"));
            Assert.AreEqual(false, Kata.PrimeString("abab"));
            Assert.AreEqual(false, Kata.PrimeString("aaaa"));
            Assert.AreEqual(true, Kata.PrimeString("x"));
            Assert.AreEqual(true, Kata.PrimeString("abc"));
            Assert.AreEqual(false, Kata.PrimeString("fdsyffdsyffdsyffdsyffdsyf"));
            Assert.AreEqual(true, Kata.PrimeString("utdutdtdutd"));
            Assert.AreEqual(true, Kata.PrimeString("abba"));
        }
    }
}