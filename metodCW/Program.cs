using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodCW
{
    class Program
    {
        static int Factorial (int n)
        {
            if (n == 0)
            return 1;
            return n * Factorial (n-1);
        }

        static void IsItDividedOfTwo(double n)
        {

            if (n == 1)
            {
                Console.WriteLine("Yes");
                return;
            }
            else if (n<1)
            {
                Console.WriteLine("No");
                return;
            }
            IsItDividedOfTwo(n/2);

        }
        static void Main(string[] args)
        {
            //Console.WriteLine(Factorial(5));
            //IsItDividedOfTwo(4);


        }
    }
}
