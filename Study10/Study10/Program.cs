﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study10
{
    class Program
    {
        static void Main(string[] args)
        {
            // 배열
            // 0부터 시작한다.


            /*int[] num = new int[3];     // 3개 메모리를 만들겠다.    // new가 새로운 메모리를 생성하여라 라는 말

            num[0] = 10;
            num[1] = 20;
            num[2] = 30;
            // 넘어가면 안된다 (3개의 박스를 생성했으므로)
*//*
            Console.WriteLine(num[0]);
            Console.WriteLine(num[1]);
            Console.WriteLine(num[2]);*//*

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(num[i]);
            }*/

            /*
            string[] fruits = { "사과", "바나나", "오랜지" };

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(fruits[i]);
            }*/


            // 3명의 학생
            // 국어, 영어, 수학 점수 입력 받기
            // 총점, 평균 출력
            /*
            int[] iKor = new int[3];
            int[] iEng = new int[3];
            int[] iMath = new int[3];

            int[] sum = new int[3];
            float[] aver = new float[3];

            // 학생입력받기
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("학생 성적입력하세요 : ");
                Console.Write("국어 : ");
                iKor[i] = int.Parse(Console.ReadLine());
                Console.Write("영어 : ");
                iEng[i] = int.Parse(Console.ReadLine());
                Console.Write("수학 : ");
                iMath[i] = int.Parse(Console.ReadLine());

                sum[i] = iKor[i] + iEng[i] + iMath[i];
                aver[i] = sum[i] / 3;
            }

            // 출력
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine((i+1)+"번 학생");
                Console.WriteLine($"국어 : {iKor[i]}, 영어 : {iEng[i]}, 수학 : {iMath[i]}");
                Console.WriteLine("총점 : " + sum[i]);
                Console.WriteLine("평균 : " + aver[i].ToString("F2"));
            }*/

            // 1차원 배열
            /* 
            int[] scores = new int[3];

             scores[0] = 90;
             scores[1] = 85;
             scores[2] = 88;

             for(int i = 0; i < scores.Length; i++)
             {
                 Console.WriteLine($"점수 {i + 1}:{scores[i]}");
             }*/

            /*
            double value = 123.456789;
            // 소수점 자릿수 설정하는 포맷
            Console.WriteLine(value.ToString("F2"));
            Console.WriteLine($"소수점 둘째자리 : {value:F2} ");
            Console.WriteLine(String.Format("소수점 둘째 자리 : {0:F2}", value));
            // 소수점 없이 정수 출력
            Console.WriteLine(value.ToString("F0"));*/

            // 천의 자리마다 , 출력 123,124,124.12
            //double value = 123124124.12323;
            //Console.WriteLine(value.ToString("N2"));

            // 2차원 배열 선언
            /*
             * 
            int[,] matrix = new int[2, 3] {{1,2,3 }, {4,5,6 }}; // 3개씩 두묶음

            for(int i = 0; i < 2; i++)
            {
                //Console.WriteLine("i = "+i);
                for(int j = 0; j < 3; j++)
                {
                    //Console.WriteLine("j = "+j);
                    Console.WriteLine($"{matrix[i, j]}");
                }
                Console.WriteLine();
            }*/

            // 같은데 풀어서 쓴 예시

            /* 
             int[][] matrix = new int[2][];

             matrix[0] = new int[3];
             matrix[1] = new int[3];

             // 값 입력

             matrix[0][0] = 1;
             matrix[0][1] = 2;
             matrix[0][2] = 3;

             matrix[1][0] = 4;
             matrix[1][1] = 5;
             matrix[1][2] = 6;

             // 출력
             for(int i = 0; i < matrix.Length; i++)      // 2
             {
                 for(int j = 0; j < matrix[i].Length; j++)       // 3
                 {
                     Console.Write(matrix[i][j] + " ");
                 }
                 Console.WriteLine();
             }*/

            // 6. 가변 가열
            /*
            Console.WriteLine("가변 배열");
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[] { 1, 2 };
            jaggedArray[1] = new int[] { 3, 4, 5 };
            jaggedArray[2] = new int[] { 6 };


            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"{jaggedArray[i][j]}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("var 키워드 사용");
            var numbers = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine($"배열 타입: {numbers.GetType()}");
*/
        }
    }
}
