using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_assignment
{
    abstract class Area
    {
        abstract public void calculate_area();
    }
    class Rectangle : Area
    {   

       private int Length;
       private int breadth;

       public Rectangle(int Length,int breadth)
        {
            this.Length = Length;
            this.breadth = breadth;
        }
       public override void calculate_area()
        {
            Console.WriteLine("Area of rectangle is  "+ (Length * breadth));
        }
    }
    class Circle : Area
    {
        private int radius;
        public Circle(int radius)
        {
            this.radius = radius;
        }
        public override void calculate_area()
        {
            Console.WriteLine("Area of Circle is   " + (3.14 * radius * radius));
        }
    }
    //class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Circle c1 = new Circle(5);
    //        c1.calculate_area();

    //        Rectangle r1 = new Rectangle(6, 7);
    //        r1.calculate_area();
    //    }
    //}
}
