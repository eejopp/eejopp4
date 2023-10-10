using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sssssss
{
    class Program
    {
        static void Main()
        {
            int[] five= new int[] { 527, 497, 469, 443, 418, 395, 372, 344 };
            int[] four = new int[] { 333, 296, 279, 263, 248, 234, 221, 209 };
            int[] three = new int[] { 197, 186, 172, 166, 156, 148, 139, 131 };
            int[] two = new int[] { 124, 117, 110, 104, 98, 93, 88, 83 };
            int[] main1 = new int[] { };
            int[] main2 = new int[] { };
            main1 = five;
            main2 = four;
            while (true)
            {
                Console.Clear();
                Console.Write("F6 - Октава 2-3 \nF5 - Октава 4-5\nESC - Выход");
                ConsoleKeyInfo a = Console.ReadKey(true);

                if (a.Key == ConsoleKey.F5)
                {
                    Console.Clear();
                    Console.WriteLine("Выбрано: 4-5 октавы");
                    main1 = five;
                    main2 = four;
                }
                else if (a.Key == ConsoleKey.F6)
                {
                    Console.Clear();
                    Console.WriteLine("Выбрано: 2-3 октавы");
                    main1 = three;
                    main2 = two;
                }

                else if (a.Key == ConsoleKey.Escape)
                {
                    return;
                }
                else if (a.Key == ConsoleKey.Q)
                {
                    Console.Beep(main1[0], 400);
                }
                else if (a.Key == ConsoleKey.W)
                {
                    Console.Beep(main1[1], 400);
                }
                else if (a.Key == ConsoleKey.E)
                {
                    Console.Beep(main1[2], 400);
                }
                else if (a.Key == ConsoleKey.R)
                {
                    Console.Beep(main1[3], 400);
                }
                else if (a.Key == ConsoleKey.T)
                {
                    Console.Beep(main1[4], 400);
                }
                else if (a.Key == ConsoleKey.Y)
                {
                    Console.Beep(main1[5], 400);
                }
                else if (a.Key == ConsoleKey.U)
                {
                    Console.Beep(main1[6], 400);
                }
                else if (a.Key == ConsoleKey.I)
                {
                    Console.Beep(main1[7], 400);
                }
                else if (a.Key == ConsoleKey.A)
                {
                    Console.Beep(main1[0], 400);
                }
                else if (a.Key == ConsoleKey.S)
                {
                    Console.Beep(main1[1], 400);
                }
                else if (a.Key == ConsoleKey.D)
                {
                    Console.Beep(main1[2], 400);
                }
                else if (a.Key == ConsoleKey.F)
                {
                    Console.Beep(main1[3], 400);
                }
                else if (a.Key == ConsoleKey.G)
                {
                    Console.Beep(main1[4], 400);
                }
                else if (a.Key == ConsoleKey.H)
                {
                    Console.Beep(main1[5], 400);
                }
                else if (a.Key == ConsoleKey.J)
                {
                    Console.Beep(main1[6], 400);
                }
                else if (a.Key == ConsoleKey.K)
                {
                    Console.Beep(main1[7], 400);
                }
            }
        }
    }
}

