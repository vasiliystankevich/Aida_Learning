// Локатор ориентирован на одну из сторон света («С» — север, «З» — запад, «Ю» — юг, «В» — восток) и может принимать
// три цифровые команды поворота: 1 — поворот налево, −1 — поворот направо, 2 — поворот на 180°. Дан символ C —
// исходная ориентация локатора и целые числа N1 и N2 — две посланные команды. Вывести ориентацию локатора после выполнения
// этих команд. 
using System;

namespace ConsoleApp_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("введите исходную ориентацию локатора ('N', 'S', 'W' или 'E') и две команды (целые числа -1, 1, 2) ");
            var arr = Console.ReadLine().Split();
            string locatorOrient = Convert.ToString(arr[0]);
            int command1 = Convert.ToInt32(arr[1]);
            int command2 = Convert.ToInt32(arr[2]);

            switch (command1)
            {
                case 1:
                {
                    switch (locatorOrient)
                    {
                        case "N": locatorOrient = "W"; break;
                        case "S": locatorOrient = "E"; break;
                        case "W": locatorOrient = "N"; break;
                        case "E": locatorOrient = "S"; break;
                    }
                } break;
                case -1:
                {
                    switch (locatorOrient)
                    {
                        case "N": locatorOrient = "E"; break;
                        case "S": locatorOrient = "W"; break;
                        case "W": locatorOrient = "S"; break;
                        case "E": locatorOrient = "N"; break;
                    }
                } break;
                case 2:
                {
                    switch (locatorOrient)
                    {
                        case "N": locatorOrient = "S"; break;
                        case "S": locatorOrient = "N"; break;
                        case "W": locatorOrient = "E"; break;
                        case "E": locatorOrient = "W"; break;
                    }
                } break;
            }

            switch (command2)
            {
                case 1:
                {
                    switch (locatorOrient)
                    {
                        case "N": locatorOrient = "W"; break;
                        case "S": locatorOrient = "E"; break;
                        case "W": locatorOrient = "N"; break;
                        case "E": locatorOrient = "S"; break;
                    }
                } break;
                case -1:
                {
                    switch (locatorOrient)
                    {
                        case "N": locatorOrient = "E"; break;
                        case "S": locatorOrient = "W"; break;
                        case "W": locatorOrient = "S"; break;
                        case "E": locatorOrient = "N"; break;
                    }
                } break;
                case 2:
                {
                    switch (locatorOrient)
                    {
                        case "N": locatorOrient = "S"; break;
                        case "S": locatorOrient = "N"; break;
                        case "W": locatorOrient = "E"; break;
                        case "E": locatorOrient = "W"; break;
                    }
                } break;
            }

            Console.WriteLine($"Result: locator orient - [{locatorOrient}]");
            Console.WriteLine("Press Enter for exit...");
            Console.ReadLine();
        }
    }
}


