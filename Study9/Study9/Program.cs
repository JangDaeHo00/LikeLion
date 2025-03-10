﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Study9
{
    class Program
    {
        static void Main(string[] args)
        {
            // switch 문
            /*Console.Write("숫자를 입력하세요 : ");
            int day = int.Parse(Console.ReadLine());

            switch(day)
            {
                case 1:
                    Console.WriteLine("월요일");
                    break;
                case 2:
                    Console.WriteLine("화요일");
                    break;
                case 3:
                    Console.WriteLine("수요일");
                    break;
                case 4:
                    Console.WriteLine("목요일");
                    break;
                case 5:
                    Console.WriteLine("금요일");
                    break;
                default:
                    Console.WriteLine("주말입니다.");
                    break;
            }*/

            // 캐릭터를 선택하세요 (1. 검사, 2. 마법사, 3. 도적)
            // 스위치문을 사용해보자.
            // 1 
            // 검사
            // 공격력 100
            // 방어력 90

            // 마법사
            // 공격력 110
            // 방어력 80

            // 도적
            // 공격력 115
            // 방어력 70
            /*
            int cha = 0;
            Console.Write("캐릭터를 선택하세요 : ");
            cha = int.Parse(Console.ReadLine());

            switch(cha)
            {
                case 1:
                    Console.WriteLine("검사");
                    Console.WriteLine("공격력 100");
                    Console.WriteLine("방어력 90");
                    break;
                case 2:
                    Console.WriteLine("마법사");
                    Console.WriteLine("공격력 110");
                    Console.WriteLine("방어력 80");
                    break;
                case 3:
                    Console.WriteLine("도적");
                    Console.WriteLine("공격력 115");
                    Console.WriteLine("방어력 70");
                    break;
                default:
                    Console.WriteLine("캐릭터의 정보가 없습니다.");
                    break;
            }*/


            // 반복문
            // 초기화  /   조건문     /   증강식
            /*
            for(int i =1; i<=5; i++)
            {
                Console.WriteLine("숫자 : " + i); // = Console.WriteLine($"숫자 : {i}");
            }*/


            // 0부터 9까지 출력하기

            /*
            for(int i =1; i<=9; i++) // = for(int i = 1; i<10; i++)
            {
                Console.WriteLine("숫자 : " + i); // = Console.WriteLine(i);
            }*/


            // 1부터 10까지의 합 구하기
            /*
            int sum = 0;
            for(int i = 1; i<=10; i++)
            {
                sum += i; // = sum = sum + i;
                Console.WriteLine($"sum : {sum} i : {i}");
            }
            Console.WriteLine("1부터 10까지의 합 : " + sum);*/


            // while 문

            /*
            int count = 1;  // 초기화
            
            while(count <= 5)   // 조건
            {
                Console.WriteLine("Count : " + count);

                count++;       // 증가, 감소

                if(count == 3)
                {
                    Console.WriteLine("3일 때 반복문 탈출");
                    break;
                }
            }

            Console.WriteLine("Count : " + count);*/


            // 랜덤
            /*
            Random rand = new Random();     // Random 객체를 생성한다.

            // 0 이상 10 미만의 랜덤 정수 생성
            int randomInRage = 0;
            for(int i = 0; i<100; i++)
            {
                randomInRage = rand.Next(5, 15);
                Console.WriteLine("5부터 14까지 : " + randomInRage);
            }*/


            // 대장장이 키우기
            // 도끼 등급 SSS    10%
            // 도끼 등급 SS      40%
            // 도끼 등급 S        50%

            /*
            Random rand = new Random();     // 랜덤값을 뽑는 문장

            int rnd = 0;

            for(int i =0; i<20; i++)
            {
                rnd = rand.Next(1, 101);        // 1~100

                if(rnd >= 1 && rnd <= 10)
                {
                    Console.WriteLine("도끼등급 SSS");
                }
                if (rnd >= 11 && rnd <= 40)
                {
                    Console.WriteLine("도끼등급 SS");
                }
                else
                {
                    Console.WriteLine("도끼등급 S");
                }
                Thread.Sleep(500);      // 0.5초 정도로 뽑아라.(1000이 1초)
            }
*/


            // do while
            // 1회 무조건 실행하고 while문과 같이 조건진행

            /*
            int x = 5;

            do
            {
                Console.WriteLine("최소 한번은 실행됩니다.");
                x--;
            } while (x > 0);*/

            // break 문
            // 반복문을 탈출할 수 있다.

            /*
            for(int i=1; i<=10; i++)
            {
                if (i == 5)
                { 
                    break;
                }

                Console.WriteLine(i);
            }*/

            // continue
            // 현재 반복을 건너뛰고 다음 반복으로 넘어간다.

            /* 
            for(int i = 1; i <= 10; i++)
             {
                 if (i % 2 == 0)         // 니머지 구하는 거 %
                 { 
                     continue;           // 다시 바로 반복문으로 돌아간다. 
                 }

                 Console.WriteLine(i);   // 홀수만 출력
             }*/

            // goto

           /* 
           int n = 1;

        start:

            if(n <= 5)
            {
                Console.WriteLine(n);
                n++;

                goto start;     // 레이블로 이동
            }
*/









        }
    }
}
