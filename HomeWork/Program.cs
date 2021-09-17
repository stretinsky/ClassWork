using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 2.1\nВведите свое имя");
            Console.WriteLine("Здравствуйте, {0}.", Console.ReadLine());

            Console.WriteLine("\nУпражнение 2.2\nВведите число А");
            int number_a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число Б (Б != 0)");
            int number_b = int.Parse(Console.ReadLine());
            if (number_b != 0) 
            {
                Console.WriteLine("A / Б = {0}", (double)number_a/number_b);
            }
            else
            {
                Console.WriteLine("Число Б не должно быть равно нулю");
            }

            Console.WriteLine("\nДомашнее задание 2.1");
            char input = char.Parse(Console.ReadLine());
            int ascii_code = input;
            char output = (char)(ascii_code+1);
            Console.WriteLine(output);

            Console.WriteLine("\nДомашнее задание 2.2\nВведите коэффициент а");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициент b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициент c");
            double c = double.Parse(Console.ReadLine());
            double discriminant = b * b - 4 * a * c;
            if (a == 0)
            {
                double result = (double)(-c / b);
                Console.WriteLine("x = {0}", result);
            }
            else if (discriminant < 0)
            {
                Console.WriteLine("Корней нет");
            }
            else if (discriminant == 0)
            {
                double x = -b/(2*a);
                Console.WriteLine("x = {0}", x);
            }
            else if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
            }
            Console.ReadKey();
        }
    }
}
