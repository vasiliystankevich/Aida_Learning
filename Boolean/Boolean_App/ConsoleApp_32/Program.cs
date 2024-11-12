// Даны целые числа a, b, c, являющиеся сторонами некоторого треугольника.
// Проверить истинность высказывания: «Треугольник со сторонами a, b, c является прямоугольным».

namespace ConsoleApp_32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите Целые числа  a, b, c: ");
            string[] arr = Console.ReadLine().Split();
            int a = int.Parse(arr[0]);
            int b = int.Parse(arr[1]);
            int c = int.Parse(arr[2]);
            double aa = Math.Pow(a, 2);
            double bb = Math.Pow(b, 2);
            double cc = Math.Pow(c, 2);
            
            if (((aa + bb) == cc) || ((aa + cc) == bb) || ((bb + cc) == aa))
                Console.WriteLine("Треугольник со сторонами a, b, c является прямоугольным");
            else
            {
                Console.WriteLine("Треугольник со сторонами a, b, c не является прямоугольным");
            }
            Console.ReadKey();
        }
    }
}