using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinLAb2oblast
{
    class Program
    {
        static void Main(string[] args)
        {
            //Определить область попадания тояки Виноградова К.А. //Вариант 11 

            Double x, y, R = 10;
            Console.WriteLine("Упражнение №2: Опреденение области ");
            Console.Write("x=");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y=");
            y = Convert.ToDouble(Console.ReadLine());
            if ((x >= 0 && x <= R && y <= Math.Sqrt(R * R - x * x)) || (x >= -R && x <= 0 && y <= 0 && y >= -x - R))
            Console.WriteLine(" Определена область"); 
else 
Console.WriteLine("Неопределена область");
            Console.ReadKey();
        }
    }
}
