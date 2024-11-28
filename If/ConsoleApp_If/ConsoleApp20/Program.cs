// На числовой оси расположены три точки: A, B, C. Определить, какая из двух последних точек (B или C) расположена
// ближе к A, и вывести эту точку и ее расстояние от точки A. 

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите  три целых числа: ");
            var  arr = Console.ReadLine().Split();
            int a = Convert.ToInt32(arr[0]);
            int b = Convert.ToInt32(arr[1]);
            int c = Convert.ToInt32(arr[2]);
            int ab = Math.Abs(a - b);
            int ac = Math.Abs(a - c);

            if (ab < ac)
            {
                Console.WriteLine($"{ab}, {b}");
            }
            else if (ab > ac)
            {
                Console.WriteLine($"{ac}, {c}");    
            }
            {
                
            }
            Console.ReadKey();

        }
    }
}