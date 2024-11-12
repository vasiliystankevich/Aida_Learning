//Даны целые числа a, b, c, являющиеся сторонами некоторого треугольника.
//Проверить истинность высказывания: «Треугольник со сторонами a, b, c является равносторонним»

namespace ConsoleApp_30
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
            if (( a == b) & (b == c) & (c == a))
                Console.WriteLine("Треугольник со сторонами a, b, c является равносторонним");
            else if (((a == b) & (a != c)) || ((a == c) & (a != b)) || (c == b) & (c != a))
            {
                Console.WriteLine("Tреугольник является равнобедренным");
            }
            else
            {
                Console.WriteLine("треугольник не является ни равносторонним, ни равнобедренным");
            }
            Console.ReadKey();
        }
    }
}