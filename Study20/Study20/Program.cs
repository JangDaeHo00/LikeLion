﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Study20
{
    // 마린 클래스를 만드세요.
    // 이름, 미네랄
    // 기본 생성자, 인자있는 생성자 
    class Marin
    {
        public string Name;
        public int Mineral;

        public Marin()
        {
            Name = "마린";
            Mineral = 50;
            
        }

        public Marin(string name, int mineral)
        {
            Name = name;
            Mineral = mineral;
           
        }
        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 미네랄 : {Mineral}");
        }
        public string name;
    }
        class SCV
        {
            public string Name;
            public int Mineral;

            public SCV()
            {
                Name = "SCV";
                Mineral = 50;
                
            }

            public SCV(string name, int mineral)
            {
                Name = name;
                Mineral = mineral;
                
            }
            public void ShowInfo()
            {
                Console.WriteLine($"이름 : {Name}, 미네랄 : {Mineral}");
            }
            public string name;

            //public string Name;
            //public int Age;

            //기본생성자 
            //클래스가 객체로 생성될때 자동으로 실행되는 특별한 메서드
            //클래스와 같은이름가지며, 반환형이 없다 (void도 사용하지않음)
            //객체를 만들때 필요한 초기값을 설정할대 사용많이한다.

            //public Person()
            //{
            //    Name = "이름 없음";
            //    Age = 0;
            //    Console.WriteLine("기본 생성자가 실행됨");
            //}

            //public Person(string name, int age)
            //{
            //    Name = name;
            //    Age = age;
            //    Console.WriteLine("매개변수 있는 생성자가 실행됨.");
            //}

            //public void ShowInfo()
            //{
            //    Console.WriteLine($"이름 : {Name}, 나이 : {Age}");
            //}
            //public string name;

            //public void ShowInfo()
            //{
            //    Console.WriteLine("이름 : " + name);
            //}
        }
    // 배럭 클래스를 만드시오
    // this 키워드를 이용해보자
    // this 자기자신을 가르킨다.
    class Barrack
    {
        public string Name;
        public int Mineral;

        public Barrack()
        {
            Name = "Barrack";
            Mineral = 150;
        }

        public Barrack(string Name, int Mineral)
        {
            this.Name = Name;
            this.Mineral = Mineral;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 미네랄 : {Mineral}");
        }
        public string name;
    }

    // 미네랄클래스를 만드시오
    // Mineral 1500 기본으로 주네요
    // 7개가 시작부터 있습니다.
    // 클래스화 해봅시다.
    class Mineral
    {
        public int MineralCount;

        public Mineral()
        {
            MineralCount = 1500;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"현재 미네랄 갯수 : {MineralCount}");
        }

    }

    class Game
    {
        public static int mineral;
        public static int gas;
        public static int charCount;

        public static void ShowInfo()
        {
            Console.WriteLine($"미네랄 {mineral} 가스 {gas} 인구수 {charCount}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //클래스
            //
            //Person p1 = new Person("철수", 25); //객체 생성  instance 
            //p1.ShowInfo();

            //Person p2 = new Person("영희", 30);
            //p2.ShowInfo();

            Game.mineral = 50;
            Game.gas = 0;
            Game.charCount = 4;
            Game.ShowInfo();
            //Game g = new Game();
            //g.ShowInfo();

            Marin marin = new Marin("불꽃 테란", 100);
            SCV scv = new SCV("열받은 SCV", 70);
            Barrack barrack = new Barrack();
            // 클래스의 배열
            Mineral[] mineral = new Mineral[7];

            // 각 배열에 new 객체화
            for(int i = 0; i < mineral.Length; i++)
            {
                mineral[i] = new Mineral();
                mineral[i].ShowInfo();
            }


            marin.ShowInfo();

            scv.ShowInfo();

            barrack.ShowInfo();
        }
    }
}