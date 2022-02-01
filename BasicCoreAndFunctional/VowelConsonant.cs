using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreAndFunctional
{
    public class VowelConsonant
    {
        public void CheckVowelConsonant()
        {
            Console.WriteLine("Enter any character/alphabet: ");
            char alphabet = Convert.ToChar(Console.ReadLine());

            if (alphabet == 'a' || alphabet == 'A' || alphabet == 'e' || alphabet == 'E' || alphabet == 'i' || alphabet == 'I' || alphabet == 'o' || alphabet == 'O' || alphabet == 'u' || alphabet == 'U')
            {
                Console.WriteLine($"The entered alphabet {alphabet} is a Vowel");
            }
            else
            {
                Console.WriteLine($"The entered alphabet {alphabet} is a Consonant");
            }
        }
    }
}

      
    
