using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._1
{
    class Program
    {
        public static double dlina(double x1, double y1, double x2, double y2)
        {
            double D;
            D = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            return D;
        }
        public static bool treug(double a, double b, double c)
        {
            bool f = false;
            if (a < (b + c) && b < (a + c) && c < (a + b))
            {
                f = true;
            }
            return f;
        }

        static void Main(string[] args)
        {
            try
            {
                double[] x = new double[4];
                double[] y = new double[4];
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("Введите координаты вершин:");
                    x[i] = Convert.ToDouble(Console.ReadLine());
                    y[i] = Convert.ToDouble(Console.ReadLine());
                }
                int h = 0;
                int k = 0;
                for (int i = 0; i < 2; i++)
                {
                    double a = dlina(x[k], y[k], x[k + 1], y[k + 1]);
                    double b = dlina(x[k + 1], y[k + 1], x[k + 2], y[k + 2]);
                    double c = dlina(x[k + 2], y[k + 2], x[k], y[k]);
                    if (treug(a, b, c))
                    {
                        h++;

                    }
                    a = dlina(x[k], y[k], x[k + 1], y[k + 1]);
                    b = dlina(x[k + 1], y[k + 1], x[k + 3], y[k + 3]);
                    c = dlina(x[k + 3], y[k + 3], x[k], y[k]);
                    if (treug(a, b, c))
                    {
                        h++;

                    }
                }
                Console.WriteLine("Треугольников может быть: "+h);
                Console.ReadKey();
            }
            catch(Exception E)
            {
                Console.WriteLine(E.Message);
                Console.ReadKey();
            }
        }
    }
}
