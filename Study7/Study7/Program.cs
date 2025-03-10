﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study7
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 단항 연산자
            //int number = 5;
            //bool flag = true;

            //Console.WriteLine(+number); // 양수 출력 : 5
            //Console.WriteLine(-number); // 음수 출력 : -5

            //Console.WriteLine(!flag);       // 논리 부정 : false

            // ~ 비트 반전
            // 10   1010    
            //        0101          4바이트        0000 0000 0000 0000 0000 0000 0000 1010
            //                                           1111 1111 1111 1111 1111 1111 1111 0101

            //int num = 10;
            //int result = ~num;      // 모든 비트 반전 : 1111 0101 결과 음수로 판단(-) -11 나올 수 있다.

            //Console.WriteLine("원래 값 : " + num);
            //Console.WriteLine("~ 연산자 적용 후 : " + result);


            // 변환 연산자
            // 캐스팅
            //double pi = 3.14;
            //int integerPi = (int)pi;    // 실수형 -> 정수형으로 변환

            //Console.WriteLine(integerPi);   // 3


            //int iKor = 90;
            //int iEng = 75;
            //int iMath = 58;

            //int sum = 0;
            //float average = 0.0f;

            //sum = iKor + iEng + iMath;

            //average = (float)sum / 3;  //평균 정수형 -> 실수형 변환

            //Console.WriteLine("총점 : " + sum);
            //Console.WriteLine("평균 : " + average);


            // 산술 연산자
            //int a = 10, b = 3;

            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);
            //Console.WriteLine(a % b);


            // 문자열 연결 연산자
            //string firstName = "Alice";
            //string lastName = "Smith";

            //Console.WriteLine(firstName + " " + lastName);  //출력


            // 할당 연산자
            //int a = 10;
            //a += 5;     // a = a + 5;
            //Console.WriteLine(a);
            //a -= 5;     // a = a - 5;
            //Console.WriteLine(a);
            //a *= 5;     // a = a * 5;
            //Console.WriteLine(a);
            //a /= 5;     // a = a / 5;
            //Console.WriteLine(a);
            //a %= 5;     // a = a % 5;
            //Console.WriteLine(a);


            //증감 연산자
            //int b = 3;

            ////전위 ++b, 후위 b++

            ////Console.WriteLine("b의 값은 : " + (++b));  // 이 라인에서 +1을 해준다.
            ////Console.WriteLine("b의 값은 : " + (b++));    // b값을 +1 한다.
            ////Console.WriteLine("b의 값은 : " + (b));  // +1한 b의 값을 출력.

          
            //Console.WriteLine("b의 값은 : " + b);
            //Console.WriteLine("b의 값은 : " + (--b));  // 이 라인에서 -1을 해준다.
            //Console.WriteLine("b의 값은 : " + (b++));  // b값을 -1한다.
            //Console.WriteLine("b의 값은 : " + (b));    // -1한 b의 값을 출력.





        }
    }
}
