using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_0225
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            Console.Clear(); //화면 지우기
            Console.SetCursorPosition(0, 0);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(0, 1);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 2);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 3);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 4);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 4);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 5);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 6);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 7);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 8);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 9);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 10);
            Console.Write("┃                                지구를 지켜라                                 ┃");
            Console.SetCursorPosition(0, 11);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 12);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 13);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 14);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 15);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 16);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 17);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 18);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 19);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 20);
            Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");


            Thread.Sleep(3000);

            Random rand = new Random();

            int food = 500;
            int minerals = 250;
            int power = 100;
            int nowpower = 100;
            int alienpower = 0;
            bool isAlive = true;

            while(isAlive)
            {
                Console.Clear();
                alienpower = rand.Next(200, 501);
                Console.WriteLine($"현재 자원 : 식량 : {food}, 광물 : {minerals}, 전투력 : {power} ");
                Console.WriteLine($"현재 전투력 : {nowpower}");
                Console.WriteLine($"외계인의 전투력 : {alienpower}");
                Console.WriteLine("\n1. 자원 수집");
                Console.WriteLine("2. 전투력 상승");
                Console.WriteLine("3. 전투");
                Console.WriteLine("4. 게임 종료");
                Console.Write("입력 : ");

                int input = int.Parse(Console.ReadLine());

                if(input == 1)
                {
                    Console.Clear();
                    Console.WriteLine("자원을 수집합니다...");
                    Thread.Sleep(1000);

                    int foodPlus = rand.Next(100, 501);
                    int mineralsPlus = rand.Next(50, 251);

                    food += foodPlus;
                    minerals += mineralsPlus;
                    

                    Console.WriteLine($"식량 : {foodPlus}, 광물 {mineralsPlus}개를 수집하였습니다!!");
                    Thread.Sleep(1000);
                }
                else if(input == 2)
                {
                    Console.Clear();
                    Console.WriteLine("전투력을 상승시킵니다...");
                    Thread.Sleep(1000);

                    if(food >= 100 && minerals >= 50)
                    {
                        int powerplus = rand.Next(10, 31);
                        power += powerplus;
                        food -= 100;
                        minerals -= 50;

                        nowpower = power;
                        Console.WriteLine($"전투력을 강화하였습니다!! (+{powerplus})");
                        Console.WriteLine($"현재 전투력 : {nowpower}");
                    }
                    else
                    {
                        Console.WriteLine("자원 부족으로 전투력을 상승시킬 수 없습니다...");
                    }
                    Thread.Sleep(1000);
                }
                else if(input == 3)
                {
                    Console.Clear();
                    Console.WriteLine("외계인이 침략해 전투를 벌입니다...");
                    Thread.Sleep(1000);

                    if(power >= alienpower)
                    {
                        Console.WriteLine("외계인의 침략에 승리하였습니다!! 지구를 지켰습니다!!");
                        food += rand.Next(200, 501);
                        minerals += rand.Next(100, 301);
                    }
                    else
                    {
                        Console.WriteLine("외계인의 침략에 패배하였습니다... 전투력을 잃었습니다...");
                        power -= rand.Next(20, 61);
                    }
                    Thread.Sleep(1000);
                }
                else if(input == 4)
                {
                    Console.WriteLine("게임을 종료합니다.");
                    isAlive = false;
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 다시 선택하세요.");
                    Thread.Sleep(1000);
                }
                if(power <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("전투력을 모두 잃었습니다... 게임 오버!!");
                    isAlive = false;
                }

                if(food <= 0 || minerals <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("자원이 부족하여 지구를 방어할 수 없습니다... 게임 오버!!!");
                    isAlive = false;
                }
            }

        }
    }
}