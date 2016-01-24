using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimePalindrome;

namespace PrimePalindromeTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsPalindromeTestMethod()
        {
            Assert.AreEqual(Program.IsPalindrome("1234321"), true);
            Assert.AreEqual(Program.IsPalindrome("Bobby"), false);
        }

        [TestMethod]
        public void ReverseTestMethod()
        {
            Assert.AreEqual(Program.Reverse("Bobby"), "ybboB");
        }
    }
}
