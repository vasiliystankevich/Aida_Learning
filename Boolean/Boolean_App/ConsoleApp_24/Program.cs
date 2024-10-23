//  Даны числа A, B, C (число A не равно 0). Рассмотрев дискриминант D = B2 − 4·A·C, проверить
// истинность высказывания: «Квадратное уравнение A·x 2 + B·x + C = 0 имеет вещественные корни»

namespace ConsoleApp_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введите числа А, В, С: ");
            string[] arr = Console.ReadLine().Split();
            int a = int.Parse(arr[0]);
            int b = int.Parse(arr[1]);
            int c = int.Parse(arr[2]);
            int d = (b * b) - (4 * a * c); //через Math  не получается, выдает ошибку
            if (d < 0)
                Console.WriteLine("Корней нет");
            else
            {
                Console.WriteLine("Уавнение имеет вещественные корни");
            }

            Console.ReadKey();
        }
    }
}
