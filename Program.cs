using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Linq;

namespace solo_project
{
    public class Players
    {
        public string Name { get; set; }
        public int Lv { get; set; }
        public string Jobs { get; set; }

        public int Atk { get; set; }
        public int Def { get; set; }
        public int Hp { get; set; }

        public int Gold { get; set; }
        public Players(string name , int lv , string jobs , int atk , int def , int hp , int gold) 
        {
            Name = name;
            Lv = lv;
            Jobs = jobs;
            Atk = atk;
            Def = def;
            Hp = hp;
            Gold = gold;

        }
        
    }

    class Program        
    {
        
        static void Main(string[] args)
        {
            Players players = new Players("Yuun",01,"전사",10,5,100,150000);

            List<string> equiDefName = new List<string>();
            List<string> equiAtkName = new List<string>();
            List<int> equiAtk = new List<int>();
            List<int> equiDef = new List<int>();
            List<string> equiAtkInfo = new List<string>();
            List<string> equiDefInfo = new List<string>();

            string[] weapon = { "낡은 검" , "청동 도끼" , "스파르타의 창" , "최종 창" };
            string[] armor = { "수련자 갑옷"  , "무쇠 갑옷"  , "스파르타 갑옷" , "최종 갑옷" , "마왕의갑옷"};

            string[] weaponInfo =
                {
                    "쉽게 볼수 있는 낡은 검 입니다." ,
                    "어디선가 사용됐던것 같은 도끼입니다." ,
                    "스파르타의 전사들이 사용했다는 전설의 창입니다.",
                    "엔딩에서나 어울리는 최고의 창입니다"
                };
            string[] armorInfo = 
                { 
                    "수련에 도움을 주는 갑옷입니다." ,
                    "무쇠로 만들어져 튼튼한 갑옷입니다." ,
                    "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.",
                    "엔딩에서나 어울리는 최고의 갑옷 입니다",
                    "마왕이 착용했다는 전설의 갑옷 입니다."
                };






            int[] weaponAtk = { 2, 5, 7, 30};
            int[] armorDef = { 5, 9, 15, 45 , 60};

            int[] weaponGold = {600,1500,2700,10000};
            int[] armorGold = {1000,1800,3500,10000,15000};

            int[] weaponHand = { 0, 0, 0, 0};
            int[] armorHand = { 0, 0, 0, 0, 0};

            int[] weaponEqui = { 0, 0, 0, 0};
            int[] armorEqui = { 0, 0, 0, 0, 0};

            int equArmor = 0;
            int equWeapon = 0;

            int equStatWeapon = 0;
            int equStatArmor = 0;

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
                        Console.WriteLine($"Lv. {players.Lv}");
                        Console.WriteLine($"직업 :  {players.Jobs}");
                        Console.WriteLine($"공격력 : {players.Atk + equStatWeapon} , +({equStatWeapon})");
                        Console.WriteLine($"방어력 : {players.Def + equStatArmor} , +({equStatArmor})");
                        Console.WriteLine($"체  력 : {players.Hp}");
                        Console.WriteLine($"골  드 : {players.Gold}");
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

                        for(int i = 0; i < equiDef.Count; i++)
                        {
                            Console.WriteLine($"-{i} {equiDefName[i]} | 방어력 +{equiDef[i]} | {equiDefInfo[i]}");
                        }
                        for (int i = 0; i < equiAtk.Count; i++)
                        {
                            Console.WriteLine($"-{i+equiDef.Count} {equiAtkName[i]} | 방어력 +{equiAtk[i]} | {equiAtkInfo[i]}");
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
                                int equiNum = 1;
                                int armorEN = 0;
                                int weaponEN = 0;

                                List<string> armorIndex = new List<string>();
                                List<string> weaponIndex = new List<string>();

                                Console.Clear();
                                Console.WriteLine("인벤토리 - 장착관리");
                                Console.WriteLine();
                                Console.WriteLine("보유중인 아이템을 관리할 수 있습니다.");
                                Console.WriteLine();
                                Console.WriteLine($"[아이템 목록]");
                                Console.WriteLine();
                                for (int i = 0; i < equiDef.Count; i++)
                                {
                                    Console.WriteLine($"-{i + 1} {equiDefName[i]} | 방어력 +{equiDef[i]} | {equiDefInfo[i]}");
                                }
                                for (int i = 0; i < equiAtk.Count; i++)
                                {
                                    Console.WriteLine($"-{i + equiDef.Count + 1} {equiAtkName[i]} | 공격력 +{equiAtk[i]} | {equiAtkInfo[i]}");
                                }
                                Console.WriteLine();
                                Console.WriteLine("0. 나가기");
                                Console.WriteLine("원하는 아이템의 번호 장착");
                                Console.WriteLine();
                                Console.WriteLine("원하시는 행동을 입력해주세요");
                                Console.Write(">>");
                                int equipment = int.Parse(Console.ReadLine());

                                if (equipment == 0)
                                {
                                    break;
                                }
                                else if (equipment > 0 && equipment <= equiDef.Count )
                                {
                                    int armorNum = equipment;
                                    if(equArmor == 0)
                                    {
                                        if (armorNum == 1) { equiDefName[armorNum - 1] = "[E] " + equiDefName[armorNum - 1]; }
                                        else { equiDefName[armorNum - 1] = "[E] " + equiDefName[armorNum - 1]; }
                                        equArmor = 1;
                                        equStatArmor += equiDef[armorNum - 1];
                                        continue;
                                    }
                                    else if (equArmor == 1)
                                    {
                                        string unEqui = "[E] ";
                                        for (int i = 0; i < equiDef.Count; i++)
                                        {
                                            if (equiDefName[i].Contains(unEqui))
                                            {
                                                equiDefName[i] = equiDefName[i].Replace(unEqui, "");
                                                equArmor = 0;
                                                equStatArmor -= equiDef[armorNum-1];
                                                break;
                                            }
                                        }
                                    }


                                }
                                else if (equipment > equiDef.Count  && equipment <= equiAtk.Count+equiDef.Count)
                                {
                                    int weaponNum = equipment - equiDef.Count;
                                    if (equWeapon == 0)
                                    {
                                        equiAtkName[weaponNum-1] = "[E] " + equiAtkName[weaponNum-1];
                                        equWeapon = 1;
                                        equStatWeapon += equiAtk[weaponNum-1];
                                        continue;
                                    }
                                    else if (equWeapon == 1)
                                    {
                                        string unEqui = "[E] ";
                                        for (int i = 0; i < equiAtk.Count; i++)
                                        {
                                            if (equiAtkName[i].Contains(unEqui))
                                            {
                                                equiAtkName[i] = equiAtkName[i].Replace(unEqui, "");
                                                equWeapon = 0;
                                                equStatWeapon -= equiAtk[weaponNum-1];
                                                break;
                                            }
                                        }
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("잘못된 입력.");
                                    continue;
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
                            Console.WriteLine($"{players.Gold} G");
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
                                    Console.WriteLine($"{i + armor.Length + 1}- {weapon[i]} | 공격력 +{weaponAtk[i]} | {weaponInfo[i]} | {weaponGold[i]} G");
                                }
                                else
                                {
                                    Console.WriteLine($"{i + armor.Length + 1}- {weapon[i]} | 공격력 +{weaponAtk[i]} | {weaponInfo[i]} | 구매완료");
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
                                    Console.WriteLine($"{players.Gold} G");
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
                                            Console.WriteLine($"{i + armor.Length + 1}- {weapon[i]} | 공격력 +{weaponAtk[i]} | {weaponInfo[i]} | {weaponGold[i]} G");
                                        }
                                        else 
                                        {
                                            Console.WriteLine($"{i + armor.Length + 1}- {weapon[i]} | 공격력 +{weaponAtk[i]} | {weaponInfo[i]} | 구매완료");
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
                                    else if (sell > 0 && sell < armor.Length + 1)
                                    {
                                        int armorNum = sell - 1;
                                        if (armorHand[armorNum] == 0) {
                                            if (armorGold[armorNum] <= players.Gold)
                                            {
                                                Console.WriteLine("구매완료");
                                                players.Gold = players.Gold - armorGold[armorNum];
                                                equiDefName.Add(armor[armorNum]);
                                                equiDef.Add(armorDef[armorNum]);
                                                equiDefInfo.Add(armorInfo[armorNum]);
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
                                        else if (armorGold[armorNum] > players.Gold)
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
                                    }//아머 구매
                                    else if (sell > armor.Length  && sell <= weapon.Length + armor.Length + 1)// 무기 구매 
                                    {
                                        int weaponNum = sell - (armor.Length+1);

                                        if (weaponGold[weaponNum] <= players.Gold)
                                        {
                                            if (weaponHand[weaponNum] == 0) 
                                            {
                                                Console.WriteLine("구매완료");
                                                players.Gold = players.Gold - weaponGold[weaponNum];
                                                weaponHand[weaponNum]++;
                                                equiAtkName.Add(weapon[weaponNum]);
                                                equiAtk.Add(weaponAtk[weaponNum]);
                                                equiAtkInfo.Add(weaponInfo[weaponNum]);
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
                                        else if (weaponGold[weaponNum] > players.Gold) 
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
