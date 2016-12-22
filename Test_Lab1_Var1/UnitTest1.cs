using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1_Var1;

namespace Test_Lab1_Var1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Person_NoArguments_Constructor()
        {
            Person p = new Person();
            Assert.AreEqual("John", p.Name);
            Assert.AreEqual("Johnson", p.Last_Name);
            Assert.AreEqual(new System.DateTime(1990, 1, 1), p.Birth_Date);
        }
    }
}
