using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._04afpct4
{
    class Program
    {
        static Random rnd = new Random();
        private static int n;

        static void Main(string[] args)
        {
            //            4.Se citeste un sir de numere pana la intalnirea numarului 4.
            //Sa se realizeze un program care afiseaza:
            //            a) numerele;
            //            b) suma lor;
            //            c) media aritmetica a numerelor;
            //            d) cate numere sunt mai mici ca 6;
            //            e) suma numerelor divizibile cu 3;
            //            f) media aritmetica a numerelor care sunt divizibile cu 3
            //sau care dau restul 2 la impartirea cu 4
            //int elemente = int.Parse(Console.ReadLine());
            //int[] array = new int[elemente];
            //for (int i = 0; i < elemente; i++)
            //{

            //    array[i] = rnd.Next(100);
            //    Console.Write(array[i] + " ");
            //    if (array[i] == 4)
            //    {
            //        break;
            //    }
            //}
            //int suma = 0;
            //for (int i = 0; i < elemente; i++)
            //{
            //    suma += array[i];

            //}
            //Console.WriteLine();
            //Console.WriteLine("suma elementelor este:" + suma);
            //double ma = 0;
            //ma = Convert.ToDouble(suma) / elemente;
            //Console.WriteLine();
            //Console.WriteLine("media aritmetica ese:" + ma);
            //int contor = 0;
            //for (int i = 0; i < elemente; i++)
            //{
            //    if (array[i] < 6)
            //    {
            //        contor++;
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine(contor + " numere sunt mai mici ca 6");
            ////e) suma numerelor divizibile cu 3;
            //int suma2 = 0;
            //for (int i = 0; i < elemente; i++)
            //{

            //    // array[i] = rnd.Next(10);
            //    //Console.Write(array[i] + " ");
            //    if (array[i] % 3 == 0)
            //    {
            //        Console.Write(array[i] + " ");
            //        suma2 += array[i];
            //    }
            //}
            //Console.WriteLine("suma numerelor divizibile cu 3 este  " + suma2);
            ////f)
            //int suma3 = 0;
            //contor = 0;
            //Console.WriteLine();
            //for (int i = 0; i < elemente; i++)
            //{
            //    Console.Write(array[i] + " ");
            //    // Console.WriteLine();
            //    if (array[i] % 3 == 0)
            //    {
            //        contor++;
            //        suma3 += array[i];
            //    }
            //}
            //if (contor > 0)
            //{
            //    ma = Convert.ToDouble(suma3) / contor;
            //    Console.WriteLine(ma + " ");
            //}
            //else Console.WriteLine("nu avem nici un element divizibil cu 3");

            ////Console.WriteLine(ma);
            int a = 0;
            int suma = 0;
            int counter = 0;
            int count6 = 0;
            int ma = 0;
            int sumadiv3 = 0;
            int countdiv3 = 0;
            double ma3 = 0;
            do
            {
                a = int.Parse(Console.ReadLine());
                suma += a;
                counter++;
                if (a < 6) count6++;
                if (a % 3 == 0)
                {
                    countdiv3++;
                    sumadiv3 += a;
                }
            } while (a!=4);
            Console.WriteLine("suma numerelor introduse este:"+suma);
            ma = suma / counter;
            Console.WriteLine("media aritmetica a numerelor introduse este:"+ma);
            Console.WriteLine(count6+" numere sunt mai mici decat 6");
            Console.WriteLine("suma numerelor divizibile cu trei este: "+sumadiv3);
            ma3 = (double) sumadiv3 / countdiv3;
            Console.WriteLine("maedia aritmetica anumerelor divizibile cu trei este : "+ma3);
            Console.ReadKey();
        }
    }
}
