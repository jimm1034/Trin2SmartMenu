using System;
using FunctionLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartMenuLibrary;

namespace TestVersion1.cs
{
    [TestClass]
    public class TestVersion1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Result from DoThis", Functions.DoThis());
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("Result from DoThat", Functions.DoThat());
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("Result from doing: Something", Functions.DoSomething("Something"));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(42, Functions.GetTheAnswerToLifeTheUniverseAndEverything());
        }
    }
}
