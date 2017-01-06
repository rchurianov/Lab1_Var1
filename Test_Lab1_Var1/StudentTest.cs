using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1_Var1;

namespace Test_Lab1_Var1
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void NoArguments_Constructor_Test()
        {
            Student s = new Student();
            Assert.AreEqual((new Person()).ToString(), s.Passport_Data.ToString());
            Assert.AreEqual(s.Degree, Education.Bachelor);
            Assert.IsInstanceOfType(s.Group_Number, typeof(int));
            Assert.IsNotNull(s.Group_Number);
            Assert.IsTrue(s.Group_Number >= 101 & s.Group_Number <= 121);
        }

        [TestMethod]
        public void Constructor_Test()
        {
            Person p = new Person("Mark", "Gustafson", new DateTime(1990, 2, 2));
            Education e = Education.Specialist;
            int g_n = 118;
            Student s = new Student(p, e, g_n);
            Assert.AreEqual(p, s.Passport_Data);
            Assert.AreEqual(e, s.Degree);
            Assert.AreEqual(g_n, s.Group_Number);
        }

        [TestMethod]
        public void Indexator_Test()
        {
            Student s = new Student();
            Assert.AreEqual(true, s[Education.Bachelor]);
        }

        [TestMethod]
        public void AddExams_Test()
        {
            Student s = new Student();
            // At this moment Student.exam_list == null
            Assert.IsNull(s.Exam_List);
            // Create an Exams array
            Exam[] e_l = {new Exam(), new Exam(), new Exam()};
            // Add some exams to Student object
            s.AddExams(e_l);
            // Test Student.AddExams() works when exam_list == null
            Assert.IsNotNull(s.Exam_List);
            for (int i = 0; i < s.Exam_List.Length; ++i)
            {
                Assert.AreEqual(s.Exam_List[i].ToString(), e_l[i].ToString());
            }
            /* At this moment exam_list != null.
             * To test Student.AddExams() works when exam_list != null
             * 
             */
            s.AddExams(e_l);
            Exam[] e_l_2 = { new Exam(), new Exam(), new Exam(), new Exam(), new Exam(), new Exam() };
            for (int i = 0; i < s.Exam_List.Length; ++i)
            {
                Assert.AreEqual(s.Exam_List[i].ToString(), e_l_2[i].ToString());
            }
        }

        [TestMethod]
        public void AGP_Test()
        {
            Student s = new Student();
            Exam[] e_l = { new Exam(), new Exam(), new Exam() };
            s.AddExams(e_l);
            Assert.AreEqual(s.AGP, 5.0);
        }

        // Student.ToString() returns a string, containing
        // all private fields of Student object, including the list of exams
        [TestMethod]
        public void ToString_Test()
        {
            Student s = new Student();
            // At this moment Student.exam_list == null,
            // so we expect Student.ToString() to return a string
            // without Exam_List.ToString()
            Assert.AreEqual(s.Passport_Data.ToString() + s.Degree.ToString() +
                            s.Group_Number.ToString(),
                            s.ToString());
            // Now we add Exam objects to Student.Exam_List ...
            Exam[] e_l = { new Exam(), new Exam(), new Exam() };
            s.AddExams(e_l);
            // And test Student.ToString() with Student.Exam_List != null.
            // We expect Student.ToString() to return a string with list of exams
            // on the end.
            Assert.AreEqual(s.Passport_Data.ToString() + s.Degree.ToString() +
                            s.Group_Number.ToString() + e_l.ToString(),
                            s.ToString());
        }

        // Student.ToShortString() returns a string, containing
        // all private fields of Student object,
        // excluding the list of exams. But including Student.AGP.
        [TestMethod]
        public void ToShortString_Test()
        {
            Student s = new Student();
            /* Student.AGP checks if exam_list == null, and returns 0.0
             * if exam_list is void of Exams.
             * At this moment exam_list == null, so we expect
             * Student.ToShortString() to return a string with "0" on
             * the end.
             */
            Assert.AreEqual(s.Passport_Data.ToString() + s.Degree.ToString() +
                            s.Group_Number.ToString() + "0",
                            s.ToShortString());
            // Now we add Exam objects to Student.Exam_List ...
            Exam[] e_l = { new Exam(), new Exam(), new Exam() };
            s.AddExams(e_l);
            // ... and test Student.ToShortString() with Student.Exam_List != null.
            // We expect Student.ToShortString() to return a string with "5.0"
            // on the end.
            Assert.AreEqual(s.Passport_Data.ToString() + s.Degree.ToString() +
                            s.Group_Number.ToString() + "5",
                            s.ToShortString());
        }

        [TestMethod]
        public void Set_Properties_Test()
        {
            Student s = new Student();
            Person p = new Person("Jenifer", "Capriatti", new DateTime(1970, 1, 1));
            s.Passport_Data = p;
            s.Degree = Education.Specialist;
            s.Group_Number = 115;
            Exam[] e_l = { new Exam(), new Exam(), new Exam() };
            s.Exam_List = e_l;
            Assert.AreEqual(p, s.Passport_Data);
            Assert.AreEqual(Education.Specialist, s.Degree);
            Assert.AreEqual(115, s.Group_Number);
            Assert.AreEqual(e_l.ToString(), s.Exam_List.ToString());
        }
    }
}
