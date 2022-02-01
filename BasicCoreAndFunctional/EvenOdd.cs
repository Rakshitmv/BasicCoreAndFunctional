using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreAndFunctional
{
    public  class EvenOdd
    {
        public void CheckEvenOdd()
        {
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is an Even number");
            }
            else
            {
                Console.WriteLine($"{num} is an Odd number");
            }
        }
    }
}
