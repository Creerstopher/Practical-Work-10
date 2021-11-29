using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("r: ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("h: ");
            int h = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int[,] mas1 = new int[n, m];
            int[,] mas2 = new int[r, h];
            int[,] sum = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int e = 0; e < m; e++)
                {
                    mas1[i, e] = rnd.Next(0, 6);
                    Console.Write("\t" + mas1[i, e]);
                }
                if (i == i) Console.WriteLine("\n");
            }
            Console.WriteLine("\n\n\n");
            for (int i = 0; i < n; i++)
            {
                for (int e = 0; e < m; e++)
                {
                    mas2[i, e] = rnd.Next(0, 6);
                    Console.Write("\t" + mas2[i, e]);
                }
                if (i == i) Console.WriteLine("\n");
            }
            int[,] rmas = new int[mas1.GetLength(0), mas1.GetLength(1)];
            for (int i = 0; i < mas1.GetLength(0); i++)
            {
                for (int j = 0; j < mas2.GetLength(1); j++)
                {
                    for (int k = 0; k < mas2.GetLength(0); k++)
                    {
                        rmas[i, j] += mas1[i, k] * mas2[k, j];
                    }
                }
            }
            Console.WriteLine("\n\n\n");
            for (int i = 0; i < n; i++)
            {
                for (int e = 0; e < m; e++)
                {
                    Console.Write("\t" + rmas[i, e]);
                }
                if (i == i) Console.WriteLine("\n");
            }
        }
    }
}
