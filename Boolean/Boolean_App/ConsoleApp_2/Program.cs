// Дано целое число A. Проверить истинность высказывания: «Число A является нечетным»

namespace ConsoleApp_2;

class Proram
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введите целое число");
        int a = Convert.ToInt32(Console.ReadLine());
        bool c = a % 2 != 0;
        Console.WriteLine(c);
        Console.ReadKey();
        var result = "четное";
        if (a % 2 != 0)
        {
            result = "нечетное";
        }
        Console.WriteLine(result);
        Console.ReadKey();
    }
}