using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            Console.Write("{0:D4} ", a);
            Console.Write("{0:D4} ", b);
            Console.Write("{0:D4} ", c);
            Console.WriteLine("{0:D4}", d);
        }
    }
}