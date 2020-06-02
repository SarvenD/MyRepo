using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Money in Indian Rupee");
            decimal INR = Decimal.Parse(Console.ReadLine());

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            decimal Euro = 0.012M * INR;

            decimal Frank = 0.013M * INR;

            decimal dollar = 0.013M * INR;

            Console.WriteLine($"{ INR.ToString("C", new CultureInfo("hi-IN"))} = {Euro.ToString("C", new CultureInfo("en-US"))}");

            Console.WriteLine($"{ INR.ToString("C", new CultureInfo("hi-IN"))} = {Frank.ToString("C", new CultureInfo("fr-FR"))}");

            Console.WriteLine($"{ INR.ToString("C", new CultureInfo("hi-IN"))} = {dollar.ToString("C", new CultureInfo("en-GB"))}");

            Console.ReadLine();
        }
    }
}
