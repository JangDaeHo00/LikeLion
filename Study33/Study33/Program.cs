using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study33
{
    class Player
    {
        protected string Name;  // protected 부모랑 자식 상속관계에서만 사용하고 싶을 때   
                                // 외부에서 쓸 수 없다.
        public Player()
        {
            Name = "플레이어";
            Console.WriteLine("생성자입니다.");
        }
        public void Show()
        {
            Console.WriteLine(Name);
        }
    }

    class Wizard : Player
    {
        public Wizard()
        {
            Name = "마법사";
            Console.WriteLine("자식 생성자입니다.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player();
            p.Show();

            Wizard w = new Wizard();    // 부모가 먼저 실행됨.
            w.Show();
            
        }
    }
}
