using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study8
{
    class Program
    {
        static void Main(string[] args)
        {
            // 두 값을 비교하여 관계를 평가한다.
            // == 같다    != 같지 않다    a < b   c > d   <=  =>

            //int x = 5, y = 10;

            //Console.WriteLine(x < y);   // true
            //Console.WriteLine(x == y);      // false
            //Console.WriteLine(x != y);      // true
            //Console.WriteLine(x > y);       // false
            //Console.WriteLine(x < y);       // true
            //Console.WriteLine(x >= y);      // false
            //Console.WriteLine(x <= y);      // true


            // 논리 연산자

            //bool a = true;
            //bool b = false;

            //Console.WriteLine(a && b);  
            //// AND연산자 : 둘 다 참이여야 한다. 1 : 1 = true : true
            //// 1 : 1 (T) 1 : 0 (F)   0 : 1 (F)   0 : 0 (F)

            //Console.WriteLine(a || b);
            ////OR :  1   :   1   T
            ////OR :  1   :   0   T
            ////OR :  0   :   1   T
            ////OR :  0   :   0   F

            //Console.WriteLine(!a);  // false
            ////Not
            ////!a

            //b = a;
            //Console.WriteLine(b);   //true

            //b = !a;
            //Console.WriteLine(b);   //false

            //비트 연산자
            //int x = 5;  // 0101
            //int y = 3;  // 0011
            //Console.WriteLine(x & y);   // AND : 1(0001), x랑 y랑 곱한다.
            //Console.WriteLine(x | y);   // OR : 7 (0111)
            //Console.WriteLine(x ^ y);   //XOR : 6 (0110)
            ////  0101
            ////  0011
            ////  0110    => 같은 거 더할 땐 0, 다른 거 더할 땐 1
            //Console.WriteLine(~x);      // NOT : -6


            // 시프트 연산자
            //int value = 4;  //0100

            //Console.WriteLine(value << 2);  // 왼쪽 이동 : 8 (1000)
            //Console.WriteLine(value >> 1);  // 오른쪽 이동 : 2 (0010)


            ////기타 연산자
            //int a = 10, b = 20;

            //int max;
            //max = (a > b) ? a : b;  // 삼항 연산자
            ////            f         t    f
            //Console.WriteLine(max);

            //max = (a < b) ? a : b;  // 삼항 연산자
            ////            t         t    f
            //Console.WriteLine(max);
            //// 삼항 연산자
            //// ( 비교 ) ? 참 : 거짓 ;


            //Console.Write("key = ");
            //int key = int.Parse(Console.ReadLine());
            //string str;
            //str = (key == 1) ? "문이 열렸습니다. " : "문을 못 열었습니다.";

            //Console.WriteLine(str);   


            //연산자 우선순위
            //int result = 10 + 2 * 5;    // 곱셈이 덧셈보다 우선
            //Console.WriteLine(result);

            //int adjustResult = (10 + 2) * 5;    // 괄호 우선순위 먼저 계산
            //Console.WriteLine(adjustResult);


            // 제어문
            /* 
             int score = 85;

             if (score >= 90)
             {
                 Console.WriteLine("A 학점");
             }
             else
             {
                 Console.WriteLine("B 학점");
             }*/


            /* 
             string GameID = "멋사검존";

             if(GameID == "멋사검존")
             {
                 Console.WriteLine("아이디가 일치합니다.");
             }
             else
             {
                 Console.WriteLine("아이디가 일치하지 않습니다.");
             }
 */

            /*
            string GameID = "멋사검존";

            if(string.Compare(GameID, "멋사검존") == 0)
            {
                Console.WriteLine("아이디가 일치합니다.");
            }
            else
            {
                Console.WriteLine("아이디가 일치하지 않습니다.");
            }
*/

            /*
            Console.Write("점수를 입력하세요 : ");
            int score = int.Parse(Console.ReadLine());

            if(score >= 90)
            {
                Console.WriteLine("A 학점");
            }
            else if(score >= 80)
            {
                Console.WriteLine("B 학점");
            }
            else if(score >= 70)
            {
                Console.WriteLine("C 학점");
            }
            else
            {
                Console.WriteLine("F 학점");
            }*/

            //1단계
            // 가지고 있는 소지금을 입력하세요 :
            // 0 ~ 100 무한의 대검 +1
            // 101 ~ 200 카타나 +2
            // 201 ~ 300 진은검 +3
            // 301 ~ 400 집판검 +4
            // 401 ~ 500 엑스칼리버 +5
            // 501 ~ 600 유령검 +6

            //2단계
            // 캐릭터 이름
            // 공격력 : 100 +1

            Console.Write("가지고 있는 소지금을 입력하세요 : ");
            string GameID = "멋사검존";
            string weapon;
            int coin = int.Parse(Console.ReadLine());
            int atk = 100;


            if (coin >= 0 && coin <= 100 )
            {
                Console.WriteLine("무한의 대검");
                atk += 1;
                weapon = "무한의 대검";
            }
            else if(coin >= 101 && coin <= 200)
            {
                Console.WriteLine("카타나");
                atk += 2;
                weapon = "카타나";
            }
            else if (coin >= 201 && coin <= 300)
            {
                Console.WriteLine("진은검");
                atk += 3;
                weapon = "진은검";
            }
            else if (coin >= 301 && coin <= 400)
            {
                Console.WriteLine("집판검");
                atk += 4;
                weapon = "집판검";
            }
            else if (coin >= 401 && coin <= 500)
            {
                Console.WriteLine("엑스칼리버");
                atk += 5;
                weapon = "엑스칼리버";
            }
            else if (coin >= 501 && coin <= 600)
            {
                Console.WriteLine("유령검");
                atk += 6;
                weapon = "유령검";
            }
            else
            {
                Console.WriteLine("전설의 검");
                weapon = "전설의 검";
            }

            Console.WriteLine("이름 " + GameID);
            Console.WriteLine("무기 이름 " + weapon);
            Console.WriteLine("공격력 " + atk);



        }
    }
}
