using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("Square Pattern");
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
    }
}
