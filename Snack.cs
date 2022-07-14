using System;
using System.Collections.Generic;

namespace Spielfeld
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] spielfeld = new int[,] { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
            int x = 0;
            int y = 0;
            int count = 0;
            Random rnd = new Random();
            int x1 = 3;
            int y1 = 3;
            int snack = 2;
            spielfeld[x, y] = 1;
            spielfeld[x1, y1] = snack;
            while (true)
            {                               
                if (spielfeld[x, y] == spielfeld[x1, y1])
                {
                    if (snack == 10)
                    { Console.WriteLine($"\nWin with {count} moves"); Console.ReadKey(); break; }
                    else
                    {
                        spielfeld[x1, y1] = 1;
                        x1 = rnd.Next(0, 5);
                        y1 = rnd.Next(0, 5);
                        spielfeld[x1, y1] = snack;                                                                   
                    }
                    snack++;
                }
                Console.Clear();
                for (int i = 0; i <= 4; i++)
                {
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write(spielfeld[i, j] + "  ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("a=left\nd=right\nw=up\ns=down\n");
                char c = Console.ReadKey().KeyChar;
                Console.Beep();
                count++;
                if (c == 'a')
                {
                    if (y == 0)
                    {
                        spielfeld[x, y] = 0;
                        spielfeld[x, 4] = 1;
                        y = 4;
                    }
                    else
                    {
                        spielfeld[x, y] = 0;
                        y--;
                        spielfeld[x, y] = 1;
                    }
                }
                else if (c == 'd')
                {
                    if (y == 4)
                    {
                        spielfeld[x, y] = 0;
                        spielfeld[x, 0] = 1;
                        y = 0;
                    }
                    else
                    {
                        spielfeld[x, y] = 0;
                        y++;
                        spielfeld[x, y] = 1;
                    }

                }
                else if (c == 'w')
                {
                    if (x == 0)
                    {
                        spielfeld[x, y] = 0;
                        spielfeld[4, y] = 1;
                        x = 4;
                    }
                    else
                    {
                        spielfeld[x, y] = 0;
                        x--;
                        spielfeld[x, y] = 1;
                    }
                }
                else if (c == 's')
                {
                    if (x == 4)
                    {
                        spielfeld[x, y] = 0;
                        spielfeld[0, y] = 1;
                        x = 0;
                    }
                    else
                    {
                        spielfeld[x, y] = 0;
                        x++;
                        spielfeld[x, y] = 1;
                    }
                }
            }
        }
    }
}
