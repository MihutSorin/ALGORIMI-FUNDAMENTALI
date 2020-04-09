using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._04af5
{
    class Program
    {
        static void Main(string[] args)
        {
            //    5.Se citeste un sir de numere pana la intalnirea unei valori a.
            //Sa se realizeze produsul acestor numere si sa se afiseze
            int n = int.Parse(Console.ReadLine());

            int i = 0;
           // int[] v = new int[n];
            //for (int i = 0; i <n; i++)

            //{
            //    v[i] = int.Parse(Console.ReadLine());
            //    if (v[i] == a)
            //        break;
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(v[i]+" ");
            //}
            int x = 0;
            do
            {
                x = int.Parse(Console.ReadLine());
            } while (x!=n); 
            Console.ReadKey();
        }
    }
}
