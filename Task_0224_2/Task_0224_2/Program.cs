using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_0224_2
{
    class Program
    {
        static void Main(string[] args)
        {

            // 문제 1.
            
            Console.Write("첫 번째 정수를 입력하세요 : ");
            int a= int.Parse(Console.ReadLine());

            Console.Write("두 번째 정수를 입력하세요 : ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("세 번째 정수를 입력하세요 : ");
            int c = int.Parse(Console.ReadLine());

            int max = a;

            if(b > max)
            {
                max = b;
            }
            else if(c>max)
            {
                max = c;
            }

            Console.WriteLine($"최대값 : " + max);

            // 문제 2
            
            Console.Write("학생의 점수를 입력하세요 : ");
            int point = int.Parse(Console.ReadLine());

            if(point >= 90)
            {
                Console.WriteLine("A 학점");
            }
            else if(point >= 80 && point < 90)
            {
                Console.WriteLine("B 학점");
            }
            else if (point >= 70 && point < 80)
            {
                Console.WriteLine("C 학점");
            }
            else if (point >= 60 && point < 70)
            {
                Console.WriteLine("D 학점");
            }
            else
            {
                Console.WriteLine("F 학점");
            }

            //문제 3
            Console.Write("첫 번째 숫자를 입력하세요 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("두 번째 숫자를 입력하세요 : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("두 개의 연산자를 입력하세요(+, -, *, /) : ");
            char opr = char.Parse(Console.ReadLine());

            double result = 0;

            if (opr == '+')
            {
                result = num1 + num2;
            }
            else if (opr == '-')
            {
                result = num1 - num2;
            }
            else if (opr == '*')
            {
                result = num1 * num2;
            }
            else
            {
                if (num2 == 0)
                {
                    Console.WriteLine("0으로 나눌 수 없습니다.");
                }
                result = num1 / num2;
            }

            Console.WriteLine("결과 : " + result);
        }
    }
}
