// Даны целочисленные координаты точки на плоскости. Если точка совпадает с началом координат,
// то вывести 0. Если точка не совпадает с началом координат, но лежит на оси OX или OY,
// то вывести соответственно 1 или 2. Если точка не лежит на координатных осях, то вывести 3. 

using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите  координаты точки по оси Х: ");
            int coordinatesX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите  координаты точки по оси У: ");
            int coordinatesY = Convert.ToInt32(Console.ReadLine());

            if (coordinatesX == 0 & coordinatesY == 0)
                Console.WriteLine(0);
            // bool Condition0 = ((coordinatesX == 0 & coordinatesY != 0) ^ (coordinatesX != 0 & coordinatesY == 0));
            else if (coordinatesX == 0 & coordinatesY != 0)
            {
                Console.WriteLine(1);
            }
            else if (coordinatesX != 0 & coordinatesY == 0)
            {
                Console.WriteLine(2);
            }
            else
            {
                Console.WriteLine(3);
            }
            Console.ReadKey();
        }
    }
}
