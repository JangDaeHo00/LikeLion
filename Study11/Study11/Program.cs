using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Study11
{
    class Program
    {
        // 메모리 영역
        // 스택 (stack) -> int a 같은 거
        // 힙   (heap) -> new로 할당하는 부분
        // 정적메모리 (static memory)

        //static int count = 0;   // 정적 메모리에 저장됨
        // 프로그램 종료전까지 유지됨
        // int count = 0; X => 다른 공간에 있어서 되지 않는다.

        // 1단계 함수
        // 반환형 함수 이름 (매개변수)
        //{
        //}

        // 1단계 기본형 (큰 박스라고 생각하면 된다.)
        /*static void Loading()
        {
            Console.WriteLine("로딩중.");
            Thread.Sleep(1000);
            Console.WriteLine("로딩중..");
            Thread.Sleep(1000);
            Console.WriteLine("로딩중...");
            Thread.Sleep(1000);
        }*/

        // 2단계
        // 입력
        static void AttackFunction(int Attack)
        {
            Console.WriteLine("공격력은 : " + Attack);
        }

        // 3단계
        // 출력
        static int BaseAttack()
        {
            // 기본 공격력 10
            int attack = 10;

            return attack;  // 출력
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            //count++;
            //Console.WriteLine(count);

            //Loading();
            //Console.WriteLine("메인화면");

            /*Loading();

            Console.WriteLine("게임이 시작됩니다. ");
            Console.ReadLine();
*/

            //int Attack = 0;
            //int bAttack = 0;
            //Console.Write("캐릭터의 공격력을 입력 : ");
            //Attack = int.Parse(Console.ReadLine());

            //// 기본 공격력
            //bAttack = BaseAttack();

            //AttackFunction(bAttack + Attack);

            // 두 수를 더하는 함수를 만들어서 오류를 해결하세요.
            //int result = Add(10, 20);
            //Console.WriteLine($"10 + 20 = {result}");

            //string[] fruits = { "사과", "바나나", "체리" };

            //// 반복문
            //foreach(string fruit in fruits)
            //{
            //    Console.WriteLine(fruit);
            //}


        }
    }
}
