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
    }

    public class Kata
    {
        public string ToWeirdCase(string s)
        {
            return "A";
        }
    }
}
