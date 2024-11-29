// Для данного вещественного x найти значение следующей функции f, принимающей вещественные значения: 
//f(x)  =  2·sin(x), если x > 0,  
//6 − x, если x ≤ 0. 

using System;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("ВВедите значение Х: ");
            double valueX = Double.Parse(Console.ReadLine());

            if (valueX > 0)
            {
                double argX = 2 * Math.Sin(valueX);
                Console.WriteLine(argX);
            }
            else if (valueX <= 0)
            {
                double argX = 6 - valueX;
                Console.WriteLine(argX);
            }

            Console.ReadKey();


        }
    }
}