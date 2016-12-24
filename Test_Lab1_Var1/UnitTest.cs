using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1_Var1;

namespace Test_Lab1_Var1
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void Test_Person_NoArguments_Constructor()
        {
            Person p = new Person();
            Assert.AreEqual("John", p.Name);
            Assert.AreEqual("Johnson", p.Last_Name);
            Assert.AreEqual(new System.DateTime(1990, 2, 2), p.Birth_Date);
        }

        [TestMethod]
        public void Test_Int_Birth_Date()
        {
            Person p = new Person();
            Assert.AreEqual(19900202, p.Int_Birth_Date);
            int test_date = 19900101;
            p.Int_Birth_Date = 19900101;
            Assert.AreEqual(test_date, p.Int_Birth_Date);
            Assert.AreEqual(new System.DateTime(1990, 1, 1), p.Birth_Date);
        }
        [TestMethod]
        public void Test_Person_Constructor()
        {
            Person p = new Person("Roma", "Vorontsov", new System.DateTime(1992, 11, 11));
            Assert.AreEqual("Roma", p.Name);
            Assert.AreEqual("Vorontsov", p.Last_Name);
            Assert.AreEqual(new System.DateTime(1992, 11, 11), p.Birth_Date);
        }
        [TestMethod]
        public void Test_ToString_Methods()
        {
            Person p = new Person("Roma", "Vorontsov", new System.DateTime(1992, 11, 11));
            Assert.AreEqual("RomaVorontsov11-Nov-92 00:00:00", p.ToString());
            Assert.AreEqual("RomaVorontsov", p.ToShortString());
        }
    }
}
