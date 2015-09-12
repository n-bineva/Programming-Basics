using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzprobvaneNaPrimeriOtNeta
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter two numbers: (on separate lines)");
            Console.Write("First number is:");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Second number is:");
            int second = int.Parse(Console.ReadLine());
            {
                if (first == second)
                {
                    Console.WriteLine("The numbers are equals");
                }
                else
                {
                    if (first > second)
                    {
                        Console.WriteLine("{0} is bigger than {1}", first, second);
                    }
                    else
                    {
                        Console.WriteLine("{1} is bigger than {0}", first, second);
                    }
                }
            }
        }
    }
}

