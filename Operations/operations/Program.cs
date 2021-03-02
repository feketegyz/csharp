using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alapműveletek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alapmüvelet gyakorlás");

            Random r = new Random();
            int[] szam1 = new int[10];
            int[] szam2 = new int[10];
            int[] szum = new int[10];
            int szumjo = 0;
            int[] dif = new int[10];
            int difjo = 0;


            for (int i = 0; i < 5; i++)
            {
                szam1[i] = r.Next(0, 100);
                szam2[i] = r.Next(0, 100);

                Console.Write(szam1[i] + "+" + szam2[i] + "= ");
                szum[i] = int.Parse(Console.ReadLine());
                //Console.Write(szam1[i]+szam2[i]);
                if (szam1[i] + szam2[i] == szum[i])
                {
                    //Console.WriteLine("  helyes");
                    szumjo++;
                }

            }
            //for(int i = 0; i < 9; i++)

            Console.WriteLine($"10-ből " + szumjo + " jó");
            Console.ReadKey();
        }
    }
}
