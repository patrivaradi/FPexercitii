using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {        
        static int[] v;
        static int n;
        static Random rnd = new Random();

        static void read()
        {
            Console.Write("Introduceti nr elementelor vectorului : ");
            n = int.Parse(Console.ReadLine());
            v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = rnd.Next(-100, 101);
        }
        static void view()
        {
            Console.WriteLine($"Vectorul din {n} elemente:");
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");
            Console.WriteLine();
        }

        static void ord()
        {
            int aux;
            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                {
                    if (v[i] < v[j])
                    {
                        aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
                }
        }

        static void getMaxCount()
        {
            ord();
            int max = 1;
            int s = v[0];
            int idx = s;
            int k = 1;
            for(int i=1;i<n;i++)
            {
                if (v[i] == s) k++;
                else
                {
                    if(k>max)
                    {
                        max = k;
                        idx = s;
                    }
                    k = 1;
                }
                s = v[i];
            }
            Console.WriteLine(idx+" apare de "+max+" ori.");
        }

        static void Main(string[] args)
        {
            read();
            view();
            Console.WriteLine();
            getMaxCount();

            Console.ReadKey();
        }
        
    }
}
