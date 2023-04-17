using System;
using System.Diagnostics;

namespace ProjectOne
{
    class MainClass
    {


        public static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Введите входные данные: ");
            try
            {
                Console.Write("a = ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("b = ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("c = ");
                c = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.WriteLine();
                Discriminant(a, b, c);
            }
            catch (Exception)
            {

                Console.WriteLine("Вы ввели неверные данные");
                Console.ReadKey();
            }
        }

        public static void Discriminant(double a, double b, double c)
        {
            double d, x1, x2;

            if (a == 0)
            {
                Console.WriteLine("На ноль делить нельзя!");
                Console.WriteLine("Уравнение не имеет корней");
                Console.ReadKey();
            }
            else
            {
                d = (b * b) - 4 * c * a;
                if (d < 0)
                {
                    Console.WriteLine("Уравнение не имеет корней");
                }
                else if (d == 0)
                {
                    x1 = -b / 2 * a;
                    Console.WriteLine("Уравнение имеет один единственный корень: ");
                    Console.WriteLine($"x = {Math.Round(x1, 2)}");
                }
                else
                {
                    x1 = (-b - Math.Sqrt(d)) / (2 * a);
                    x2 = (-b + Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine($"X1 = {Math.Round(x1, 2)}");
                    Console.WriteLine($"X2 = {Math.Round(x2, 2)}");
                }
                Console.ReadKey();
            }

            
        }
    }
}
