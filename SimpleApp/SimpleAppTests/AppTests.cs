using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApp.Tests
{
    [TestClass()]
    public class AppTests
    {
        [TestMethod]
        public void AppArgumentsValidTest()
        {
            App app = new App();

            int actual = app.Run(null);
            int expected = 1;

            Assert.AreEqual(expected, actual, "Run did not fail with null arguments");

        }

        [TestMethod]
        public void ReverseStringTest()
        {
            App app = new App();
            string s = "Hello";
            string expected = "olleH";
            string actual = app.Reverse(s);

            int test = String.Compare(expected, actual);

            Assert.AreEqual(0, test, "Reverse did not reverse the string.  Expected {0}. Actual {1}", expected, actual);

        }
    }
}