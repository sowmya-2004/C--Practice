using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_assignment
{
    class Vehicle
    {
        public virtual void Start()
        {
            Console.WriteLine("vehicle class method");
        }
    }

    class Bike:Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Bike class start method");
        }
    }

    class Car : Vehicle
    {
        public override void Start() 
        {
            //base.start();
            Console.WriteLine("Car class start method");
        }
    }

    //class program
    //{
    //    public static void Main(string[]args)
    //    {
    //        Car car = new Car();
    //        car.Start();

    //        Bike bike = new Bike();
    //        bike.Start();

    //        Vehicle v = new Vehicle();
    //        v.Start();
    //    }
    //}
}
