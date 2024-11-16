//������������ ������ � ���������� ����. 
//���������� ������ ���������� �������� ������ � ��� ������. 
//��������, ���� ������� 22.12.2021, ���������� ������ ���������� Winter Wednesday.
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
            Console.WriteLine("������� ���� ��� ����������� ��� ������ � ������: ");
            DateTime userDateTime;
            if (DateTime.TryParse(Console.ReadLine(), out userDateTime))
            {
                Console.WriteLine("���� ������ �������� ����: " + userDateTime.DayOfWeek);
                Console.WriteLine("����� �������� ����: " + userDateTime.Month);
            }
            else
            {
                Console.WriteLine("�� ����� ������������ ��������.");
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
