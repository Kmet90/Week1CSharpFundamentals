using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace BigPower
{
    class Program
    {
        static void Main(string[] args)
        {
             int n = int.Parse(Console.ReadLine());

            BigInteger number = BigInteger.Pow(n, n);
                                   
            Console.WriteLine(number);
        }
    }
}
