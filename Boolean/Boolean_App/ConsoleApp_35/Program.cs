// Даны координаты двух различных полей шахматной доски x1,
// y1, x2, y2 (целые числа, лежащие в диапазоне 1–8). Проверить истинность
// высказывания: «Данные поля имеют одинаковый цвет».

namespace ConsoleApp_35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите последоватльно координты первого и второго поля(х1,у1,х2,у2):");
            string[] arr = Console.ReadLine().Split();
            int x = int.Parse(arr[0]);
            int y = int.Parse(arr[1]);
            int xx = int.Parse(arr[2]);
            int yy = int.Parse(arr[3]);
            
            if ( ((( ((x % 2) == 0) & ((y % 2) != 0)  ) || ( ((y % 2) == 0) & ((x % 2) != 0)  ))) ==  ((( ((xx % 2) == 0) & ((yy % 2) != 0)  ) || ( ((yy % 2) == 0) & ((xx % 2) != 0)  ))) )
               //тут такой длинный монстр, но работает. может надо было как то по другому решить?
                Console.WriteLine("поля имеют одинаковый цвет");
            
            else
            {
                Console.WriteLine("поля разного цвета");
            }

            Console.ReadKey();
        }
    }        
}
