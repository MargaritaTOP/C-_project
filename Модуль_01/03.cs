//������������ ������ � ���������� ������ �����. 
//���������� ������� �����, ���������� ��� �����. 
//��������, ���� � ���������� ������� 1, 5, 7, 8 ����� ����� ������������ ����� 1578.
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
            Console.WriteLine("������� 1 �����: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("������� 2 �����: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("������� 3 �����: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("������� 4 �����: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("���������: " + a + b + c + d);
        }

    }

}
