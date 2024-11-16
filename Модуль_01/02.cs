//Пользователь вводит с клавиатуры два числа. 
//Первое число — это значение, второе число процент, который необходимо посчитать. 
//Например, мы ввели с клавиатуры 90 и 10. Требуется вывести на экран 10 процентов от 90. Результат: 9.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleApp2;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1 число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2 число %: ");
            int b = Convert.ToInt32(Console.ReadLine());
            // Вывод числа
            Console.WriteLine("Результат: " + a * b / 100);
            Console.ReadKey();
        }

    }
}
