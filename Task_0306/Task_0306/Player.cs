using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_0306
{
    class Player
    {
        public INFO m_tInfo;
        public int Level { get; set; }
        public int Experience { get; set; }

        public void SetDamage(int iAttack) { m_tInfo.iHp -= iAttack; }

        public INFO GetInfo() { return m_tInfo; }

        public void SetHp(int iHp) { m_tInfo.iHp = iHp; }

        public void SelectJob()
        {
            m_tInfo = new INFO();
            Level = 1;
            Experience = 0;

            Console.WriteLine("직업을 선택하세요(1. 기사 2. 마법사 3. 도둑) : ");
            int iInput = int.Parse(Console.ReadLine());

            switch(iInput)
            {
                case 1:
                    m_tInfo.strName = "기사";
                    m_tInfo.iHp = 100;
                    m_tInfo.iAttack = 10;
                    break;
                case 2:
                    m_tInfo.strName = "마법사";
                    m_tInfo.iHp = 90;
                    m_tInfo.iAttack = 15;
                    break;
                case 3:
                    m_tInfo.strName = "도둑";
                    m_tInfo.iHp = 85;
                    m_tInfo.iAttack = 13;
                    break;
            }
        }

        public void Render()
        {
            Console.WriteLine("=============================");
            Console.WriteLine("직업 이름 : " + m_tInfo.strName);
            Console.WriteLine("레벨 : " + Level);
            Console.WriteLine("체력 : " + m_tInfo.iHp + "\t공격력 : " + m_tInfo.iAttack);
            Console.WriteLine("경험치 : " + Experience);
        }

        public void LevelUp(int Exp)
        {
            Experience += Exp;

            while(Experience >= 100)
            {
                Level++;
                Experience -= 100;
                Console.WriteLine($"{m_tInfo.strName}이(가) 레벨업 했습니다! 현재 레벨 : {Level}");

                Console.WriteLine("계속하려면 엔터키를 누르세요...");
                Console.ReadLine();
            }
        }
        public Player() { }
        ~Player() { }
    }

    
}
