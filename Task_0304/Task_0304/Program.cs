using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_0304
{
    public class Warrior
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Strength { get; set; }

        public Warrior(string name, int score, int strength)
        {
            Name = name;
            Score = score;
            Strength = strength;
        }

        public void WarriorInfo()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Score : {Score}");
            Console.WriteLine($"Strength : {Strength}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 문제 1.
            //Warrior warrior = new Warrior("전사", 100, 50);
            //warrior.WarriorInfo();

            // 문제 2.
            //Console.Write("정수를 입력하세요 : ");
            //string input = Console.ReadLine();

            //try
            //{
            //    int number = int.Parse(input);
            //    Console.WriteLine($"입력한 숫자는 : {number}");
            //}
            //catch
            //{
            //    Console.WriteLine("올바른 숫자를 입력하세요!");
            //}

            // 문제 3.
            //List<string> fruits = new List<string>();
            //fruits.Add("사과");
            //fruits.Add("바나나");
            //fruits.Add("포도");

            //Console.WriteLine("List 내용 : ");
            //foreach(var fruit in fruits)
            //{
            //    Console.WriteLine(fruit);
            //}

            //Queue<string> works = new Queue<string>();
            //works.Enqueue("첫 번째 작업");
            //works.Enqueue("두 번째 작업");
            //works.Enqueue("세 번째 작업");

            //Console.WriteLine("Queue 내용 : ");
            //while(works.Count > 0)
            //{
            //    Console.WriteLine(works.Dequeue());
            //}

            //Stack<int> num = new Stack<int>();
            //num.Push(10);
            //num.Push(20);
            //num.Push(30);

            //Console.WriteLine("Stack 내용 : ");
            //while(num.Count > 0)
            //{
            //    Console.WriteLine(num.Pop());
            //}

            // 문제 4.
            //Console.Write("문자열을 입력하세요 : ");
            //string input = Console.ReadLine();
            //string upperString = input.ToUpper();
            //string replaceString = upperString.Replace("C#", "CSharp");

            //Console.WriteLine($"변경된 문자열 : {replaceString}");
            //Console.WriteLine($"문자열의 길이 : {replaceString.Length}");


            // 문제 5.
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var Num = numbers.Where(n => n % 2 == 0);

            //Console.WriteLine("짝수 : ");
            
            //foreach(var num in Num)
            //{
            //    Console.Write(num + " ");
            //}
            //int sum = numbers.Sum();
            //Console.WriteLine($"\n모든 숫자 합 : {sum}");








        }
    }
}
