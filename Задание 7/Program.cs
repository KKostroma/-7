using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите стороны первого треугольника\n");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());
            double p1;
            double S1;
            PloshTr1(a1, b1, c1, out p1, out S1);
            Console.Write("Введите стороны второго треугольника\n");
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            int c2 = Convert.ToInt32(Console.ReadLine());
            double p2;
            double S2;
            PloshTr2(a2, b2, c2, out p2, out S2);
            {
                if (S1 > S2)
                {
                    Console.WriteLine("Площадь первого треугольника больше площади второго");
                }
                else if (S2 > S1)
                {
                    Console.WriteLine("Площадь второго треугольника больше площади первого");
                }
                else if (S1 == S2)
                {
                    Console.WriteLine("Площади треугольников равны");
                }
            }
            Console.ReadKey();
        }
        static void PloshTr1(int a1, int b1, int c1, out double p1, out double S1)
        {
            p1 = (a1 + b1 + c1) / 2;
            S1 = Math.Sqrt(p1 * (p1 - a1) * (p1 - b1) * (p1 - c1));
            Console.WriteLine("Площадь первого треугольника: {0}", S1);
        }
        static void PloshTr2(int a2, int b2, int c2, out double p2, out double S2)
        {
            p2 = (a2 + b2 + c2) / 2;
            S2 = Math.Sqrt(p2 * (p2 - a2) * (p2 - b2) * (p2 - c2));
            Console.WriteLine("Пощадь второго треугольника: {0}", S2);
        }
    }
}

