// Даны координаты точки, не лежащей на координатных осях OX и OY. Определить номер координатной четверти,
// в которой находится данная точка. 

using System;
namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите координаты точки: ");
            var  arr = Console.ReadLine().Split();
            int coordinatesX = Convert.ToInt32(arr[0]);
            int coordinatesY  = Convert.ToInt32(arr[1]);
            
            if (coordinatesX > 0 & coordinatesY > 0)
            {
                Console.WriteLine(" coordinate quarter №I");
            }
            else if (coordinatesX < 0 & coordinatesY > 0)
            {
                Console.WriteLine("coordinate quarter №II");    
            }
            else if (coordinatesX < 0 & coordinatesY < 0)
            {
                Console.WriteLine("coordinate quarter №III");  
            }
            else if (coordinatesX > 0 & coordinatesY < 0)
            {
                Console.WriteLine("coordinate quarter №IV");  
            }
            Console.ReadKey();

        }
    }
}