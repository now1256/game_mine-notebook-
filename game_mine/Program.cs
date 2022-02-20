using System;

namespace game_mine
{
    internal class Program
    {
        class select : mainspace
        {
            public select(int _number) : base(_number)
            {

            }
        }
        class mainspace
        {
            String[] select;
            public int index;
            public int number;
            public mainspace(int _number)
            {
                select = new String[_number];
                number = _number;
                index = 0;
            }
            
            public void Render()  //로직 다시 따야할듯 1번 누르면 다음 화면으로 넘어가야함 
            {
                Console.Clear();
             for(int i=0; i<number; i++)
                {
                    select[i] = "▷";
                    if (index == i)
                    {
                        select[i] = "▶";
                    }
                }
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("연애 시뮬레이터에 오신것을 환영합니다 ");
                Console.WriteLine("아래의 캐릭터를 선택해서 플레이 하실 수 있습니다 ");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine(select[0] + "규영");
                Console.WriteLine("");
                Console.WriteLine(select[1] + "예건");
                Console.WriteLine("");
                Console.WriteLine(select[2] + "영서");
                Console.WriteLine("");
                Console.WriteLine("------------------------------------------------------");
            }
        }
        static class 예건
        {
            public static void Render()
            {
                Console.WriteLine("허예건은 이미 충분히 많은 여자를 사귀어봤습니다. 당신이 고르기전에 허예건은 이미 연애중입니다");
            }
        }
        static class choice
        {
            public static void Render()
            {
                Console.Clear();
                Console.WriteLine("----------------------------------");
                Console.WriteLine("이름");
                Console.WriteLine("상태");
                Console.WriteLine("상점");
            }
            class move
            {
                // 풀고가야할 숙제 다른클래스에서 정의된 메서드 사용방법 프로퍼티 사용법
                public void moveup(mainspace _index)
                {
                    if (_index.index == 0)
                    {
                        return;
                    }
                    else
                    {
                        _index.index = _index.index - 1;
                    }
                }
                public void movedown(mainspace _index)
                {
                    if (_index.number-1 <=_index.index)
                    {
                        return;
                    }
                    else
                    {
                        _index.index = _index.index + 1;
                    }
                }

            }
            class Save
            {

            }
            class Load
            {

            }
            class background
            {
                int day;  //날짜 개념 
                int date; // 아침 낮 밤 
            }
            class chr
            {
                int money;

            }
            class shop
            {
                int[] item;
                shop(int _number)
                {
                    item = new int[_number];
                    for (int i = 0; i < item.Length; i++)
                    {
                        item[i] = i;
                    }
                }
            }
        


                static void Main(string[] args)
                {

                    mainspace m = new mainspace(3);
                    select s = new select(4);
                    move move = new move();
                    
                    while (true)
                    {
                   
                    m.Render();
                     ConsoleKey cki = Console.ReadKey().Key;
                        switch (cki)
                        {
                            case ConsoleKey.UpArrow:
                                move.moveup(m);
                                break;
                            case ConsoleKey.DownArrow:
                                move.movedown(m);
                                break;
                        }
                        if (cki == ConsoleKey.Enter && m.index == 0)
                        {
                        //    choice.Render(); // s.Render();
                            
                        대화창.answer("이번생엔진짜여자친구를사귈수없는건가... 왜내가항상좋아했던,,여자들은나를안좋아하는거지");
                        대화창.answer("그의나이 51세아직여자친구가 없다");
                        Console.ReadKey();
                        }
                        else if (cki == ConsoleKey.Enter && m.index == 1)
                        {
                          예건.Render();
                          Console.ReadKey();
                        
                        }

                    }
                }

            }
        }
    }

