using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] walk)
        {
            string[] puti = { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" };
            int y = 0;
            int x = 0;
            for (int i = 0; i<puti.Length; i++)
            {
                switch (puti[i])
                {
                    case "n":
                        y++;
                        break;
                    case "s":
                        y--;
                        break;
                    case "w":
                        x++;
                        break;
                    case "e":
                        x--;
                        break;
                }
            }
            if (puti.Length != 10)
            {
                Console.WriteLine(false);
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
