using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите, какое вычисление надо сделать: ");
            string c = Console.ReadLine();
            Console.WriteLine("Введите число 1: ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число 2: ");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число 3(для квадратного уравнения), иначе 0: ");
            double d = Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case "+":
                    double sum = a + b;
                    Console.WriteLine("Сумма чисел:" + sum);
                    break;

                case "-":
                    double raz = a - b;
                    Console.WriteLine("Разность 1го и 2го: " + raz);
                    double raz1 = b - a;
                    Console.WriteLine("Разность 2го и 1го: " + raz1);
                    break;

                case "*":
                    double pro = a * b;
                    Console.WriteLine("Произведение чисел: " + pro);
                    break;

                case "/":
                    if (a < 0 && b < 0)
                    {
                        Console.WriteLine("На ноль делить нельзя:");
                    }
                    else
                    {
                        double ch = a / b;
                        Console.WriteLine("Частное 1го и 2го: " + ch);
                        double ch1 = b / a;
                        Console.WriteLine("Частное 2го и 1го: " + ch1);
                    }
                    break;

                case "^":
                    double pow = Math.Pow(a, b);
                    Console.WriteLine("Возведение 1го числа в степень 2го: " + pow);
                    double pow1 = Math.Pow(b, a);
                    Console.WriteLine("Возведение 2го числа в степень 1го: " + pow1);
                    break;

                case "sqrt":
                    double sqrt = Math.Sqrt(a);
                    Console.WriteLine("Корень из 1 числа: " + sqrt);
                    double sqrt1 = Math.Sqrt(b);
                    Console.WriteLine("Корень из 2 числа: " + sqrt1);
                    break;

                case "%":
                    if (a < 0 || b < 0)
                    {
                        Console.WriteLine("На ноль делить нельзя:");
                    }
                    else
                    {
                        double ost = a % b;
                        Console.WriteLine("Остаток от деления 1го на 2ое: " + ost);
                        double ost1 = b % a;
                        Console.WriteLine("Остаток от деления 2го на 1ое: " + ost1);
                    }
                    break;

                case "kv":
                    double g = (b * b) - 4 * a * d;
                    if (g < 0)
                    {
                        Console.WriteLine("Корней не имеет");
                    }
                    else if (g == 0)
                    {
                        double x3 = -b + Math.Sqrt(g) / 2 * a;
                        Console.WriteLine("Корень уравнения: " + x3);
                    }
                    else
                    {
                        double x1 = -b + Math.Sqrt(g) / 2 * a;
                        double x2 = -b - Math.Sqrt(g) / 2 * a;
                        Console.WriteLine("Первый корень уравнения: " + x1);
                        Console.WriteLine("Второй корень уравнения: " + x2);
                    }
                    break;

                default:
                    Console.WriteLine("Некорректная операция.");
                    break;

            }

        }
    }
}
