using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace c_assignment
{
    class User
    {
        public string Username;
        public string role;

        public User(string Username, string role)
        {
            this.Username = Username;
            this.role = role;
        }
        public virtual void AccessControl()
        {
            Console.WriteLine("default access control method");
        }
    }
    class Admin : User
    {
        public Admin(string Username, string role) : base(Username,"Admin")
        {
            
        }
        public override void AccessControl()
        {
            Console.WriteLine($"{Username} can access all the features");
        }
    }
    class Customer : User
    {
        public Customer(string Username, string role) : base(Username, "Customer")
        {

        }
        public override void AccessControl()
        {
            Console.WriteLine($"{Username} can access only some features");
        }
    }

    class program
    {
        public static void Main(string[]args)
        {
            Customer customer = new Customer("Srinija","customer");
            Admin admin = new Admin("sowmya","admin");
            customer.AccessControl();
            admin.AccessControl();
        }

    }
}
