// Для данного вещественного x найти значение следующей функции f, принимающей вещественные значения: 
//−x, если x ≤ 0,  
//f(x)  =  x2, если 0 < x < 2,  
//4, если x ≥ 2. 
using System;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("ВВедите значение Х: ");
            double valueX = Double.Parse(Console.ReadLine());

            if (valueX <= 0)
            {
                double argX = -valueX;
                Console.WriteLine(argX);
            }
            else if ((0 < valueX) & (valueX < 2)) 
            {
                double argX =  Math.Pow(valueX, 2);
                Console.WriteLine(argX);
            }
            else if (valueX >= 2)
            {
                double argX = 4;
                Console.WriteLine(argX);
            }

            Console.ReadKey();

            


        }
    }
}



