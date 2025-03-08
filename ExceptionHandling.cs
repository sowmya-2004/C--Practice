using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_assignment
{
    class ExceptionHandling
    {
        public static void Main(string[]args)
        {
            int n = int.MaxValue;
            string[] words=new string[1000];
            try
            {
                string name = "sowmya";
                name.Substring(8, 8);
                checked
                {
                    n = n + 100;
                }
                words[1000] =  "capg" ;
            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException of)
            {
                Console.WriteLine(of.Message);
            }
            catch(IndexOutOfRangeException ix)
            {
                Console.WriteLine(ix.Message);
            }

        }
    }
}
