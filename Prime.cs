using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_assignment
{
    class Prime
    {
        public static bool primeornot(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            if (n == 2) return true;
            else
            {
             for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    {
                        if (n % i == 0) return false;
                    }
                }
            }
            return true;
        }
        //public static void Main(string[] args)
        //{
        //    int k = int.Parse(Console.ReadLine());
        //    if (primeornot(k))
        //        Console.WriteLine("prime");
        //    else
        //        Console.WriteLine("not prime");
        //}
    }
    
}
