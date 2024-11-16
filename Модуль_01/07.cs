//Пользователь вводит с клавиатуры два числа. 
//Нужно показать все четные числа в указанном диапазоне. 
//Если границы диапазона указаны неправильно требуется произвести нормализацию границ. 
//Например, пользователь ввел 20 и 11, требуется нормализация, после которой начало диапазона станет равно 11, а конец 20.
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
            int firstValue, secondValue, firstValue1, secondValue2;
            Console.WriteLine("Пожалуйста, введите начало диапазона:");
            firstValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Пожалуйста, введите конец диапазона:");
            secondValue = int.Parse(Console.ReadLine());
            if (firstValue < secondValue)
            {
                Console.Write("Чётные числа в указанном диапазоне = ");
                for (int i = firstValue; i <= secondValue; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            else
            {
                Console.Write("Чётные числа в указанном диапазоне = ");
                firstValue1 = secondValue;
                secondValue2 = firstValue;
                for (int i = firstValue1; i <= secondValue2; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            Console.ReadKey();

        }

    }

}
