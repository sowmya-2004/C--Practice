using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace c_assignment
{
    class Student
    {
        private string name;
        private int rollno;

        public string Name
        {
            get { return name; }

            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("name cannot be empty");
                }
                else
                {
                    name = value;
                }
            }
        }
        public int RollNO
        {
            get { return rollno; }
            set
            {
                if(value<0)
                {
                    Console.WriteLine("rollno cannot be negative");
                }
                else
                {
                    rollno = value;
                }
            }
        }
        public static void main(string[]args)
        {
            Student st = new Student();
            st.RollNO = 40;
            st.Name = "sowmya";
            Console.WriteLine("roll no is" + st.rollno);
            Console.WriteLine("name is " + st.name);

        }
    }
}
