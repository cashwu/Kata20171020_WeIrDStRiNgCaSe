using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20171020_WeIrDStRiNgCaSe
{
    [TestClass]
    public class WeIrDStRiNgCaSeTests
    {
        [TestMethod]
        public void input_a()
        {
            var kata = new Kata();
            var result = kata.ToWeirdCase("a");
            Assert.AreEqual("A", result);
        }


        [TestMethod]
        public void input_ab()
        {
            var kata = new Kata();
            var result = kata.ToWeirdCase("ab");
            Assert.AreEqual("Ab", result);
        }

        [TestMethod]
        public void input_abc()
        {
            var kata = new Kata();
            var result = kata.ToWeirdCase("abc");
            Assert.AreEqual("AbC", result);
        }
        
        [TestMethod]
        public void input_abcd()
        {
            var kata = new Kata();
            var result = kata.ToWeirdCase("abcd");
            Assert.AreEqual("AbCd", result);
        }

        [TestMethod]
        public void input_ab_cd()
        {
            var kata = new Kata();
            var result = kata.ToWeirdCase("ab cd");
            Assert.AreEqual("Ab Cd", result);
        }

        [TestMethod]
        public void input_BOY()
        {
            var kata = new Kata();
            var result = kata.ToWeirdCase("BOY");
            Assert.AreEqual("BoY", result);
        }

    }

    public class Kata
    {
        public string ToWeirdCase(string s)
        {
            return string.Join(" ", s.Split(' ').Select(b => 
                string.Concat(b.Select((a, i) => i % 2 == 0 ? char.ToUpper(a) : char.ToLower(a)))));
        }
    }
}
