// Элементы равнобедренного прямоугольного треугольника пронумерованы следующим образом: 1 — катет a, 2 —
// гипотенуза c = = a·√2, 3 — высота h, опущенная на гипотенузу (h = c/2), 4 — площадь S = c·h/2. Дан номер одного
// из этих элементов и его значение. Вывести значения остальных элементов данного треугольника (в том же порядке). 
using System;

namespace ConsoleApp_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("введите номер элемента и его значение");
            var arr = Console.ReadLine().Split();
            int elementNumber = Convert.ToInt32(arr[0]);
            double elementValue = Convert.ToInt32(arr[1]);
            double legA, hypotenuseC, heightH, areaS; 
            switch (elementNumber)
            {
                case 1:
                    legA = elementValue;
                    hypotenuseC = legA * Math.Sqrt(2);
                    heightH = hypotenuseC / 2;
                    areaS = (hypotenuseC * heightH) / 2;
                    Console.WriteLine($"{legA}, {hypotenuseC}, {heightH}, {areaS} "); //, hypotenuseC, heightH, areaS);
                
                    break;
                
                case 2:
                    hypotenuseC = elementValue;
                    legA = hypotenuseC / Math.Sqrt(2);
                    heightH = hypotenuseC / 2;
                    areaS = (hypotenuseC * heightH) / 2;
                    Console.WriteLine($"{legA}, {hypotenuseC}, {heightH}, {areaS} ");
                    break;
                case 3:
                    heightH = elementValue;
                    hypotenuseC = heightH * 2;
                    legA = hypotenuseC / Math.Sqrt(2);
                    areaS = (hypotenuseC * heightH) / 2;
                    Console.WriteLine($"{legA}, {hypotenuseC}, {heightH}, {areaS} ");
                    break;
                case 4:
                    areaS = elementValue;
                    heightH = Math.Sqrt(areaS);
                    hypotenuseC = heightH * 2;
                    legA = hypotenuseC / Math.Sqrt(2);
                    Console.WriteLine($"{legA}, {hypotenuseC}, {heightH}, {areaS} ");
                    break;
                default:
                  Console.WriteLine("Неверное значение");
                break;
            }
            //Console.WriteLine($"{legA}, {hypotenuseC}, {heightH}, {areaS} ");
            Console.ReadKey();
        }
    }
}