//������������ ������ � ���������� ��� �����. 
//������ ����� � ��� ��������, ������ ����� �������, ������� ���������� ���������. 
//��������, �� ����� � ���������� 90 � 10. ��������� ������� �� ����� 10 ��������� �� 90. ���������: 9.
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
            Console.WriteLine("������� 1 �����: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("������� 2 ����� %: ");
            int b = Convert.ToInt32(Console.ReadLine());
            // ����� �����
            Console.WriteLine("���������: " + a * b / 100);
            Console.ReadKey();
        }

    }
}
