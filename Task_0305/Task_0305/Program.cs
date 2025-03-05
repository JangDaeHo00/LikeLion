using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_0305
{
    class Champion
    {
        public string Name;
        protected int Health;
        protected int Mana;

        public Champion()
        {
            Name = "Unknown";
            Health = 0;
            Mana = 0;
        }
        public virtual void BasicAttack()
        {
            Console.WriteLine($"{Name}이 기본 공격을 합니다.");
        }
        public virtual void Move()
        {
            Console.WriteLine($"{Name}이 이동합니다");
        }
        public virtual void Heal(Champion target)
        {
            Console.WriteLine($"{Name}는 회복할 수 없습니다.");
        }
        public virtual void shield()
        {
            Console.WriteLine($"{Name}는 보호막을 사용할 수 없습니다.");
        }
        public virtual void Skill()
        {
            Console.WriteLine($"{Name}이 스킬을 사용할 수 없습니다.");
        }
    }

    // Echo 챔피언
    class Echo : Champion
    {
        public Echo()
        {
            Name = "Echo";
            Health = 500;
            Mana = 100;
        }
        public override void BasicAttack()
        {
            Console.WriteLine("Echo가 기본 공격을 합니다!");
        }
        public override void Move()
        {
            Console.WriteLine("Echo가 이동합니다!");
        }
        public override void shield()
        {
            Console.WriteLine("Echo가 스킬을 적에게 맞추면 보호막을 사용합니다!");
        }
        public override void Skill()
        {
            Console.WriteLine("Echo가 시간을 되돌리는 궁극기를 사용합니다!");
        }
    }

    // Amvesa 챔피언
    class Ambesa : Champion
    {
        public Ambesa()
        {
            Name = "Ambesa";
            Health = 800;
            Mana = 75;
        }
        public override void BasicAttack()
        {
            Console.WriteLine("Ambesa가 기본 공격을 합니다!");
        }
        public override void Move()
        {
            Console.WriteLine("Ambesa가 이동합니다!");
        }
        public override void shield()
        {
            Console.WriteLine("Ambesa가 스킬을 적에게 맞추면 보호막을 사용합니다!");
        }
        public override void Skill()
        {
            Console.WriteLine("Ambesa가 한 명의 적을 공중에 띄우는 궁극기를 사용합니다!");
        }
    }

    // Malphite 챔피언
    class Malphite : Champion
    {
        public Malphite()
        {
            Name = "Malphite";
            Health = 1000;
            Mana = 60;
        }
        public override void BasicAttack()
        {
            Console.WriteLine("Malphite가 기본 공격을 합니다!");
        }
        public override void Move()
        {
            Console.WriteLine("Malphite가 이동합니다!");
        }
        public override void shield()
        {
            Console.WriteLine("Malphite가 패시브로 보호막을 사용합니다!");
        }
        public override void Skill()
        {
            Console.WriteLine("Malphite가 여러 명의 적을 띄우는 궁극기를 사용합니다!");
        }
    }

    // Vayne 챔피언
    class Vayne : Champion
    {
        public Vayne()
        {
            Name = "Vayne";
            Health = 400;
            Mana = 60;
        }
        public override void BasicAttack()
        {
            Console.WriteLine("Vayne가 기본 공격을 합니다!");
        }
        public override void Move()
        {
            Console.WriteLine("Vayne가 이동합니다!");
        }
        public override void Skill()
        {
            Console.WriteLine("Vayne가 은신하면서 공격력이 강해지는 궁극기를 사용합니다!");
        }
    }

    // Soraka 챔피언
    class Soraka : Champion
    {
        public Soraka()
        {
            Name = "Soraka";
            Health = 300;
            Mana = 150;
        }
        public override void BasicAttack()
        {
            Console.WriteLine("Soraka가 기본 공격을 합니다!");
        }
        public override void Move()
        {
            Console.WriteLine("Soraka가 이동합니다!");
        }
        public override void Heal(Champion target)
        {
            Console.WriteLine($"Soraka가 {target.Name}에게 스킬을 사용하면 체력을 회복시켜줍니다!");
        }
        public override void Skill()
        {
            Console.WriteLine("Echo가 시간을 되돌리는 궁극기를 사용합니다!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Champion> champions = new List<Champion>();

            champions.Add(new Echo());
            champions.Add(new Ambesa());
            champions.Add(new Malphite());
            champions.Add(new Vayne());
            champions.Add(new Soraka());

            // 모든 유닛을 순회하며 다형성 적용
            foreach(var champion in champions)
            {
                champion.Move();
                champion.BasicAttack();
                Console.WriteLine();
            }

            Soraka soraka = new Soraka();
            soraka.Heal(champions[3]);

            Ambesa ambesa = new Ambesa();
            ambesa.Skill();
            ambesa.shield();

            Echo echo = new Echo();
            echo.Skill();
            echo.Move();

            Vayne vayne = new Vayne();
            vayne.Skill();

            Malphite malphite = new Malphite();
            malphite.shield();

        }
    }
}
