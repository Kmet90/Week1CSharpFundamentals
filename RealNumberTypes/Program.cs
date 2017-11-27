using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealNumberTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte N = byte.Parse(Console.ReadLine());
            decimal number = decimal.Parse(Console.ReadLine());

            Console.WriteLine(Math.Round(number, N));
        }
    }
}
