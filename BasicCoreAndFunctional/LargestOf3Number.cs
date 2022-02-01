using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreAndFunctional
{
    public class LargestOf3Number
    {
        public void LargestNumber()
        {
            Console.WriteLine("Enter the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Third number: ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                if (firstNumber > thirdNumber)
                {
                    Console.Write("The 1st Number is the greatest among three. \n\n");
                }
                else
                {
                    Console.Write("The 3rd Number is the greatest among three. \n\n");
                }
            }
            else if (secondNumber > thirdNumber)
                Console.Write("The 2nd Number is the greatest among three \n\n");
            else
                Console.Write("The 3rd Number is the greatest among three \n\n");
        }
    }          
}
