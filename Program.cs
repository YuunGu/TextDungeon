namespace solo_project
{


    class Program        
    {
        
        static void Main(string[] args)
        {
            int lv = 01;
            string jobs = "전사";
            int atk = 10;
            int def = 5;
            int hp = 10;
            int gold = 15000;

            List<int> equi = new List<int>();

            string[] weapon = { "낡은 검" , "청동 도끼" , "스파르타의 창" };
            string[] armor = { "수련자 갑옷"  , "무쇠 갑옷"  , "스파르타 갑옷" };

            string[] weaponInfo = 
                { 
                    "쉽게 볼수 있는 낡은 검 입니다." ,
                    "어디선가 사용됐던것 같은 도끼입니다." ,
                    "스파르타의 전사들이 사용했다는 전설의 창입니다."
                };
            string[] armorInfo = 
                { 
                    "수련에 도움을 주는 갑옷입니다." ,
                    "무쇠로 만들어져 튼튼한 갑옷입니다." ,
                    "스파르타의 전사들이 사용했다는 전설의 갑옷입니다."
                };






            int[] weaponAtk = { 2, 5, 7 };
            int[] armorDef = { 5, 9, 15 };

            int[] weaponGold = {600,1500,2700};
            int[] armorGold = {1000,1800,3500 };

            int[] weaponHand = { 0, 0, 0 };
            int[] armorHand = { 0, 0, 0 };

            while (true)
            {

                Console.Clear();
                Console.WriteLine("이곳은 스파르타 마을 여기 오신 여러분 환영합니다!");
                Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
                Console.WriteLine();
                Console.WriteLine("1. 상태 보기");
                Console.WriteLine("2. 인벤 토리");
                Console.WriteLine("3. 상     점");
                Console.WriteLine();
                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.Write(">>");
                String userAct = Console.ReadLine();

                if (userAct == "1")
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("상태 보기");
                        Console.WriteLine();
                        Console.WriteLine("캐릭터의 정보가 표시됩니다.");
                        Console.WriteLine();
                        Console.WriteLine($"Lv. {lv}");
                        Console.WriteLine($"직업 :  ( {jobs} )");
                        Console.WriteLine($"공격력 : {atk}");
                        Console.WriteLine($"방어력 : {def}");
                        Console.WriteLine($"체  력 : {hp}");
                        Console.WriteLine($"골  드 : {gold}");
                        Console.WriteLine();
                        Console.WriteLine("0. 나가기");
                        Console.WriteLine();
                        Console.WriteLine("원하시는 행동을 입력해주세요");
                        Console.Write(">>");
                        String backMenu = Console.ReadLine();
                        if (backMenu == "0")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("잘못된입력!");
                            continue;
                        }
                    }
                } // My Info
                else if (userAct == "2")
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("인벤토리");
                        Console.WriteLine();
                        Console.WriteLine("보유중인 아이템을 관리할 수 있습니다.");
                        Console.WriteLine();
                        Console.WriteLine($"[아이템 목록]");
                        for (int i = 0; i < armor.Length; i++)
                                    {
                                        if (armorHand[i] == 1)
                                        {
                                            Console.WriteLine($"- {armor[i]} | 방어력 +{armorDef[i]} | {armorInfo[i]} ");
                                        }
                                        
                                    }
                                    for (int i = 0; i < weapon.Length; i++)
                                    {
                                        if (weaponHand[i] == 1)
                                        {
                                            Console.WriteLine($"- {weapon[i]} | 공격력 +{weaponAtk[i]} | {weaponInfo[i]}");
                                        }
                                        
                                    }
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("1. 장착 관리");
                        Console.WriteLine("0. 나가기");
                        Console.WriteLine();
                        Console.WriteLine("원하시는 행동을 입력해주세요");
                        Console.Write(">>");
                        String backMenu = Console.ReadLine();
                        if (backMenu == "0")
                        {
                            break;
                        }
                        else if (backMenu == "1")
                        {
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("인벤토리 - 장착관리");
                                Console.WriteLine();
                                Console.WriteLine("보유중인 아이템을 관리할 수 있습니다.");
                                Console.WriteLine();
                                Console.WriteLine($"[아이템 목록]");
                                Console.WriteLine();

                                Console.WriteLine();
                                Console.WriteLine("0. 나가기");
                                Console.WriteLine();
                                Console.WriteLine("원하시는 행동을 입력해주세요");
                                Console.Write(">>");
                                String equipment = Console.ReadLine();

                                if (equipment == "0")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("잘못된 입력.");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("잘못된입력!");
                            continue;
                        }
                    }
                } // Inventory
                else if (userAct == "3")
                {
                    while (true)
                    {
                        {
                            Console.Clear();
                            Console.WriteLine("상점");
                            Console.WriteLine();
                            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
                            Console.WriteLine();
                            Console.WriteLine($"[보유 골드]");
                            Console.WriteLine($"{gold} G");
                            Console.WriteLine();
                            Console.WriteLine($"[아이템 목록]");
                            Console.WriteLine();
                            for (int i = 0; i < armor.Length; i++)
                            {
                                if (armorHand[i] == 0)
                                {
                                    Console.WriteLine($"{i + 1}- {armor[i]} | 방어력 +{armorDef[i]} | {armorInfo[i]} | {armorGold[i]} G");
                                }
                                else
                                {
                                    Console.WriteLine($"{i + 1}- {armor[i]} | 방어력 +{armorDef[i]} | {armorInfo[i]} | 구매완료");
                                }
                            }
                            for (int i = 0; i < weapon.Length; i++)
                            {
                                if (weaponHand[i] == 0)
                                {
                                    Console.WriteLine($"{i + 4}- {weapon[i]} | 공격력 +{weaponAtk[i]} | {weaponInfo[i]} | {weaponGold[i]} G");
                                }
                                else
                                {
                                    Console.WriteLine($"{i + 4}- {weapon[i]} | 공격력 +{weaponAtk[i]} | {weaponInfo[i]} | 구매완료");
                                }
                            }
                            Console.WriteLine();
                            Console.WriteLine("1. 아이템 구매");
                            Console.WriteLine();
                            Console.WriteLine("0. 나가기");
                            Console.WriteLine();
                            Console.WriteLine("원하시는 행동을 입력해주세요");
                            Console.Write(">>");
                            String backMenu = Console.ReadLine();
                            if (backMenu == "0")
                            {
                                break;
                            }
                            else if (backMenu == "1")
                            {
                                while (true)
                                {
                                    string anw = "";
                                    Console.WriteLine($"[아이템 목록]");
                                    Console.WriteLine();
                                    Console.WriteLine($"[보유 골드]");
                                    Console.WriteLine($"{gold} G");
                                    Console.WriteLine();
                                    for (int i = 0; i < armor.Length; i++)
                                    {
                                        if (armorHand[i] == 0)
                                        {
                                            Console.WriteLine($"{i + 1}- {armor[i]} | 방어력 +{armorDef[i]} | {armorInfo[i]} | {armorGold[i]} G");
                                        }
                                        else
                                        {   
                                            Console.WriteLine($"{i + 1}- {armor[i]} | 방어력 +{armorDef[i]} | {armorInfo[i]} | 구매완료");
                                        }
                                    }
                                    for (int i = 0; i < weapon.Length; i++)
                                    {
                                        if (weaponHand[i] == 0)
                                        {
                                            Console.WriteLine($"{i + 4}- {weapon[i]} | 공격력 +{weaponAtk[i]} | {weaponInfo[i]} | {weaponGold[i]} G");
                                        }
                                        else 
                                        {
                                            Console.WriteLine($"{i + 4}- {weapon[i]} | 공격력 +{weaponAtk[i]} | {weaponInfo[i]} | 구매완료");
                                        }
                                    }
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine("원하는 번호의 아이템을 골라주세요");
                                    Console.WriteLine();
                                    Console.WriteLine("0. 나가기");
                                    Console.WriteLine();
                                    Console.WriteLine("원하시는 행동을 입력해주세요");
                                    Console.Write(">>");
                                    int sell = int.Parse(Console.ReadLine());
                                    if (sell == 0)
                                    {
                                        break ;
                                    }
                                    else if (sell <= 3)
                                    {
                                        int armorNum = sell - 1;
                                        if (armorHand[armorNum] == 0) {
                                            if (armorGold[armorNum] < gold)
                                            {
                                                Console.WriteLine("구매완료");
                                                gold = gold - armorGold[armorNum];
                                                armorHand[armorNum] = 1;
                                                Console.WriteLine();
                                                Console.WriteLine("0. 다른물건구매");
                                                Console.WriteLine("1. 상점으로 돌아가기");
                                                Console.WriteLine();
                                                Console.WriteLine("원하시는 행동을 입력해주세요");
                                                Console.Write(">>");
                                                anw = Console.ReadLine();
                                                if (anw == "0")
                                                {
                                                    continue;
                                                }
                                                else if (anw == "1")
                                                {
                                                    break;
                                                    break;
                                                }
                                            }
                                            else if(armorHand[armorNum] == 1)
                                            {
                                                Console.WriteLine("이미 보유중입니다.");
                                                Console.WriteLine();
                                                Console.WriteLine("0. 다른물건구매");
                                                Console.WriteLine("1. 상점으로 돌아가기");
                                                Console.WriteLine();
                                                Console.WriteLine("원하시는 행동을 입력해주세요");
                                                Console.Write(">>");
                                                anw = Console.ReadLine();
                                                if (anw == "0")
                                                {
                                                    continue;
                                                }
                                                else if (anw == "1")
                                                {
                                                    break;
                                                    break;
                                                }
                                            }
                                        }
                                        else if (armorGold[armorNum] > gold)
                                        {
                                            Console.WriteLine("돈이 부족합니다");
                                            Console.WriteLine();
                                            Console.WriteLine("0. 다른물건보기");
                                            Console.WriteLine();
                                            Console.WriteLine("원하시는 행동을 입력해주세요");
                                            Console.Write(">>");
                                            anw = Console.ReadLine();
                                            if (anw == "0")
                                            {
                                                continue;
                                            }
                                            else
                                            {
                                                break;
                                                break;
                                            }
                                        }
                                    }
                                    else if (sell >= 4 && sell < 7) // 무기 구매
                                    {
                                        int weaponNum = sell - 4;

                                        if (weaponGold[weaponNum] < gold)
                                        {
                                            if (weaponHand[weaponNum] == 0) 
                                            {
                                                Console.WriteLine("구매완료");
                                                gold = gold - weaponGold[weaponNum];
                                                weaponHand[weaponNum]++;
                                                Console.WriteLine();
                                                Console.WriteLine("0. 다른물건구매");
                                                Console.WriteLine("1. 상점으로 돌아가기");
                                                Console.WriteLine();
                                                Console.WriteLine("원하시는 행동을 입력해주세요");
                                                Console.Write(">>");
                                                anw = Console.ReadLine();
                                                if (anw == "0")
                                                {
                                                    continue;
                                                }
                                                else if (anw == "1")
                                                {
                                                    break;
                                                    break;
                                                }
                                            }else if(weaponHand[weaponNum] == 1)
                                            {
                                                Console.WriteLine("이미 보유중입니다.");
                                                Console.WriteLine();
                                                Console.WriteLine("0. 다른물건구매");
                                                Console.WriteLine("1. 상점으로 돌아가기");
                                                Console.WriteLine();
                                                Console.WriteLine("원하시는 행동을 입력해주세요");
                                                Console.Write(">>");
                                                anw = Console.ReadLine();
                                                if (anw == "0")
                                                {
                                                    continue;
                                                }
                                                else if (anw == "1")
                                                {
                                                    break;
                                                    break;
                                                }
                                            }
                                        }
                                        else if (weaponGold[weaponNum] > gold) 
                                        {
                                            Console.WriteLine("돈이 부족합니다");
                                            Console.WriteLine();
                                            Console.WriteLine("0. 다른물건보기");
                                            Console.WriteLine();
                                            Console.WriteLine("원하시는 행동을 입력해주세요");
                                            Console.Write(">>");
                                            anw = Console.ReadLine();
                                            if (anw == "0")
                                            {
                                                continue;
                                            }
                                            else
                                            {
                                                break;
                                                break;
                                            }

                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("잘못된입력!");
                                continue;
                            }

                        }
                    }
                } // Shop

            }
            


        }
    }
}
