// Даны числа x, y. Проверить истинность высказывания: «Точка с
// координатами (x, y) лежит во второй или третьей координатной четверти».

namespace ConsoleApp_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите координаты х, у: ");
            string[] arr = Console.ReadLine().Split();
            int x = int.Parse(arr[0]);
            int y = int.Parse(arr[1]);
            if (x > 0)
                Console.WriteLine("Точка с координатами (x, y)  не лежит во второй или третьей координатной четверти");
            else if (((x < 0) & (y > 0)) ^ ((x < 0) & (y < 0)))
            {
                Console.WriteLine("Точка с координатами (x, y)   лежит во второй или третьей координатной четверти");
            }
            Console.ReadKey();
        }
    }
}

//или надо было написать через  swith??