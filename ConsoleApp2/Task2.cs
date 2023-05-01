using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Task2
    {
        public static void Mainr(string[] args)
        {
            sbyte a, b, c;
            Console.WriteLine("Введите длины треугольника");
            try
            {
                Console.Write("a= ");
                a = Convert.ToSByte(Console.ReadLine());
                Console.Write("b= ");
                b = Convert.ToSByte(Console.ReadLine());
                Console.Write("c= ");
                c = Convert.ToSByte(Console.ReadLine());
                Triangle(a, b, c);
            }
            catch (Exception)
            {
                Console.WriteLine("Вы ввели неверные данные");
            }
        }

        public static void Triangle(sbyte a, sbyte b, sbyte c)
        {
            if (((a + b) < c) || ((a + c) < b) || ((b + c) < a))
            {
                Console.WriteLine("Такого треугольника не существует:(");
            }
            else
            {
                if (a <= 0 || b <= 0 || c <= 0)
                {
                    Console.WriteLine("Такого треугольника не существует:(");
                }
                else
                {
                    if ((a != b) && (a != c) && (c != b))
                    {
                        if ((Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) || (Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2) || (Math.Pow(c, 2) + Math.Pow(b, 2) == Math.Pow(a, 2)))))
                        {
                            Console.WriteLine("Треугольник прямоугольный!");
                        }
                        else
                        {
                            Console.WriteLine("Треульник разносторонний!");
                        }
                    }
                    else if ((a == b) && (a == c) && (b == c))
                    {
                        Console.WriteLine("Треугольник равносторонний!");
                    }
                    else if ((a == b) || (a == c) || (b == c))
                    {
                        Console.WriteLine("Треугольник равнобедренный!");
                    }
                }
                
            }
        }

    }
}
