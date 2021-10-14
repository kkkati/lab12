using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Длинна окружности равна {0}",Krug.Dlina(5));
            Console.WriteLine("Площадь окружности равна {0}", Krug.Square(5));
            Krug.PrinadlPoint(5, 1, 1);
            Console.ReadKey();
        }

        public static class Krug
        {
            //метод расчитывает длину окружности
            public static double Dlina(double r)
            {
                double dlina = 2 * r * Math.PI;
                return dlina;
            }

            //метод расчитывает площадь окружности
            public static double Square(double r)
            {
                double square = Math.Pow(r,2) * Math.PI;
                return square;
            }

            //метод определяет принадлежность точки к кругу с центром (0,0)
            public static bool PrinadlPoint (double r, double x, double y)
            {
                bool check;
                double prinadlPoint = Math.Pow(x, 2) + Math.Pow(y, 2);
                if (prinadlPoint<Math.Pow(r,2))
                {
                    Console.WriteLine("Точка находится в пределах круга");
                    check = true;
                    return check;
                }
                else
                {
                    Console.WriteLine("Точка находится вне круга");
                    check = false;
                    return check;
                }

            }

        }
    }
}
