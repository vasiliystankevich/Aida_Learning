// Даны два целых числа: A, B. Проверить истинность высказывания: «Справедливы неравенства A > 2 и B ≤ 3»

namespace ConsoleApp_4;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введите число А: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число В: ");
        int b = Convert.ToInt32(Console.ReadLine());
        bool c = a > 2 & b <= 3;
        Console.WriteLine(c);
        Console.ReadKey();
    }
}