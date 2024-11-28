// Для данного вещественного x найти значение следующей функции f, принимающей значения целого типа: 
//0, если x < 0,  
//f(x)  =  1, если x принадлежит [0, 1), [2, 3), …,  
//    −1, если x принадлежит [1, 2), [3, 4), … . 

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
            bool firstCondition = ((valueX >= 0 & valueX < 1) ^ (valueX >= 2 & valueX < 3));
            bool secondCondition = ((valueX >= 1 & valueX < 2) ^ (valueX >= 3 & valueX < 4));
            if (valueX < 0)
            {
                double argX = 0;
                Console.WriteLine(argX);
            }
            else if (firstCondition == true)
            {
                double argX = 1;
                Console.WriteLine(argX);
            }
            else if (secondCondition == true)
            {
                double argX = -1;
                Console.WriteLine(argX);
            }

            Console.ReadKey();
        }
    }
}


