using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetWings
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            int P = int.Parse(Console.ReadLine());

            double distance = (N / 1000.00) * M;
            int time = (N / 100) + (N / P * 5);

            Console.WriteLine("{0:f2} m.", distance);
            Console.WriteLine("{0} s.", time);
        }
    }
}
