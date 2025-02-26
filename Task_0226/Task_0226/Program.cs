using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_0226
{
    class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            // 문제 1.
            //int[] num = new int[5];

            //num[0] = 10;
            //num[1] = 20;
            //num[2] = 30;
            //num[3] = 40;
            //num[4] = 50;

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write(num[i] + " ");
            //}

            // 문제 2.
            //int[] num = new int[5];
            //int sum = 0;

            //Console.WriteLine("숫자를 입력하세요 : ");

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"숫자 {i + 1} : ");
            //    num[i] = int.Parse(Console.ReadLine());

            //    sum += num[i];
            //}
            //Console.WriteLine("총합 : " + sum);

            // 문제 3.
            //int[] num = { 3, 8, 15, 6, 2 };
            //int max = 0;

            //foreach(int i in num)
            //{
            //    if(i > max)
            //    {
            //        max = i;
            //    }
            //}
            //Console.WriteLine("최대값 : " + max);

            // 문제 4.
            //int[] num = new int[10];

            //for(int i = 0; i < 10; i++)
            //{
            //    Console.Write($"{i + 1} ");
            //}

            // 문제 5.
            //int num = 1;
            //while (true)
            //{
            //    if(num % 2 == 0)
            //    {
            //        Console.Write($"{num} ");
            //    }
            //    num++;
            //    if (num == 11) break;
            //}

            // 문제 6.
            //int[] num = { 1, 2, 3, 4, 5 };
            //foreach(int i in num)
            //{
            //    Console.Write(i+ " ");
            //}

            // 문제 7.
            //int result = Add(3, 5);
            //Console.WriteLine("3과 5의 합은 : " +result);

            // 문제 8.
            //Console.Write("문자열 입력 : ");
            //string str = Console.ReadLine();
            //Console.WriteLine("문자열 길이 : "+str.Length);

            // 문제 9.
            Console.Write("첫 번째 정수 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("두 번째 정수 : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("세 번째 정수 : ");
            int num3 = int.Parse(Console.ReadLine());

            int max = FindMax(num1, num2, num3);

            Console.WriteLine($"입력한 세 수 중 가장 큰 값은 : {max}");
        }
        static int FindMax(int a, int b, int c)
        {
            int maxnum = c;
            if(a > b)
            {
                maxnum = a;
            }
            if (a > c)
            {
                maxnum = a;
            }
            if (b > c)
            {
                maxnum = b;
            }
            return maxnum;
        }
    }
}
