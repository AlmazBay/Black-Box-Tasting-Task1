using System;
using System.Collections.Generic;
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
            for (int i = 0; i < X.Length; i++)
            {
                Console.Write($"X{i + 1} = ");
                X[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < X.Length; i++)
            {
                Console.WriteLine($"X{i + 1} = {X[i]}");
            }
            
            //Quadrilateral();
        }

        private static void Quadrilateral()
        {

        }
    }
}
