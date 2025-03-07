using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Task_0306
{
    class Monster
    {
        public INFO m_Monster;
        public void SetDamage(int iAttack) { m_Monster.iHp -= iAttack; }
        public void SetMonster(INFO tMonster) { m_Monster = tMonster; }
        public INFO GetMonster() { return m_Monster; }

        public void Render()
        {
            Console.WriteLine("=============================");
            Console.WriteLine("몬스터 이름 : " + m_Monster.strName);
            Console.WriteLine("체력 : " + m_Monster.iHp + "\t공격력 : " + m_Monster.iAttack);
        }

        public Monster() { }
        ~Monster() { }
    }
}
