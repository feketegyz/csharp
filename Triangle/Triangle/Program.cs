﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Változók deklarálása
            int a = 0;
            int b = 0;
            int c = 0;
            int ma = 0;
            int mb = 0;
            int mc = 0;
            int K = 0;

            Console.WriteLine("Háromszögekkel kapcsolatos számítások");
            //Adatok bekérése
            Console.WriteLine("Add mega háromszög adatait");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            //Háromszög egyenlőtlenség tétele
            if ((a+b)<c)
            {
                Console.WriteLine("Nincs ilyen háromszög");
            //    else
                {
                    if ((a + c) < b)
                    {
                        Console.WriteLine("Nincs ilyen háromszög");
                    }
                    if ((b+c)<a)
                    {
                        Console.WriteLine("Nincs ilyen háromszög");
                    }
                    else
                    {
                        Console.WriteLine("Ez létező háromszög");
                    }
                }
            }

            Console.WriteLine($"a= "+ a);
            Console.WriteLine($"b= " + b);
            Console.WriteLine($"c= " + c);
            Console.WriteLine($"K= " + ( a + b + c));



            Console.ReadKey();
        }
    }
}