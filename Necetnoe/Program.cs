using System;

namespace Necetnoe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] seq = { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 };
            foreach (int maksimGandon in seq)
            {
                int yaFanatWot = 0;
                for (int i=0; i<seq.Length; i++)
                {
                    if (maksimGandon == seq[i])
                    {
                        yaFanatWot++;
                    }
                }
                if (yaFanatWot % 2 == 1) 
                {
                    Console.WriteLine(maksimGandon);
                    return;
                }
            }
        }
    }
}
