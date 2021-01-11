using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;

namespace exercitii_cu_fisiere
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti k = ");
            int k =int.Parse(Console.ReadLine());
            TextReader file = new StreamReader(Path.GetFullPath("bac.txt"));
            string n = file.ReadToEnd();                                        //reads in a string the numbers from .txt
            string[] v = n.Split(' ');                                          //removes from string the space between the numbers
            List<string> nr = new List<string>(); 
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i]+" ");
                int x = int.Parse(v[i]);
                if (x > k)
                {
                    if (nr.Contains(v[i])) ;                                    //verifies if the number is in the list already 

                    else nr.Add(v[i]);                                          //if it's not in the list adds the number 
                }
                
            }
            Console.WriteLine();
            nr.Sort();                                                          //sorts the list
            for(int i = 0; i<nr.Count; i++)
            {                
                Console.Write(nr[i]+" ");                                       //writes to the console the sorted list
            }
            
            
            Console.ReadKey();
        }
    }
}
