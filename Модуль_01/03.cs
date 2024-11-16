//Пользователь вводит с клавиатуры четыре цифры. 
//Необходимо создать число, содержащее эти цифры. 
//Например, если с клавиатуры введено 1, 5, 7, 8 тогда нужно сформировать число 1578.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleApp_2;

namespace ConsoleApp_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1 число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2 число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 3 число: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 4 число: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат: " + a + b + c + d);
        }

    }

}
