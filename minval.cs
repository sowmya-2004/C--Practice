using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_assignment
{

    class hello
    {
        public static void Main(string[] args)
        {
            string s = null;
            try
            {
                Console.WriteLine(s[0]);
            }
            catch(Exception ex)
            {
                throw new NullReferenceException("null pointer");
            }
            finally
            {
                Console.WriteLine("program is completed");
            }
        }
    }
}
