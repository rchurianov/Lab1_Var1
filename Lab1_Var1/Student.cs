using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Var1
{
    public class Student
    {
        private Person passport_data;
        private Education degree;
        private int group_number;
        private Exam[] exam_list;

        public Student(Person p, Education e, int i)
        {
            passport_data = p;
            degree = e;
            group_number = i;
        }

        public Student()
        {
            passport_data = new Person();

            Random rand = new Random();
            degree = Education.Bachelor;

            group_number = rand.Next(101, 121);
        }

        /*
         * This indexator return "true" if Student.degree == education_index,
         * and "false" otherwise.
         * Both Student.degree and education_index are of type Education.
         */
        public bool this[Education education_index] 
        {
            get
            {
                return this.degree == education_index;
            }
        }

        public Person Passport_Data
        { 
            get { return passport_data; }
            set { passport_data = value;}
        }

        public Education Degree
        {
            get { return degree; }
            set { degree = value; }
        }

        public int Group_Number
        {
            get { return group_number; }
            set { group_number = value; }
        }

        public Exam[] Exam_List
        {
            get { return exam_list; }
            set { exam_list = value; }
        }

        public double AGP
        {
            get
            {
                double average = 0.0;
                if (exam_list != null)
                {
                    for (int i = 0; i < exam_list.Length; i++)
                    {
                        average = average + exam_list[i].Grade;
                    }
                    average /= exam_list.Length;
                }
                return average;
            }
        }

        public void AddExams(params Exam[] input_exam_list)
        {
            exam_list.Concat(input_exam_list);
        }

        public override string ToString()
        {
            return passport_data.ToString() + degree.ToString() + group_number.ToString() +
                   exam_list.ToString();
        }

        public virtual string ToShortString()
        {
            return passport_data.ToString() + degree.ToString() + group_number.ToString() + AGP.ToString();
        }
    }
}
