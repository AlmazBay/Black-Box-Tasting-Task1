using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Task2
    {
        public static void Main()
        {
            int a, b, c;
            Console.WriteLine("Введите длины треугольника");
            try
            {
                Console.WriteLine("a= ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("b= ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("c= ");
                c = Convert.ToInt32(Console.ReadLine());
                Triangle(a, b, c);
            }
            catch (Exception)
            {
                Console.WriteLine("Вы ввелие неверные данные");
            }
        }

        public static void Triangle(int a, int b, int c)
        {

        }

    }
}
