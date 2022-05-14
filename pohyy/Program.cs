using System;
namespace pohyy
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] y = { 1, 1, 1 };
            Console.WriteLine(Tribonacci(y,10));
        }
        public static double[] Tribonacci(double[] signature, int n)
        {
            double[] result = new double[n];
            for (int i = 0; i < n; i++)
            {
                double x = 0;
                if (i > 2)
                {
                    x = result[i - 3] + result[i - 2] + result[i - 1];
                }
                else
                {
                    x = signature[i];
                }
                result[i] = x;
            }
            return result;
        }
    }
}

