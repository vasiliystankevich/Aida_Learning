// Даны целочисленные координаты трех вершин прямоугольника, стороны которого параллельны координатным осям.
// Найти координаты его четвертой вершины. 


using System;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите координаты первой точки: ");
            //var  arr = Console.ReadLine().Split();
            //int coordinatAX = Convert.ToInt32(arr[0]);
            //int coordinatAY  = Convert.ToInt32(arr[1]);
            int coordinatX1 = int.Parse(Console.ReadLine());
            int coordinatY1 = int.Parse(Console.ReadLine());
            Console.ReadKey();
            Console.WriteLine("Введите координаты второй точки: ");
            //var  arr = Console.ReadLine().Split();
            //int coordinatAX = Convert.ToInt32(arr[0]);
            //int coordinatAY  = Convert.ToInt32(arr[1]);
            int coordinatX2 = int.Parse(Console.ReadLine());
            int coordinatY2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты третьей точки: ");
            //var  arr = Console.ReadLine().Split();
            //int coordinatAX = Convert.ToInt32(arr[0]);
            //int coordinatAY  = Convert.ToInt32(arr[1]);
            int coordinatX3 = int.Parse(Console.ReadLine());
            int coordinatY3 = int.Parse(Console.ReadLine());

           // int coordinatX4, coordinatY4;
            
            if (coordinatX1 == coordinatX2)
            {
                int coordinatX4 = coordinatX3;
            }
            if (coordinatY2 == coordinatY3)
            {
                int coordinatY4 = coordinatY2;
            }
            Console.WriteLine($"{coordinatX3}, {coordinatY2}");

            Console.ReadKey();

        }
    }
}

        
        
        
              
        
            