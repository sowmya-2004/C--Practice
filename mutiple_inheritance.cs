using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_assignment
{
    interface Iprintable
    {
        abstract public string print_details();
    }
    interface ISerializable
    {
        abstract public void serialize();
    }

    class Report:Iprintable,ISerializable
    {
        string name ="sowmya";
        int age = 20;
        public string print_details()
        {
            return "name is " + name + " age is " + age;
        }
        public void serialize()
        {
            Console.WriteLine("serialized");
        }
    }

    //class program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Report report = new Report();
    //       Console.WriteLine(report.print_details());
    //        report.serialize();
    //    }
    //}
}
