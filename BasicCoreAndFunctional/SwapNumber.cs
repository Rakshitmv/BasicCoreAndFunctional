using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreAndFunctional
{
    public class SwapNumber
    {
        public void Swap()
        {
            Console.WriteLine("Enter the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Numbers after swapping: ");

            firstNumber += secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber -= secondNumber;

            Console.WriteLine("First no = " + firstNumber + "\nSecond no = " + secondNumber);
        }
    }
}
