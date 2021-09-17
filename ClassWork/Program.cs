using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1.1");
            Console.WriteLine("Введите дробное число (через запятую)");
            double number = Double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round(number, 2));

            Console.WriteLine("\nTask 1.2");
            Console.WriteLine(Math.Round(Math.E, 1));

            Console.WriteLine("\nTask 1.3");
            Console.WriteLine("Введите число");
            Console.WriteLine("Вы ввели число {0}", Console.ReadLine());

            Console.WriteLine("\nTask 1.4");
            Console.WriteLine("Введите число");
            Console.WriteLine("{0} - вот какое число Вы ввели", Console.ReadLine());

            Console.WriteLine("\nTask 1.5");
            Console.WriteLine("1 13 49");

            Console.WriteLine("\nTask 1.6");
            Console.WriteLine("7  15  100");

            Console.WriteLine("\nTask 1.7");
            Random r = new Random();
            Console.WriteLine("{0}  {1}  {2}", r.Next(), r.Next(), r.Next());

            Console.WriteLine("\nTask 1.8");
            Console.WriteLine("{0} {1} {2} {3}", r.Next(), r.Next(), r.Next(), r.Next());

            Console.WriteLine("\nTask 1.9");
            Console.WriteLine("50\n10");

            Console.WriteLine("\nTask 1.10");
            Console.WriteLine("5\n10\n21");

            Console.WriteLine("\nTask 1.11");
            Console.WriteLine("{0}\n{1}\n{2}\n{3}", r.Next(), r.Next(), r.Next(), r.Next());

            Console.WriteLine("\nTask 1.12");
            Console.WriteLine("{0} {1}\n{2} см", 5, 10 ,7);

            Console.WriteLine("\nTask 1.13");
            Console.WriteLine("{0} кг\n{1} {2}", 2, 13, 17);

            Console.WriteLine("\nTask 2.1\nВведите x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("a) y(x) = {0}\nb) x(a) = {1}", 7 * Math.Pow(x, 2) + 3 * x + 6, 12 * Math.Pow(a, 2) + 7 * a + 12);

            Console.WriteLine("\nTask 2.2\nВведите сторону квадрата");
            Console.WriteLine("Его периметр {0}", int.Parse(Console.ReadLine())*4);

            Console.WriteLine("\nTask 2.3\nВведите радиус окружности");
            Console.WriteLine("Её диаметр {0}", int.Parse(Console.ReadLine())*2);

            Console.WriteLine("\nTask 2.4\nВведите высоту над Землей (в километрах)");
            Console.WriteLine("Расстояние до линии горизонта {0} км", Math.Pow(Math.Pow(int.Parse(Console.ReadLine())+6350, 2) - 6350*6350, 0.5));

            Console.WriteLine("\nTask 2.5\nВведите ребро куба");
            int edge = int.Parse(Console.ReadLine());
            Console.WriteLine("Его объем равен {0}, а площадь боковой поверхности {1}", Math.Pow(edge, 3), edge*edge*6 );

            Console.WriteLine("\nTask 2.6\nВведите радиус окружности");
            int radius = int.Parse(Console.ReadLine());
            Console.WriteLine("Площадь окружности {0}\nДлина окружности {1}", Math.Pow(radius, 2)*Math.PI, 2*Math.PI*radius);

            Console.WriteLine("\nTask 2.7\nВведите число А");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число Б");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("a) Их среднее арифметическое {0}\nб) Их среднее геометрическое {1}", (double)(a+b)/2, Math.Sqrt(a*b));

            Console.WriteLine("\nTask 2.8\nВведите объем тела");
            int volume = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите массу тела");
            int weight = int.Parse(Console.ReadLine());
            Console.WriteLine("Плотность тела равна {0}", (double)weight/volume);

            Console.WriteLine("\nTask 2.9\nВведите кол-во жителей");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите площадь");
            int square = int.Parse(Console.ReadLine());
            Console.WriteLine("Плотность населения равна {0} человек / единицу площади", (double)count/square);

            Console.WriteLine("\nTask 2.10\nВведите а");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("x = {0}", (double)(-1)*b/a);

            Console.WriteLine("\nTask 2.11\nВведите первый катет прямоугольного треугольника");
            int first_cathetus = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй катет");
            int second_cathetus = int.Parse(Console.ReadLine());
            Console.WriteLine("Гипотенуза равна {0}", Math.Sqrt(Math.Pow(first_cathetus,2) + Math.Pow(second_cathetus, 2)));

            Console.WriteLine("\nTask 2.12\nВведите внешний радиус");
            int large_radius = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите внутрений радиус");
            int small_radius = int.Parse(Console.ReadLine());
            Console.WriteLine("Площадь кольца равна {0}", Math.Pow(large_radius, 2) * Math.PI - Math.Pow(small_radius, 2) * Math.PI);

            Console.WriteLine("\nTask 2.13\nВведите первый катет прямоугольного треугольника");
            first_cathetus = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй катет");
            second_cathetus = int.Parse(Console.ReadLine());
            Console.WriteLine("Периметр {0}", first_cathetus + second_cathetus + Math.Sqrt(Math.Pow(first_cathetus, 2) + Math.Pow(second_cathetus,2 )));

            Console.WriteLine("\nTask 2.13A\nВведите число А");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число Б");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("a) Среднее арифметическое их модулей {0}\nб) Среднее геометрическое их модулей {1}", (double)(Math.Abs(a) + Math.Abs(b)) / 2, Math.Sqrt(Math.Abs(a * b)));

            Console.WriteLine("\nTask 2.14\nВведите высоту трапеции");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите большее основание");
            int large_base = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите меньшее основание");
            int small_base = int.Parse(Console.ReadLine());
            double average_base = (small_base + large_base) / 2;
            Console.WriteLine("Площадь трапеции равна {0}",  average_base * height);

            Console.WriteLine("\nTask 2.14A\nВведите стороны прямоугольника");
            int lenght = int.Parse(Console.ReadLine());
            weight = int.Parse(Console.ReadLine());
            Console.WriteLine("Его площадь {0}\nЕго диагональ {1}", lenght*weight, Math.Sqrt(Math.Pow(lenght,2) + Math.Pow(weight, 2)));

            Console.WriteLine("\nTask 2.15\nВведите первое число");
            int first_number = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int second_number = int.Parse(Console.ReadLine());
            Console.WriteLine("Сумма {0}, разность {1}, произведение {2}, частное {3}", first_number+second_number, first_number-second_number, first_number*second_number, (double)first_number/second_number);

            Console.WriteLine("\nTask 2.16\nВведите стороны параллелепипеда");
            int edge_1 = int.Parse(Console.ReadLine());
            int edge_2 = int.Parse(Console.ReadLine());
            int edge_3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Объем {0}\nПлощадь боковой поверхности {1}", edge_1*edge_2*edge_3, edge_1*edge_2*2+edge_1*edge_3*2+edge_2*edge_3*2);

            Console.WriteLine("\nTask 2.17\nВведите х1");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y1");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите x2");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y2");
            int y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Расстояние между точками {0}", Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2)));

            Console.WriteLine("\nTask 2.18\nВведите высоту трапеции");
            height = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите меньшее основание");
            small_base = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите большее основание");
            large_base = int.Parse(Console.ReadLine());
            Console.WriteLine("Периметр равен {0}", 2*Math.Sqrt(Math.Pow(height,2) + Math.Pow((large_base - small_base) / 2, 2)) + small_base + large_base);

            Console.WriteLine("\nTask 2.19\nВведите меньшее основание");
            small_base = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите большее основание");
            large_base = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите угол");
            int angle = int.Parse(Console.ReadLine());
            Console.WriteLine("Площадь трапеции равна {0}", (double)(small_base + large_base) / 2 * (large_base - small_base) / 2 * Math.Tan(angle));

            Console.WriteLine("\nTask 2.20\nВведите х1");
            x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y1");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите x2");
            x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y2");
            y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите x3");
            int x3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y3");
            int y3 = int.Parse(Console.ReadLine());
            double first_side = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            double second_side = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
            double third_side = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
            double perimeter = first_side + second_side + third_side;
            Console.WriteLine("Периметр равер {0}, площадь равна {1}", perimeter, Math.Sqrt(perimeter*(perimeter/2 - first_side)*(perimeter/2 - second_side)*(perimeter/2 - third_side)/2));

            Console.WriteLine("\nTask 2.21\nВведите х1");
            x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите у1");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите x2");
            x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите у2");
            y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите x3");
            x3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите у3");
            y3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите x4");
            int x4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y4");
            int y4 = int.Parse(Console.ReadLine());
            first_side = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            second_side = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
            third_side = Math.Sqrt(Math.Pow(x3 - x4, 2) + Math.Pow(y3 - y4, 2));
            double fourth_side = Math.Sqrt(Math.Pow(x4 - x1, 2) + Math.Pow(y4 - y1, 2));
            double diagonal = Math.Sqrt(Math.Pow(x2 - x4, 2) + Math.Pow(y2 - y4, 2));
            double first_perimeter = first_side + fourth_side + diagonal;
            double first_square = Math.Sqrt(first_perimeter * (first_perimeter / 2 - first_side) * (first_perimeter / 2 - fourth_side) * (first_perimeter / 2 - diagonal) / 2);
            double second_perimeter = second_side + third_side + diagonal;
            double second_square = Math.Sqrt(second_perimeter * (second_perimeter / 2 - third_side) * (second_perimeter / 2 - fourth_side) * (second_perimeter / 2 - diagonal) / 2);
            Console.WriteLine("Площадь четырехугольника равна {0}", first_square + second_square);

            Console.WriteLine("\nTask 2.22\nВведите стоимость 1 кг конфет");
            int candle_price = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите стоимость 1 кг яблок");
            int apple_price = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите стоимость 1 кг печенья");
            int cookie_price = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите массу конфет");
            double candle_weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите массу яблок");
            double apple_weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите массу печенья");
            double cookie_weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Стоимость покупки {0}", candle_price*candle_weight+apple_price*apple_weight+cookie_price*cookie_weight);

            Console.WriteLine("\nTask 2.23\nВведите стоимость монитора");
            int monitor_price = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите стоимость системного блока");
            int system_unit_price = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите стоимость клавиатуры с мышью");
            int keyboard_mouse_price = int.Parse(Console.ReadLine());
            int pc_price = monitor_price + system_unit_price + keyboard_mouse_price;
            Console.WriteLine("Введите число N");
            count = int.Parse(Console.ReadLine());
            Console.WriteLine("Стоимость трех компьютеров равна {0}, стоимость N компьютеров равна {1}", 3*pc_price, count*pc_price);

            Console.WriteLine("\nTask 2.24\nВведите возраст Тани");
            int Tanya_age = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите возраст Мити");
            int Mitya_age = int.Parse(Console.ReadLine());
            double average_age = (Tanya_age + Mitya_age) / 2;
            Console.WriteLine("Их средний возраст {0}. Bозраст Мити отличается от среднего на {1}, а Тани на {2}", average_age, Math.Abs(Mitya_age-average_age), Math.Abs(Tanya_age-average_age));

            Console.WriteLine("\nTask 2.25\nВведите скорсть первого авто");
            int speed_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите скорость второго авто");
            int speed_2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите расстояние");
            int distance = int.Parse(Console.ReadLine());
            Console.WriteLine("Время равно {0}", distance / (speed_1 + speed_2));

            Console.WriteLine("\nTask 2.26\nВведите скорсть первого авто");
            speed_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите скорость второго авто");
            speed_2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите расстояние S на которое первый автомобиль обогнал второй");
            distance = int.Parse(Console.ReadLine());
            Console.WriteLine("Результат {0}", distance + Math.Abs(speed_1 - speed_2)*0.5);

            Console.WriteLine("\nTask 2.27\nВведите температуру в Цельсия");
            double temp_c = double.Parse(Console.ReadLine());
            double temp_f = temp_c * 1.8 + 32;
            double temp_k = temp_c + 273.15;
            Console.WriteLine("Температура по Фаренгейту {0}, по Кельвину {1}", temp_f, temp_k);

            Console.WriteLine("\nTask 2.28");
            Console.WriteLine("450 по Фаренгейту = {0} градусов Цельсия", (double)(450-32)/1.8);

            Console.WriteLine("\nTask 3.1\nВведите первую переменную");
            int var_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую переменную");
            int var_2 = int.Parse(Console.ReadLine());
            int supporting_var = var_1;
            var_1 = var_2;
            var_2 = supporting_var;

            Console.WriteLine("\nTask 3.2a\nВведите переменные a,b,c");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            supporting_var = b;
            b = c;
            c = a;
            a = supporting_var;
            Console.WriteLine("done");

            Console.WriteLine("Task 3.2b\nВведите переменные a,b,c");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            supporting_var = b;
            b = a;
            a = c;
            c = supporting_var;
            Console.WriteLine("done");

            Console.WriteLine("\nTask 3.3");
            a = int.Parse(Console.ReadLine());
            int a2 = a * a; // пункт a
            int a4 = a2 * a2;
            a2 = a * a; // пункт б
            int a3 = a2 * a;
            int a6 = a3 * a3;
            a2 = a * a; // пункт в
            a3 = a2 * a;
            a6 = a3 * a3;
            int a7 = a6 * a;
            a2 = a * a; // пункт г
            a4 = a2 * a2;
            int a8 = a4 * a4;
            a2 = a * a; // пункт д
            a4 = a2 * a2;
            a8 = a4 * a4;
            int a9 = a8 * a;
            a2 = a * a; // пукнт е
            a4 = a2 * a2;
            a8 = a4 * a4;
            int a10 = a8 * a2;

            Console.WriteLine("\nTask 3.4");
            a = int.Parse(Console.ReadLine());
            a2 = a * a; // пункт а
            a3 = a * a2;
            int a5 = a2 * a3;
            a10 = a5 * a5;
            a2 = a * a; // пункт б 
            a4 = a2 * a2;
            a8 = a4 * a4;
            int a16 = a8 * a8;
            int a20 = a16 * a4;
            a2 = a * a; // пункт в
            a3 = a2 * a;
            a5 = a2 * a3;
            a10 = a5 * a5;
            int a13 = a10 * a3;
            a2 = a * a; // пукнт г
            a4 = a2 * a2;
            a5 = a4 * a;
            a10 = a5 * a5;
            int a19 = 0; // не получается сделать
            a2 = a * a; // пункт д
            a3 = a2 * a;
            a5 = a3 * a2;
            a10 = a5 * a5;
            int a15 = a10 * a5;
            int a17 = a15 * a2;
            a2 = a * a; // пункт е
            a4 = a2 * a2;
            a8 = a4 * a4;
            int a12 = a8 * a4;
            int a24 = a12 * 12;
            int a28 = a24 * a4;

            Console.WriteLine("\nTask 3.5\n"); // не понял, что требуется



            Console.ReadKey();
        }
    }
}
