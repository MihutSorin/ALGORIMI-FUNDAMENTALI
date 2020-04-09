using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._04.af
{
  
    class Program
    {
         
        static void Main(string[] args)
        {
            //{//1. Fie a si b 2 numere intregi date de la tastatura, sa se afiseze:
            //    a) suma lor;
            //    b) diferenta lor;
            //    c) produsul lor;
            //    d) catul impartirii lui a la b;
            //    e) restul impartirii lui a la b;
            //    f) care este cel mai mic numar(cu mesaj);
            //    g) care este cel mai mare numar.
            //  int a, b;
            Console.WriteLine("dati cele doua numere:");
            Console.Write("a=");
             int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            // int Suma = 0;
            //  suma = a + b;
           // Console.WriteLine($"suma celor doua numere este suma=",Suma);
            Suma(a,b);
            Console.WriteLine("suma numerelor este: "+Suma(a,b));
            Diferenta(a, b);
            Console.WriteLine("diferenta numerelor este: " + Diferenta(a, b));
            produs(a, b);
            Console.WriteLine("produsul numerelor este: " + produs(a, b));
            Cat(a, b);
            Console.WriteLine("catul dintre cele doua numere este:"+Cat(a,b));
            rest(a, b);
            Console.WriteLine("restul dintre cele doua numere este:" + rest(a, b));
            Min(a, b);
            Console.WriteLine("minimul este"+Min(a,b));
            Max(a, b);
            Console.WriteLine("maximul este" + Max(a, b));
            //int dif = 0;
            //dif = a - b;
            //Console.WriteLine("diferenta dintre cele doua numere dif="+dif);
            //int produs = 0;
            //produs = a * b;
            //Console.WriteLine("produsul lor este:"+produs);
            //int cat = 0;
            //cat = a / b;
            //Console.WriteLine("catul este"+cat);
            //int rest = 0;
            //rest = a % b;
            //Console.WriteLine("restul este "+rest);
            //if (a < b)
            //{
            //    Console.WriteLine(" " + a + "este numarul mai mic");
            //}
            //else
            //    Console.WriteLine(+b+"b este numarul mai mic");

            //int min = 0;
            //min = Math.Min(a, b);
            //Console.WriteLine("minimul este:"+min);
            //int max = 0;
            //max = Math.Max(a, b);
            //Console.WriteLine("maximul este"+max);
            // 2.Sa se realizeze un program care calculeaza pentru numerele intregi a si b
            //valoarea E = a la puterea b.
            double E = 0;
            E = Math.Pow(a, b);
            Console.WriteLine("valoarea E a lui "+a+"la puterea"+b+"este:"+E);
            //           3.Sa se calculeze valoarea expresiei intr - un punct x, a si b fiind doua numere introduse de la tastatura.
            //E(x) = ax * x + b, pentru x< 0   .....x=+-sqrt(b/a)
            //          = 2, pentru x = 0
            //          = 5x - 7, pentru x > 0
            double x = 0;
            double Ex = 0;
            x = Math.Sqrt(b / a);
            Console.WriteLine("x=+-"+x);
            if (x<0)
            {
                Ex = a * (x * x) + b;
                Console.WriteLine("E(x)="+Ex);
            }
            if (x==0)
            {
                Ex = 2;
                Console.WriteLine("Ex="+Ex);
            }
            if (x>0)
            {
                Ex = 5 * x - 7;
                Console.WriteLine("E(x)="+Ex);
            }

            Console.ReadKey();
        }

        private static int Max(int a, int b)
        {
            if (a > b) return a;
            else return b;
        }

        private static int Min(int a, int b)
        {
            if (a < b) return a;
            else return b;
           
        }

        private static Double rest(Double a, Double b)
        {
            return a % b;
        }

        private static int Cat(int a, int b)
        {
            return a / b;
        }

        private static int produs(int a, int b)
        {
           return a*b;
        }

        private static int Diferenta(int a, int b)
        {
            return a - b;
        }

        private static int Suma(int a, int b)
        {
            return a + b;
        }
    }
}
