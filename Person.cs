using System;

namespace c_assignment
{
    class Person
    {
        protected string name;
        protected int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual void get_details()
        {
            Console.WriteLine("Name is " + name + ", Age is " + age);
        }
    }

    class Students : Person
    {
        private string id;
        private string dept;

        
        public Students(string name, int age, string id, string dept) : base(name, age)
        {
            this.id = id;
            this.dept = dept;
        }

        public override void get_details()
        {
            Console.WriteLine("Name is " + name + ", Age is " + age + ", ID is " + id + ", Dept is " + dept);
        }
    }

    class Teacher : Person
    {
        private string id;
        private string dept;

        public Teacher(string name, int age, string id, string dept) : base(name, age)
        {
            this.id = id;
            this.dept = dept;
        }

        public override void get_details()
        {
            Console.WriteLine("Name is " + name + ", Age is " + age + ", ID is " + id + ", Dept is " + dept);
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Students s = new Students("Alice", 20, "S123", "CS");
    //        Teacher t = new Teacher("Bob", 40, "T456", "Math");

    //        s.get_details();
    //        t.get_details();

    //        Console.ReadLine();
    //    }
    //}
}
