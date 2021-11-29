using System;

namespace _10._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m:");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] mas = new int[n, m];

            int senx = 100;
            int indexcolumn = 0;
            int indexstrok = 0;


            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = rnd.Next(-2, 3);
                    Console.Write("\t" + mas[i, j]);
                }
                if (i == i) Console.WriteLine("\n");
            }

            for (int i = 0; i < n; i++)
            {
                int minstrok = mas[1, 1];
                for (int e = 0; e < m; e++)
                {
                    if (minstrok > mas[i, e])
                    {
                        minstrok = mas[i, e];
                        indexcolumn = e;
                    }
                }
                bool isTrue = false;
                int maxstolb = mas[0, 0];
                for (int j = 0; j < n; j++)
                {
                    if (minstrok < mas[j, indexcolumn])
                    {

                        isTrue = true;
                        break;
                    }
                    else
                    {
                        indexstrok = j;
                    }
                }
                if (isTrue == false) Console.WriteLine("Столбец{0};Строка{1}", indexcolumn + 1, indexstrok + 1);
            }
    }
}
