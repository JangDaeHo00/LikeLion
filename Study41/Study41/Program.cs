using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study41
{
    // 부모클래스의 생성자 호출
    class Parent
    {
        public Parent(string message)
        {
            Console.WriteLine("부모생성자"+message);
        }
    }

    class Child : Parent
    {
        public Child():base("하하하하성공")   // 부모생성자 호출
        {
            Console.WriteLine("자식 생성자 호출");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Child chile = new Child();  // 0 객체 생성 시작


        }
    }
}
