//������������ ������ � ���������� ��������� �����������. 
//� ����������� �� ������ ������������ ��������� ��������� ����������� �� ���������� � ������� ��� ��������.
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
            Console.WriteLine("����������, ������� ����������� � ��������� �������� �(�) ��� F(�):");
            string input = Console.ReadLine();

            // ������� �������,�������� ����� � ��������� ������ � �����
            string noSpaces = input.Replace(" ", "");
            noSpaces = noSpaces.ToLower();
            string str = noSpaces.Remove(noSpaces.Length - 1);
            double degrees = Convert.ToDouble(str);

            if (noSpaces.EndsWith("c") || noSpaces.EndsWith("�"))
            {
                double f = degrees * 9 / 5 + 32;
                Console.WriteLine($"{degrees}C = {f}F");
            }
            else if (noSpaces.EndsWith("f") || noSpaces.EndsWith("�"))
            {
                double c = (degrees - 32) / 1.8;
                Console.WriteLine($"{degrees}F = {c}C");
            }

            Console.ReadLine();
        }

    }

}

