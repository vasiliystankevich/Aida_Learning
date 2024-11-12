// Даны целые числа a, b, c. Проверить истинность высказывания:
// «Существует треугольник со сторонами a, b, c»

namespace ConsoleApp_33
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
            

            if (((a+ b) > c) || ((a + c) > b) || ((b + c) > a))
                Console.WriteLine("Треугольник существует");
            else
            {
                Console.WriteLine("Треугольник не существует");
            }

            Console.ReadKey();
        }
    }

}