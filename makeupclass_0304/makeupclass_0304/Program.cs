using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 프로그램을 사용하겠다.
namespace makeupclass_0304
{
    class Program
    {
        static void Main(string[] args)
        {
            // int, float, double, bool, char, string
            // 딱 떨어지는 숫자(정수형), 소수점(실수형), 좀 더긴 소수점,
            // 참/거짓, 낱말, 단어 혹은 문장(문자열)

            // if문 -> 만약
            // if(조건이 성립) 실행
            // else(위 조건이 실행하지 않으면) 실행

            //int hp = 50;

            //if (hp <= 0) Console.WriteLine("Game Over");
            //else
            //{

            //}   // 계속 진행

            // if문을 제일 많이 쓴다.

            // 예제 문제) 플레이어 점수가 100점 이하면 "레벨업" 아니면 "노력필요" 출력

            //Console.Write("점수를 입력하세요 : ");
            //int score = int.Parse(Console.ReadLine());

            //if(score >= 100)
            //{
            //    Console.WriteLine("레벨업");
            //}
            //else
            //{
            //    Console.WriteLine("노력필요");
            //}

            // 나이가 13세 미만이면 "어린이" 출력, 13세 이상이고, 19세 이하면 "청소년"
            // 그외 "성인"을 출력하세요
            // 조건 3개!
            // F11번 누르면 코드가 진행되는 순서를 알 수 있다.

            //Console.Write("나이를 입력하세요 : ");
            //int age = int.Parse(Console.ReadLine());

            //if (age < 13)
            //{
            //    Console.WriteLine("어린이");
            //}
            //else if (age >= 13 && age <= 19)
            //{
            //    Console.WriteLine("청소년");
            //}
            //else
            //{
            //    Console.WriteLine("성인");
            //}


            // if문이랑 비슷한 거
            // switch문
            // 

            //string day = "목";

            //switch(day)
            //{
            //    case "월":
            //    case "화":
            //    case "수":
            //    case "목":
            //    case "금":
            //        Console.WriteLine("평일입니다.");
            //        break;
            //    case "토":
            //    case "일":
            //        Console.WriteLine("주말입니다.");
            //        break;
            //    default:
            //        Console.WriteLine("????");
            //        break;
            //}

            // 예제 문제) 점수등급 (A, B, C, D)에 따라 메세지를 출력하세요.
            // A = 최고, B = 좋음, C = 보통, D = 탈락

            //Console.Write("점수등급을 입력하세요 : ");
            //string score = Console.ReadLine();

            //switch(score)
            //{
            //    case "A":
            //        Console.WriteLine("최고");
            //        break;
            //    case "B":
            //        Console.WriteLine("좋음");
            //        break;
            //    case "C":
            //        Console.WriteLine("보통");
            //        break;
            //    default:
            //        Console.WriteLine("탈락");
            //        break;
            //}

            // 12월 ~ 2월까지 겨울
            // 3월 ~ 5월까지 봄
            // 6월 ~ 8월까지 여름
            // 9월 ~ 11월 가을
            // 다른 숫자가 입력되면 => 잘못 입력되었습니다.

            //Console.Write("월을 입력하세요 : ");
            //int month = int.Parse(Console.ReadLine());

            //switch(month)
            //{
            //    case 12: case 1: case 2: Console.WriteLine("겨울"); break;
            //    case 3: case 4: case 5: Console.WriteLine("봄"); break;
            //    case 6: case 7: case 8: Console.WriteLine("여름"); break;
            //    case 9: case 10: case 11: Console.WriteLine("가을"); break;
            //    default: Console.WriteLine("잘못 입력되었습니다."); break;
            //}

            // 반복문
            // for문 -> ~을 위한 -> 목적을 가지고, 어떤 대상에 대해
            // 어떤 특정 목적이나 대상을 정해놓고 그것을 위해 무언가를 수행하는 과정
            // 정해진 횟수나 특정 조건을 만족하는 범위를 대상을 반복하는 구조
            // for(초기화; 조건; 증감식)
            // 반복될 내용

            //for(int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"몬스터 소한 {i} 번째");
            //}

            // 1에서 10까지 숫자를 출력해보세요 for문 사용
            //for(int i = 0; i < 11; i++)
            //{
            //    Console.Write(i + 1);
            //}

            // 1에서 10까지 합을 구하세요
            //int sum = 0;
            //for(int i = 0; i < 10; i++)
            //{
            //    sum += i + 1;
            //}
            //Console.WriteLine(sum);


            // 숫자를 입력받아 입력받은 숫자의 구구단 단수를 출력하세요
            // 예 : 숫자 2를 입력하면 2 x 1 = 2... 2 x 9 = 18까지 출력하는 
            // 알고리즘을 만들어라.

            //Console.Write("단수를 입력하세요 : ");
            //int dan = int.Parse(Console.ReadLine());


            //for(int i = 1; i < 10; i++)
            //{
            //    Console.WriteLine($"{dan} x {i} = {dan * i}");
            //}

            // *
            // **
            // ***
            // ****

            //for(int i = 1; i < 5; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}




















        }
    }
}
