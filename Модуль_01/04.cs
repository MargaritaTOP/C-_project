//Пользователь вводит шестизначное число. После этого пользователь вводит номера разрядов для обмена цифр. 
//Например, если пользователь ввёл один и шесть, это означает, что нужно поменять местами первую и шестую цифры. 
//Число 723895 должно превратиться в 523897. Если пользователь ввёл не шестизначное число, нужно вывести сообщение об ошибке.
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
            Console.WriteLine("Введите шестизначное число:");
            string numStr = Console.ReadLine();

            int numInt = Convert.ToInt32(numStr);
            if (numInt > 999999 || numInt < 100000) Console.WriteLine("Ошибка. Введите шестизначное число:");

            Console.WriteLine("Какие цифры поменять местами:");
            int numInt1 = Convert.ToInt32(Console.ReadLine());
            int numInt2 = Convert.ToInt32(Console.ReadLine());

            char[] numStrArr = numStr.ToCharArray();
            char temp1 = numStrArr[numInt1 - 1];
            char temp2 = numStrArr[numInt2 - 1];

            numStrArr[numInt1 - 1] = temp2;
            numStrArr[numInt2 - 1] = temp1;

            Console.WriteLine(numStrArr);

            Console.ReadLine();
        }

    }

}
