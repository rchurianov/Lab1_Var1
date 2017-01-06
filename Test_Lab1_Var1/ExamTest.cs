using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1_Var1;

namespace Test_Lab1_Var1
{
    [TestClass]
    public class ExamTest
    {
        [TestMethod]
        public void No_Arguments_Constructor_Test()
        {
            Exam e = new Exam();
            Assert.AreEqual(e.Exam_Name, "Computer Science");
            Assert.AreEqual(e.Grade, 5);
            Assert.AreEqual(e.Exam_Date, new DateTime(1998, 1, 20));
        }

        [TestMethod]
        public void Constructor_Test()
        {
            Exam e = new Exam("Mathematical Statistics", 5, new DateTime(1999, 1, 11));
            Assert.AreEqual(e.Exam_Name, "Mathematical Statistics");
            Assert.AreEqual(e.Grade, 5);
            Assert.AreEqual(e.Exam_Date, new DateTime(1999, 1, 11));
        }

        [TestMethod]
        public void ToString_Test()
        {
            Exam e = new Exam("Mathematical Statistics", 5, new DateTime(1999, 1, 11));
            Assert.AreEqual("Mathematical Statistics511-Jan-99 00:00:00", e.ToString());
        }
    }
}
