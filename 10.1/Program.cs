using System;

namespace _10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n");
            int n = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int[,] arr = new int[n,n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());                    
                }
            }
            int S = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i >= j)
                    {
                        S = S + arr[i, j];
                    }                    
                }    
            }
            Console.WriteLine(S);
        } 
    }
}
