﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kocka
{
    class Program
    {
        static void Main(string[] args)

        {
            char kocka = 'y';
            char ask = 'y';

            // elől tesztelő ciklus kezdete
            while (kocka == 'y')
            {
                // Változók deklarálása
                Random dob = new Random();
                int dobas = 0;
                int dobas1 = 0;
                int dobas2 = 0;
                int dobas3 = 0;
                int dobas4 = 0;
                int dobas5 = 0;
                int dobas6 = 0;

                Console.WriteLine("Dobások ");
                Console.WriteLine("Hány dobást szimuláljak?");
                int dobdb = int.Parse(Console.ReadLine());

                // számláló ciklus indulása
                for (int i = 0; i < dobdb; i++)
                {
                    dobas = dob.Next(1, 7);
                    Console.Write($"" + dobas + " ");

                    // Elágazás
                    switch (dobas)
                    {
                        case 6:
                            dobas6++;
                            break;
                        case 5:
                            dobas5++;
                            break;
                        case 4:
                            dobas4++;
                            break;
                        case 3:
                            dobas3++;
                            break;
                        case 2:
                            dobas2++;
                            break;
                        case 1:
                            dobas1++;
                            break;
                    }  // Elágazás vége
                } // for ciklus vége
                Console.WriteLine();
                Console.WriteLine($"hatos  " + dobas6 + " db");
                Console.WriteLine($"ötös   " + dobas5 + " db");
                Console.WriteLine($"négyes " + dobas4 + " db");
                Console.WriteLine($"hármas " + dobas3 + " db");
                Console.WriteLine($"kettes " + dobas2 + " db");
                Console.WriteLine($"egyes  " + dobas1 + " db");

                Console.WriteLine("Akarsz újabb szimulációt (y/n)");
                kocka = char.Parse(Console.ReadLine());
            } // elől tesztelő ciklus vége

        }
    }
}