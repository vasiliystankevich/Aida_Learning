// Дано целое число A. Проверить истинность высказывания: «Число A является четным

namespace ConsoleApp_3;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введите целое число");
        int a = Convert.ToInt32(Console.ReadLine());
        bool c = a % 2 == 0;
        Console.WriteLine(c);
        Console.ReadKey();
            
    }
}