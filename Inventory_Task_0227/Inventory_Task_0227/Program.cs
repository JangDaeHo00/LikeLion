using System;

namespace SimpleInventoryGame
{
    class Program
    {
        // 최대 아이템 개수 (배열 크기)
        const int MAX_ITEMS = 10;

        // 아이템 구조체
        struct Item
        {
            public string Name;      // 아이템 이름
            public int Count;        // 아이템 개수
            public int EffectValue;  // 아이템 효과 (체력 회복량 / 공격력 증가량)
            public string Type;      // 아이템 종류 (포션, 무기)
        }

        // 캐릭터 상태
        struct Character
        {
            public int Health;   // 체력
            public int Attack;   // 공격력
        }

        // 아이템 배열 (인벤토리)
        static Item[] inventory = new Item[MAX_ITEMS];

        // 캐릭터 상태 (초기값 설정)
        static Character player = new Character
        {
            Health = 100,
            Attack = 10
        };

        // 아이템 추가 함수
        static void AddItem(string name, int count, int effectValue, string type)
        {
            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (inventory[i].Name == name)   // 이미 있는 아이템이면 개수 증가
                {
                    inventory[i].Count += count;
                    return;
                }
            }

            // 빈 슬롯에 새로운 아이템 추가
            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (inventory[i].Name == null)
                {
                    inventory[i].Name = name;
                    inventory[i].Count = count;
                    inventory[i].EffectValue = effectValue;
                    inventory[i].Type = type;
                    return;
                }
            }

            Console.WriteLine("인벤토리가 가득 찼습니다.");
        }

        // 아이템 사용 함수
        static void UseItem(string name)
        {
            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (inventory[i].Name == name && inventory[i].Count > 0)
                {
                    if (inventory[i].Type == "Potion")
                    {
                        // 포션 사용 (체력 회복)
                        player.Health += inventory[i].EffectValue;
                        Console.WriteLine($"{name}을 사용하여 체력이 {inventory[i].EffectValue}만큼 회복되었습니다.");
                    }
                    else if (inventory[i].Type == "Weapon")
                    {
                        // 무기 사용 (공격력 증가)
                        player.Attack += inventory[i].EffectValue;
                        Console.WriteLine($"{name}을 사용하여 공격력이 {inventory[i].EffectValue}만큼 증가했습니다.");
                    }

                    inventory[i].Count--;
                    if (inventory[i].Count == 0)
                    {
                        inventory[i].Name = null;
                    }

                    return;
                }
            }

            Console.WriteLine("아이템을 찾을 수 없습니다.");
        }

        // 인벤토리 출력 함수
        static void ShowInventory()
        {
            Console.WriteLine("현재 인벤토리: ");
            bool isEmpty = true;

            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (inventory[i].Name != null)
                {
                    Console.WriteLine($"{inventory[i].Name} (x{inventory[i].Count}) - 효과: {inventory[i].EffectValue} ({inventory[i].Type})");
                    isEmpty = false;
                }
            }

            if (isEmpty)
            {
                Console.WriteLine("인벤토리가 비어 있습니다.");
            }
        }

        // 캐릭터 상태 출력 함수
        static void ShowCharacterStatus()
        {
            Console.WriteLine("캐릭터 상태");
            Console.WriteLine($"체력: {player.Health}");
            Console.WriteLine($"공격력: {player.Attack}");
        }

        static void Main(string[] args)
        {
            // 아이템 추가 (포션과 무기)
            AddItem("체력포션", 5, 20, "Potion");  // 체력포션 (체력 20 회복)
            AddItem("검", 1, 10, "Weapon");       // 검 (공격력 10 증가)

            ShowInventory(); 

            
            Console.WriteLine("아이템 사용");
            UseItem("체력포션"); 
            ShowCharacterStatus(); 
            ShowInventory(); 

            UseItem("검"); 
            ShowCharacterStatus(); 
            ShowInventory(); 

            
            Console.WriteLine("아이템 사용 후");
            ShowCharacterStatus();
            ShowInventory();
        }
    }
}
