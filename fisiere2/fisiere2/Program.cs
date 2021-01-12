using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fisiere2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Console.Write("Introduceti liniile matricii n = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti coloanele matricii m = ");
            m = int.Parse(Console.ReadLine());
            int[,] A;
            A = new int[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    if (i < j)
                        A[i, j] = i + 1;
                    else if (i >= j)
                        A[i, j] = j + 1;
                }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{A[i, j],3}");

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
