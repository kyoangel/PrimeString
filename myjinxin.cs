namespace myjinxin
{
    using NUnit.Framework;
    using System;
    
    [TestFixture]
    public class myjinxin
    {
        
        [Test]
        public void BasicTests(){
            var kata=new Kata();
            
            Assert.AreEqual(true,kata.PrimeString("abac"));
            
            Assert.AreEqual(false,kata.PrimeString("abab"));
            
            Assert.AreEqual(false,kata.PrimeString("aaaa"));
            
            Assert.AreEqual(true,kata.PrimeString("x"));
            
            Assert.AreEqual(true,kata.PrimeString("abc"));
            
            Assert.AreEqual(false,kata.PrimeString("fdsyffdsyffdsyffdsyffdsyf"));
            
            Assert.AreEqual(true,kata.PrimeString("utdutdtdutd"));
            
            Assert.AreEqual(true,kata.PrimeString("abba"));
            
            Assert.AreEqual(false,kata.PrimeString("aa"));
            
            Assert.AreEqual(true,kata.PrimeString(""));
            
          }
                 
    }
}
