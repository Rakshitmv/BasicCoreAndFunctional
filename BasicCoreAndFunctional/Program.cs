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
                Console.WriteLine("Enter 1: To Flip a Coin\n" + "Enter 2: To Check For leap Year\n" + "Enter 3: To power of 2\n" + "Enter 4: To generate harmonic series\n" + "Enter 5: To get Factors\n" + "Enter 6: To get Quotient and Remainder\n" + "Enter 7: To exit\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FlipCoin flipCoin = new FlipCoin();
                        flipCoin.Toss();
                        break;
                    case 2:
                        LeapYear leapYear = new LeapYear();
                        leapYear.Leap();
                        break;
                    case 3:
                        PowerOf2 powerOf2 = new PowerOf2();
                        powerOf2.Power2();
                        break;
                    case 4:
                        HarmonicNumber harmonicNumber = new HarmonicNumber();
                        harmonicNumber.Harmonic();
                        break;
                    case 5:
                        Factors factors = new Factors();
                        factors.Factor();
                        break;
                    case 6:
                        QuotientRemainder quotientRemainder = new QuotientRemainder();
                        quotientRemainder.ComputeQuotientRemainder();
                        break;
                    case 7:
                        flag = false;
                        break;

                }
            }
        }
    }
}
