using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinogradovaLab2V11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Функция графика Виноградова К.А.// Вариант 11 
            Double x, y = 0;

            Console.WriteLine("Упражнение №1: График");

            Console.Write("x=");

            x = Convert.ToDouble(Console.ReadLine());

            if (-3 <= x && x < -2)

                y = -x - 2;

            else if (-2 <= x && x < -1)

                y = Math.Sqrt(1 - Math.Pow(x + 1, 2));

            else if (-1 <= x && x < 1)

                y = 1;

            else if (1 <= x && x < 2)

                y = -2 * x + 3;

            else if (2 <= x && x <= 5)

                y = 1;

            else
                Console.WriteLine("Неопределена");
            Console.WriteLine("y=" + y);

            Console.ReadKey();

            






        }
        
    }
}
