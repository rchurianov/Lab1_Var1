using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Var1
{
    public class Person
    {
        private string name;
        private string last_name;
        private System.DateTime birth_date;

        public Person()
        {
            this.name = "John";
            this.last_name = "Johnson";
            this.birth_date = new System.DateTime(1990, 1, 1);
        }

        public Person(string input_name, string input_last_name, System.DateTime input_birth_date) {
            this.name = input_name;
            this.last_name = input_last_name;
            this.birth_date = input_birth_date;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Last_Name
        {
            get { return last_name; }
            set { last_name = value; }
        }

        public System.DateTime Birth_Date
        {
            get { return birth_date; }
            set { birth_date = value; }
        }

        public int Int_Birth_Date
        {
            get;
            set;
        }

        public override string ToString()
        {
            return this.name + this.last_name + this.birth_date.ToString();
        }

        public virtual string ToShortString()
        {
            return this.name + this.last_name;
        }
    }
}
