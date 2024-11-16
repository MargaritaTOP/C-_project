//Пользователь вводит с клавиатуры показания температуры. 
//В зависимости от выбора пользователя программа переводит температуру из Фаренгейта в Цельсий или наоборот.
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
            Console.WriteLine("Пожалуйста, введите температуру с последним символом С(Ц) или F(Ф):");
            string input = Console.ReadLine();

            // удаляем пробелы,получаем число и последний символ в конце
            string noSpaces = input.Replace(" ", "");
            noSpaces = noSpaces.ToLower();
            string str = noSpaces.Remove(noSpaces.Length - 1);
            double degrees = Convert.ToDouble(str);

            if (noSpaces.EndsWith("c") || noSpaces.EndsWith("ц"))
            {
                double f = degrees * 9 / 5 + 32;
                Console.WriteLine($"{degrees}C = {f}F");
            }
            else if (noSpaces.EndsWith("f") || noSpaces.EndsWith("ф"))
            {
                double c = (degrees - 32) / 1.8;
                Console.WriteLine($"{degrees}F = {c}C");
            }

            Console.ReadLine();
        }

    }

}

