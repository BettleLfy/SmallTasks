using System;

namespace ucheba2
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 312;
            int counter = 0;
            string binary = Convert.ToString(value, 2);
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    counter++;
                }

            }
            Console.WriteLine(counter);
        }
    }
}
