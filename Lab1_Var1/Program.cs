using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Var1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 5. Create a new object of type Student.
            // Output this object to the console using ToString().
            Console.WriteLine("---------- task 5 ----------");
            Console.WriteLine("----------  start ----------");
            Student good_student = new Student();
            Console.WriteLine();
            Console.WriteLine(good_student.ToShortString());
            Console.WriteLine("----------  end ------------\n");

            // 6. Using interator in the Student object, check
            // if the student has a cetrain education degree.
            Console.WriteLine("----------  task 6 ---------");
            Console.WriteLine("----------  start ----------");
            Console.WriteLine(good_student[Education.Bachelor].ToString());
            Console.WriteLine(good_student[Education.SecondEducation].ToString());
            Console.WriteLine(good_student[Education.Specialist].ToString());
            Console.WriteLine("----------  end ------------\n");

            // 7. Set all fields of the student object.
            // Output result to the console.
            Console.WriteLine("----------  task 7 -----------");
            Console.WriteLine("----------  start ------------");
            good_student.Passport_Data = new Person("Ray", "Bradbury", new DateTime(1910, 3, 3));
            good_student.Degree = Education.SecondEducation;
            good_student.Group_Number = 120;
            Exam[] two_exams = {new Exam(), new Exam()};
            good_student.Exam_List = two_exams;
            Console.WriteLine();
            Console.WriteLine(good_student.ToString());
            Console.WriteLine("----------  end ------------\n");

            // 8. Using AddExams() method add some Exam objects to the student object property.
            Console.WriteLine("----------  task 8 ------------");
            Console.WriteLine("----------  start -------------");
            good_student.AddExams(two_exams);
            Console.WriteLine();
            Console.WriteLine(good_student.ToString());
            Console.WriteLine("----------  end ------------\n");

            // 9.
            Console.ReadKey();

        }
    }
}
