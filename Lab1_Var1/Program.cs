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
            // 1. Create a new object of type Student.
            // Output this object to the console using ToString().
            Console.WriteLine("---------- task 1 ----------");
            Console.WriteLine("----------  start ----------");
            Student good_student = new Student();
            Console.WriteLine();
            Console.WriteLine(good_student.ToShortString());
            Console.WriteLine("----------  end ------------\n");

            // 2. Using interator in the Student object, check
            // if the student has a cetrain education degree.
            Console.WriteLine("----------  task 2 ---------");
            Console.WriteLine("----------  start ----------");
            Console.WriteLine(good_student[Education.Bachelor].ToString());
            Console.WriteLine(good_student[Education.SecondEducation].ToString());
            Console.WriteLine(good_student[Education.Specialist].ToString());
            Console.WriteLine("----------  end ------------\n");

            // 3. Set all fields of the student object.
            // Output result to the console.
            Console.WriteLine("----------  task 3 -----------");
            Console.WriteLine("----------  start ------------");
            good_student.Passport_Data = new Person("Ray", "Bradbury", new DateTime(1910, 3, 3));
            good_student.Degree = Education.SecondEducation;
            good_student.Group_Number = 120;
            Exam[] two_exams = {new Exam(), new Exam()};
            good_student.Exam_List = two_exams;
            Console.WriteLine();
            Console.WriteLine(good_student.ToString());
            Console.WriteLine("----------  end ------------\n");

            // 4. Using AddExams() method add some Exam objects to the student object property.
            Console.WriteLine("----------  task 4 ------------");
            Console.WriteLine("----------  start -------------");
            good_student.AddExams(two_exams);
            Console.WriteLine();
            Console.WriteLine(good_student.ToString());
            Console.WriteLine("----------  end ------------\n");

            // 5.
            Console.WriteLine("--------- task 5 ------------");
            Console.WriteLine("----------  start -------------");
            Console.WriteLine("Enter array dimensions as two integer values" + 
                              " divided by a delimiter. The number of rows comes first," +
                              " second comes the number of columns.\n" +
                              "Three delimiters allowed: ',' 'x' ' ' (space).");
            char[] delimiters = { ',', 'x', ' ' };
            string input_string = Console.ReadLine();
            string[] splitted_string = input_string.Split(delimiters, 2);
            int nrow = 0;
            int ncolumn = 0;
            int.TryParse(splitted_string[0], out nrow);
            int.TryParse(splitted_string[1], out ncolumn);
            // Arrays declarations
            Exam[] one_dim_array = new Exam[nrow*ncolumn];
            Exam[,] two_dim_array = new Exam[nrow, ncolumn];
            Exam[][] jagged_array = new Exam[nrow][];
            // Arrays initialization
            for (int i = 0; i < one_dim_array.Length; ++i )
            {
                one_dim_array[i] = new Exam();
            }
            for (int i = 0; i < nrow; i++)
            {
                for (int j = 0; j < ncolumn; j++ )
                {
                    two_dim_array[i, j] = new Exam();
                }
            }

            for (int i = 0; i < nrow; i++)
            {
                jagged_array[i] = new Exam[ncolumn];
            }
            for (int i = 0; i < nrow; i++)
            {
                for (int j = 0; j < ncolumn; j++)
                {
                    jagged_array[i][j] = new Exam();
                }
            }
            // Compare execution time of "assign" operation
            // for each array type
            int one_dim_start_time = Environment.TickCount;
            for (int i = 0; i < one_dim_array.Length; i++ )
            {
                one_dim_array[i].Exam_Name = "Numerical Methods";
            }
            int one_dim_difference = Environment.TickCount - one_dim_start_time;
            int two_dim_start_time = Environment.TickCount;
            for (int i = 0; i < nrow; i++ )
            {
                for(int j = 0; j < ncolumn; j++)
                {
                    two_dim_array[i, j].Exam_Name = "Numerical Methods";
                }
            }
            int two_dim_difference = Environment.TickCount - two_dim_start_time;
            int jagged_start_time = Environment.TickCount;
            for (int i = 0; i < nrow; i++ )
            {
                for (int j = 0; j < ncolumn; j++)
                {
                    jagged_array[i][j].Exam_Name = "Numerical Methods";
                }
            }
            int jagged_difference = Environment.TickCount - jagged_start_time;
            Console.WriteLine("Running time for one dimensional array is {0}", one_dim_difference);
            Console.WriteLine("Running time for two dimensional array is {0}", two_dim_difference);
            Console.WriteLine("Running time for jagged array is {0}", jagged_difference);
            Console.WriteLine("----------  end -------------");
            Console.ReadKey();
        }
    }
}
