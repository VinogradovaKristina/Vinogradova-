using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinogradovalab1
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Введите а");

                double a = Convert.ToDouble(Console.ReadLine());

                double z1, z2;

                z1 = (1 - 2 * Math.Pow(Math.Sin(a), 2)) / (1 + Math.Sin(2 * a));

                Console.WriteLine(z1);

                z2 = (1 - Math.Tan(a)) / (1 + Math.Tan(a));

                Console.WriteLine(z2);

                Console.ReadKey();

            }
        }
}
