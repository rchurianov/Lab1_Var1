﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Var1
{
    public class Exam
    {
        public Exam(string input_Exam_Name, int input_Grade, DateTime input_Exam_Date)
        {
            this.Exam_Name = input_Exam_Name;
            this.Grade = input_Grade;
            this.Exam_Date = input_Exam_Date;
        }

        public Exam()
        {
            this.Exam_Name = "Computer Science";
            this.Grade = 5;
            this.Exam_Date = new DateTime();
        }

        public override string ToString()
        {
            return Exam_Name + Grade.ToString() + Exam_Date.ToString();
        }

        public string Exam_Name { get; set; }
        
        public int Grade { get; set; }

        public DateTime Exam_Date { get; set; }
    }
}
