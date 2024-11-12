//  Дано четырехзначное число. Проверить истинность высказывания:
// «Данное число читается одинаково слева направо и справа налево»

namespace ConsoleApp_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введите четырехзначное число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int aa = (a % 10000) / 1000;
            int ab = (a % 1000) / 100;
            int ac = (a % 100) / 10;
            int ad = a % 10;
            if ((aa == ad) & (ab == ac))
                Console.WriteLine("Данное число читается одинаково слева направо и справа налево");
            else
            {
                Console.WriteLine("Число не является палиндромом");
            }

            Console.ReadKey();

        }
    }
}