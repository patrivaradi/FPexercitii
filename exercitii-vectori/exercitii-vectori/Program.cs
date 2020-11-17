using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercitii_vectori
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
                v[i] = rnd.Next(-100,101);
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
            for(int i=0;i<n-1;i++)
                for(int j=i+1;j<n;j++)
                {
                    if(v[i]<v[j])
                    {
                        aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
                }
        }
        static void Main(string[] args)
        {
            read();
            view();
            ord();
            view();
            Console.WriteLine("Suma celor mai mari 3 valori din vector :"v[0]+v[1]+v[2]);
            Console.ReadKey();
        }
    }
}
