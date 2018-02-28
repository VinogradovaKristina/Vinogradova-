using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinogradovaLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Double r = 0, x, y;
            Console.WriteLine("Упражнение №1");
            Console.Write("x=");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("r=");
            r = Convert.ToDouble(Console.ReadLine());
            if (-3 <= x && x < -2)
                y = -x - 2;
            else if (-2 <= x && x < -1)
                y = (1 - (x + 1));
            else if (-1 <= x && x < 1)
                y = 1;
            else if (1 <= x && x < 2)
                y = -2 * x + 3;
            else if (2 <= x && x <= 5)
                y = 1;
            else
                Console.WriteLine();
            Console.ReadKey();
        }
    }
}
