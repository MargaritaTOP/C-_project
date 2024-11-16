//Пользователь вводит с клавиатуры дату. 
//Приложение должно отобразить название сезона и дня недели. 
//Например, если введено 22.12.2021, приложение должно отобразить Winter Wednesday.
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using ConsoleApp_2;

namespace ConsoleApp_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите дату для определения дня недели и месяца: ");
            DateTime userDateTime;
            if (DateTime.TryParse(Console.ReadLine(), out userDateTime))
            {
                Console.WriteLine("День недели введённой даты: " + userDateTime.DayOfWeek);
                Console.WriteLine("Месяц введённой даты: " + userDateTime.Month);
            }
            else
            {
                Console.WriteLine("Вы ввели некорректное значение.");
            }
            int b = userDateTime.Month;
            if ((b == 12) || (b <= 2)) Console.Write("Season - Winter");
            else if ((b >= 3) && (b <= 5)) Console.Write("Season - Spring");
            else if ((b >= 6) && (b <= 8)) Console.Write("Season - Summer");
            else if ((b >= 9) && (b <= 11)) Console.Write("Season - Autumn");
            Console.ReadKey();
        }

    }

}
