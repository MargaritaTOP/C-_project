//������������ ������ � ���������� ��� �����. 
//����� �������� ��� ������ ����� � ��������� ���������. 
//���� ������� ��������� ������� ����������� ��������� ���������� ������������ ������. 
//��������, ������������ ���� 20 � 11, ��������� ������������, ����� ������� ������ ��������� ������ ����� 11, � ����� 20.
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
            Console.WriteLine("����������, ������� ������ ���������:");
            firstValue = int.Parse(Console.ReadLine());
            Console.WriteLine("����������, ������� ����� ���������:");
            secondValue = int.Parse(Console.ReadLine());
            if (firstValue < secondValue)
            {
                Console.Write("׸���� ����� � ��������� ��������� = ");
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
                Console.Write("׸���� ����� � ��������� ��������� = ");
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
