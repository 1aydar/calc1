using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc1
{
    class Program
    {
        static void Main(string[] args)
        {
            double first_number, second_number, r_addition, r_substraction, r_multiplication, r_division;
            Console.WriteLine("Программа калькулятор v 1.0, автор Aydar \nДля продолжения нажмите Enter.");
            Console.ReadLine();
            Console.WriteLine("Введите первое число и нажмите Enter");
            first_number = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число и нажмите Enter");
            second_number = Double.Parse(Console.ReadLine());
            r_addition = (first_number + second_number);
            r_substraction = (first_number - second_number);
            r_multiplication = (first_number * second_number);
            r_division = (first_number / second_number);
            Console.WriteLine("Для сложения этих чисел нажмите A, для вычитания нажмите S, \nдля умножения нажмите M, для деления нажмите D.");
            var key = Console.ReadKey();
            if(key.Key == ConsoleKey.A)
            {
                Console.Clear();
                Console.WriteLine("Результат сложения: " + r_addition);
            }

            else if (key.Key == ConsoleKey.S)
            {
                Console.Clear();
                Console.WriteLine("Результат вычитания: " + r_substraction);
            }

            else if (key.Key == ConsoleKey.M)
            {
                Console.Clear();
                Console.WriteLine("Результат умножения: " + r_multiplication);
            }

            else if (key.Key == ConsoleKey.D)
            {
                Console.Clear();
                Console.WriteLine("Результат деления: " + r_division);
            }
        }
    }
}
