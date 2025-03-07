using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_assignment
{
    class Calculator
    {
        public void add(int a,int b)
        {
            Console.WriteLine("addition of 2 numbers is " + (a + b));
        }
        public void add(int a,int b,int c) 
        {
            Console.WriteLine("addition of 3 numbers is " + (a + b + c));
        }
        public void add(double a,double b)
        {
            Console.WriteLine("addition of 2 double no's is " + (a + b));
        }
        //public static void Main(string[]args)
        //{
        //    Calculator c1 = new Calculator();
        //    c1.add(5, 6);
        //    c1.add(9, 8, 6);
        //    c1.add(6.8, 9.5);
        //}
    }
}
