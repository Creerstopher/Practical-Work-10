using System;

namespace _10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n, m");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int[,] arr = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = rnd.Next(0, 6);
                    Console.Write("\t" + arr[i, j]);
                }
                if (i == i)
                {
                    Console.WriteLine("\n"); 
                }
            }
            Console.WriteLine();
            int e = 0;
            for (int i = 0; i < n; i++)
            {
                int k = 0;
                for (int j = 0; j < m; j++)
                {
                    if(arr[i, j] != 0)
                    {
                        k = k + 1;
                    }
                    else
                    {
                        break;
                    }
                    if (k == m)
                    {
                        e = e + 1;
                    }
                }
            }
            Console.WriteLine(e);
            int[] b = new int[n * m];
            int c = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    b[c] = arr[i, j];
                    c = c + 1;
                }
            }
            Array.Sort(b);
            for (int i = b.Length - 1; i > 0; i--)
            {
                if (b[i] == b[i - 1])
                {
                    Console.WriteLine(b[i]);
                    break;
                }
            }
        }
    }
}
