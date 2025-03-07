using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study37
{
    class Person
    {
        public string name;     // 필드(변수, 데이터) : 클래스의 저장하는 맴버이다. 선언하면서 초기화도 가능
        public void SetName(string n)
        {
            name = n;
        }
        public string GetName()
        {
            return name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();    // 객체로 만들기 -> 인스턴스
            p.name = "Alice";           // 필드에 값넣기
            Console.WriteLine(p.name);
            
            p.SetName("Bob");
            Console.WriteLine(p.GetName());
        }
    }
}
