using System;
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
    }

    public class Kata
    {
        public string ToWeirdCase(string s)
        {
            if (s.Length == 1)
            {
                return s.ToUpper();
            }

            return $"{char.ToUpper(s[0])}{s[1]}";
        }
    }
}
