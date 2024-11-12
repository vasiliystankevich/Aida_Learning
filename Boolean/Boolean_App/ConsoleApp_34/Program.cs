// Даны координаты поля шахматной доски x, y (целые числа, лежащие в диапазоне 1–8). Учитывая, что левое
// нижнее поле доски (1, 1) является черным, проверить истинность высказывания: «Данное поле является белым».

namespace ConsoleApp_34_35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите координаты шхматной доски х, у: ");
            string[] arr = Console.ReadLine().Split();
            int x = int.Parse(arr[0]);
            int y = int.Parse(arr[1]);


            if (( ((x % 2) == 0) & ((y % 2) != 0)  ) || ( ((y % 2) == 0) & ((x % 2) != 0)  ))
                Console.WriteLine("Данное поле является белым");
            else
            {
                Console.WriteLine("Данное поле является черным");
            }

            Console.ReadKey();
        }
    }

}