//������������ ������ ������������ �����. ����� ����� ������������ ������ ������ �������� ��� ������ ����. 
//��������, ���� ������������ ��� ���� � �����, ��� ��������, ��� ����� �������� ������� ������ � ������ �����. 
//����� 723895 ������ ������������ � 523897. ���� ������������ ��� �� ������������ �����, ����� ������� ��������� �� ������.
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
            Console.WriteLine("������� ������������ �����:");
            string numStr = Console.ReadLine();

            int numInt = Convert.ToInt32(numStr);
            if (numInt > 999999 || numInt < 100000) Console.WriteLine("������. ������� ������������ �����:");

            Console.WriteLine("����� ����� �������� �������:");
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
