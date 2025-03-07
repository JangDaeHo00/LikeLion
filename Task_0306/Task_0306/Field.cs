using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_0306
{
    class Field
    {
        Player m_pPlayer = null;
        Monster m_pMonster = null;

        public void SetPlayer(ref Player pPlayer) { m_pPlayer = pPlayer; }

        public void Progress()
        {
            int iInput = 0;

            while(true)
            {
                Console.Clear();
                m_pPlayer.Render();
                DrawMap();

                iInput = int.Parse(Console.ReadLine());

                if (iInput == 4) break;

                if(iInput <= 3)
                {
                    CreateMonster(iInput);
                    Fight(iInput);
                }
            }
        }

        public void Create(string _strName, int _iHp, int _iAttack, out Monster pMonster)
        {
            pMonster = new Monster();
            INFO tMonster = new INFO();

            tMonster.strName = _strName;
            tMonster.iHp = _iHp;
            tMonster.iAttack = _iAttack;

            pMonster.SetMonster(tMonster);
        }

        public void CreateMonster(int input)
        {
            switch(input)
            {
                case 1:
                    Create("초보몹", 30, 3, out m_pMonster);    break;
                case 2:
                    Create("중수몹", 60, 6, out m_pMonster);    break;
                case 3:
                    Create("고수몹", 90, 9, out m_pMonster);    break;
            }
        }

        public void Fight(int mapType)
        {
            int iInput = 0;

            while(true)
            {
                Console.Clear();
                m_pPlayer.Render();
                m_pMonster.Render();

                Console.WriteLine("1. 공격 2. 도망 : ");
                iInput = int.Parse(Console.ReadLine());

                if(iInput == 1)
                {
                    m_pPlayer.SetDamage(m_pMonster.GetMonster().iAttack);
                    m_pMonster.SetDamage(m_pPlayer.GetInfo().iAttack);

                    if(m_pPlayer.GetInfo().iHp <= 0)
                    {
                        m_pPlayer.SetHp(100);   break;
                    }
                }
                if(iInput == 2 || m_pMonster.GetMonster().iHp <= 0)
                {
                    if(m_pMonster.GetMonster().iHp <= 0)
                    {
                        Console.WriteLine($"몬스터 {m_pMonster.GetMonster().strName}을(를) 처치했습니다!");

                        int expGained = 0;
                        switch(mapType)
                        {
                            case 1: expGained = 30; break;
                            case 2: expGained = 50; break;
                            case 3: expGained = 70; break;
                        }
                        m_pPlayer.LevelUp(expGained);
                    }

                    m_pMonster = null;  break;
                }
            }
        }

        private static void DrawMap()
        {
            Console.WriteLine("1. 초보맵");
            Console.WriteLine("2. 중수맵");
            Console.WriteLine("3. 고급맵");
            Console.WriteLine("================================");
            Console.WriteLine("맵을 선택하세요 : ");
        }

        public Field() { }
        ~Field() { }
    }
}
