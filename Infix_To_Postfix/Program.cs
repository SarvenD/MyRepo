using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infix_To_Postfix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the Infix String");
            string infix = Console.ReadLine();
            string postfix;
            InfixToPostfix infixToPostfix = new InfixToPostfix();
            infixToPostfix.Converter(ref infix, out postfix);
            Console.WriteLine(postfix);
            Console.ReadLine();
        }
    }
}
