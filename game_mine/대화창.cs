using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_mine
{

    static class 대화창
    {
        static String input;
        static char[] arrCh;
        static int a = 0;
        public static void answer(String _input)
        {
            Console.Clear();
            input = _input;
            char[] arrCh = input.ToCharArray();
            while (true)
            {

                if (a == arrCh.Length)
                {
                    a = 0;
                    break;
                }
                else
                {
                    Console.Write(arrCh[a]);
                    for (int i = 0; i < 10000000; i++)
                    {

                    }
                    a++;
                }
            }
        }
    }
}