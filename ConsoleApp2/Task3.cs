using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Task3
    {
        private static void Main(string[] args)
        {
            int[] X = new int[4];
            int[] Y = new int[4];


            Console.WriteLine("Введите координаты четырехугольника: ");
            try
            {
                for (int i = 0; i < X.Length; i++)
                {
                    Console.Write($"X{i + 1} = ");
                    X[i] = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"Y{i + 1} = ");
                    Y[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Введены неверные значения");
            }

            Quadrilateral(X, Y);
        }

        private static void Quadrilateral(int[] X, int[] Y)
        {
            double AB, BC, CD, AD; // стороны
            double AC, BD; // диагонали
            double a1, a2, b1, b2, a3, a4, b3, b4; // для формулы
            bool parallel; // параллельность
            bool perpendikular; // перпендикулярность

            AB = Math.Sqrt(Math.Pow(X[1] - X[0], 2) + Math.Pow(Y[1] - Y[0], 2));
            BC = Math.Sqrt(Math.Pow(X[2] - X[1], 2) + Math.Pow(Y[2] - Y[1], 2));
            CD = Math.Sqrt(Math.Pow(X[3] - X[2], 2) + Math.Pow(Y[3] - Y[2], 2));
            AD = Math.Sqrt(Math.Pow(X[3] - X[0], 2) + Math.Pow(Y[3] - Y[0], 2));

            a1 = Y[0] - Y[1];
            b1 = X[1] - X[0];
            a2 = Y[2] - Y[3];
            b2 = X[3] - X[2];

            a3 = Y[1] - Y[2];
            b3 = X[2] - X[1];
            a4 = Y[3] - Y[0];
            b4 = X[0] - X[3];
            parallel = Parallelism(a1, a2, b1, b2, a3, a4, b3, b4);
            perpendikular = Perpendicularity(a1, a2, b1, b2, a3, a4, b3, b4);

            for (int i = 0; i < 4 - 1; i++)
            {
                if (X[i] == X[i + 1] && Y[i] == Y[i + 1])
                {
                    Console.WriteLine("Четырехугольника не существует");
                    Process.GetCurrentProcess().Kill();
                }
            }

            if (AB == BC && BC == CD && CD == AD && AD == AB) // ромб или квадрат
            {

                AC = Math.Sqrt(Math.Pow(X[2] - X[0], 2) + Math.Pow(Y[2] - Y[0], 2));
                BD = Math.Sqrt(Math.Pow(X[3] - X[1], 2) + Math.Pow(Y[3] - Y[1], 2));
                if (AC == BD)
                {
                    Console.WriteLine("Квадрат");
                }
                else
                {
                    Console.WriteLine("Ромб");
                }
            }
            else if (AB == CD && BC == AD) // прямоугольник или параллелограмм
            {
                AC = Math.Sqrt(Math.Pow(X[2] - X[0], 2) + Math.Pow(Y[2] - Y[0], 2));
                BD = Math.Sqrt(Math.Pow(X[3] - X[1], 2) + Math.Pow(Y[3] - Y[1], 2));
                if (AC == BD)
                {
                    Console.WriteLine("Прямоугольник");
                }
                else
                {
                    Console.WriteLine("Параллелограмм");
                }
            }
            else if (parallel) // трапеции
            {
                if (AB == CD || AD == BC)
                {
                    Console.WriteLine("Равнобедренная трапеция");
                }
                else if (perpendikular)
                {
                    Console.WriteLine("Прямоугольная трапеция");
                }
                else
                {
                    Console.WriteLine("Трапеция общего вида");
                }

            }
            else
            {
                Console.WriteLine("Четырехугольник общего вида");
            }

            Console.WriteLine($"AB = {Math.Round(AB, 2)}\nBC = {Math.Round(BC, 2)}\nCD = {Math.Round(CD, 2)}\nAD = {Math.Round(AD, 2)}");
        }

        private static bool Parallelism(double a1, double a2, double b1, double b2, double a3, double a4, double b3, double b4)
        {
            if ((a1 * b2 - a2 * b1) == 0 || (a3 * b4 - a4 * b3) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool Perpendicularity(double a1, double a2, double b1, double b2, double a3, double a4, double b3, double b4)
        {
            if ((a1 * a2 + b3 * b4) == 0 || (a3 * a4 + b1 * b2) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
