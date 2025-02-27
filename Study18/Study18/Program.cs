using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study18
{
    //struct Rectangle
    //{
        //public int Width;
        //public int Height;

        //public int GetArea() => Width * Height;
    //}

    //struct Point
    //{
    //    public int x;
    //    public int y;
    //}

    struct Student
    {
        public string Name;
        public int Korean;
        public int English;
        public int Math;

        // 학생 정보를 출력하는 함수
        public void Print()
        {
            Console.WriteLine($"{Name}\t {Korean}\t {English}\t {Math}\t");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            // 구조체를 이용해서 
            // 학생 3명의 이름, 성적을 받고 국어, 영어, 수학
            // 출력하시오.
            // 이름    국어    영어    수학
            // 홍길동  100     80      70
            // 홍길란  90      10      20
            // 홍길순  20      55      70
            // 강사님께서 짜신 코드
            // 학생 배열 선언
            Student[] students = new Student[3];

            for(int i = 0; i < students.Length; i++)
            { 
                Console.WriteLine("학생 성적을 입력하세요.");
                Console.Write("학생 이름 : ");
                students[i].Name = Console.ReadLine();
                Console.Write("국어 : ");
                students[i].Korean = int.Parse(Console.ReadLine());
                Console.Write("영어 : ");
                students[i].English = int.Parse(Console.ReadLine());
                Console.Write("수학 : ");
                students[i].Math = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("이름    국어    영어    수학");
            foreach(Student std in students)
            {
                std.Print();
            }

            // 내가 짠 코드
            //Student[] students = new Student[3];

            //for(int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"학생 {i + 1}의 정보를 입력하세요.");
            //    Console.Write("이름 : ");
            //    students[i].Name = Console.ReadLine();

            //    Console.Write("국어 성적 : ");
            //    students[i].Korean = int.Parse(Console.ReadLine());
            //    Console.Write("영어 성적 : ");
            //    students[i].English = int.Parse(Console.ReadLine());
            //    Console.Write("수학 성적 : ");
            //    students[i].Math = int.Parse(Console.ReadLine());

            //    Console.WriteLine();
            //}

            //Console.WriteLine("이름    국어    영어    수학");
            //for(int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"{students[i].Name}    {students[i].Korean}    {students[i].English}    {students[i].Math}");
            //}

            //var rect = new Rectangle { Width = 5, Height = 4 };
            //Rectangle rect = new Rectangle();
            //rect.Width = 10;
            //rect.Height = 20;
            //Console.WriteLine($"Area : {rect.GetArea()}");

            //Point[] points = new Point[2];

            //points[0].x = 10;
            //points[0].y = 10;

            //points[1].x = 20;
            //points[1].y = 20;

            //foreach(var point in points)
            //{
            //    Console.WriteLine($"Point : ({point.x}, {point.y})");
            //}


        }
    }
}
