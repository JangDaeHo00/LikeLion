using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_0224
{
    class Program
    {
        static void Main(string[] args)
        {

            // 문제 1. 학점 평균 계산 프로그램
            Console.Write("국어 점수 : ");
            int Kor = int.Parse(Console.ReadLine());
            Console.Write("영어 점수 : ");
            int Eng = int.Parse(Console.ReadLine());
            Console.Write("수학 점수 : ");
            int Math = int.Parse(Console.ReadLine());

            int sum = Kor + Eng + Math;
            double average = (double)sum / 3;

            Console.WriteLine($"총점 : {sum}, 평균 : {average:F2}");


            // 문제 2. 비트 반전 (~) 연산자 활용 프로그램
            Console.Write("정수를 입력하세요 : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"원래의 값 : {a}, 비트 반전 후의 값 : {~a}");

        }
    }
}
