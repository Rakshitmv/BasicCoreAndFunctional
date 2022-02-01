using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreAndFunctional
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter 1 to Flip a Coin\n" + "Enter 2 to exit\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FlipCoin flipCoin = new FlipCoin();
                        flipCoin.Toss();
                        break;
                    case 2:
                        flag = false;
                        break;

                }
            }
        }
    }
}
