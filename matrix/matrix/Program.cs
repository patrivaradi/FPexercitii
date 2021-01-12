using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            problemadoi();
            problematrei();
            problemapatru();
            problemacinci();
            
        }

        private static void problemacinci()
        {
            Random rnd = new Random();
            int n, m;
            Console.Write("Introduceti liniile matricii n = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti coloanele matricii m = ");
            m = int.Parse(Console.ReadLine());
            int[,] A;
            A = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    A[i, j] = rnd.Next(1,10);
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
            int max=-1 , min;
            for (int i = 0; i <n; i++)
            {
                min =A[i, 0];
                for (int j = 1; j < m; j++)
                {
                    if (A[i,j] < min) min = A[i,j];
                }
                if (min > max) max = min;
            }
            Console.WriteLine("Cea mai mare valoare din cei mai mici valori pe linii este :",max);
            Console.ReadKey();
        }

        private static void problemapatru()
        {
            int n, m;
            int idx = 2, nrp=0,lc=0,cc=0;
            Console.Write("Introduceti liniile matricii n = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti coloanele matricii m = ");
            m = int.Parse(Console.ReadLine());
            int[,] A;
            A = new int[n, m];
            do
            {
                if (isPrim(idx))
                {
                    A[lc, cc] = idx;
                    cc++;
                    if (cc == m)
                    {
                        lc++;
                        cc = 0;
                    }
                    nrp++;
                }
                idx++;
            } while (nrp < n * m);
            Console.WriteLine($"Matricea de {n}*{m} cu numere prime :");
            for (int i = 0; i <n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        private static bool isPrim(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            for (int i = 3; i * i <= n; i += 2)
                if (n % i == 0) return false;
            return true;

        }

        private static void problematrei()
        {
            Random rnd = new Random();
            int n, m;
            Console.Write("Introduceti liniile matricii n = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti coloanele matricii m = ");
            m = int.Parse(Console.ReadLine());
            int[,] A;
            A = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    A[i, j] = rnd.Next(10);
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Elementele primului patrat concentric : ");
            for (int i = 0; i < m - 1; i++)
                Console.Write(A[0,i]+" ");
            for (int i = 0; i < n - 1; i++)
                Console.Write(A[i, m-1] + " ");
            for (int i = m-1; i >= 1; i--)
                Console.Write(A[n-1, i] + " ");
            for (int i = n-1; i >= 1; i--)
                Console.Write(A[i, 0] + " ");
            Console.ReadKey();
        }

        private static void problemadoi()
        {
            int n, m,k=1;
            Console.Write("Introduceti liniile matricii n = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti coloanele matricii m = ");
            m = int.Parse(Console.ReadLine());
            int[,] A;
            A = new int[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    A[i, j] = k * k;
                    k += 2;
                }
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(A[i, j]+" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
