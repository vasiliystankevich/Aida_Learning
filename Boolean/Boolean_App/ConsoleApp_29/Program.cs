// . Даны числа x, y, x1, y1, x2, y2. Проверить истинность высказывания: «Точка с координатами (x, y)
// лежит внутри прямоугольника, левая верхняя вершина которого имеет координаты (x1, y1), правая нижняя —
// (x2, y2), а стороны параллельны координатным осям».

namespace ConsoleApp_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите координаты точки х, у: ");
            string[] arr = Console.ReadLine().Split();
            int x = int.Parse(arr[0]);
            int y = int.Parse(arr[1]);
            Console.ReadKey();
            Console.WriteLine("Введите координаты  точки, левой верхней вершины х1, у1: ");
            string[] arrv = Console.ReadLine().Split();
            int xv = int.Parse(arrv[0]);
            int yv = int.Parse(arrv[1]);
            Console.ReadKey();
            Console.WriteLine("Введите координаты  точки, правой нижней вершины х2, у2: ");
            string[] arrm = Console.ReadLine().Split();
            int xm = int.Parse(arrm[0]);
            int ym = int.Parse(arrm[1]);
            
            if (((x <= xm) & (x >= xv)) & ((y >= ym ) &(y <= yv)))
                Console.WriteLine("Точка с координатами (x, y) лежит в прямоугольнике");
            else 
            {
                Console.WriteLine("Точка с координатами (x, y) не лежит в прямоугольнике");
            }
            Console.ReadKey();
        }
    }
}