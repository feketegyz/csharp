using System;
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
            //pénz vagy kocka
            Console.WriteLine("Pénzfeldobás vagy Kockadobás");
            Console.WriteLine("P vagy K");
            char pk = char.Parse(Console.ReadLine());

            if (pk=='k')           
            {//kocka dobás kezdete
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
                    Console.WriteLine($"hatos  " + dobas6 + " db " + (dobas6 * 100 / dobdb) + " %");
                    Console.WriteLine($"ötös   " + dobas5 + " db " + (dobas5 * 100 / dobdb) + " %");
                    Console.WriteLine($"négyes " + dobas4 + " db " + (dobas4 * 100 / dobdb) + " %");
                    Console.WriteLine($"hármas " + dobas3 + " db " + (dobas3 * 100 / dobdb) + " %");
                    Console.WriteLine($"kettes " + dobas2 + " db "  + (dobas2 * 100 / dobdb) + " %");
                    Console.WriteLine($"egyes  " + dobas1 + " db "  + (dobas1 * 100 / dobdb) + " %");

                    Console.WriteLine("Akarsz újabb szimulációt (y/n)");
                    kocka = char.Parse(Console.ReadLine());
                } // elől tesztelő ciklus vége
            } //if ág, kockadobás vége
            else
            {
                char feldob = 'y';
                char ask = 'y';

                // elől tesztelő ciklus kezdete
                while (feldob == 'y')
                {
                Console.WriteLine("Pénzfeldobás");
                // Változók deklarálása
                Random coin = new Random();
                int fvi = 0;
                int fej = 0;
                int iras = 0;

                Console.WriteLine("Hány dobást szimuláljak?");
                int feldb = int.Parse(Console.ReadLine());

                // számláló ciklus indulása
                for (int i = 0; i < feldb; i++)
                {
                    fvi = coin.Next(1, 3);
                    Console.Write($"" + fvi + " ");

                    // Elágazás
                    switch (fvi)
                        {
                            case 1:
                                fej++;
                                break;
                            case 2:
                                iras++;
                                break;
                        }
                }
                Console.WriteLine();
                Console.WriteLine($"fej    " + fej + " db " + (fej * 100 / feldb) + " %");
                Console.WriteLine($"írás   " + iras + " db " + (iras * 100 / feldb) + " %");
                Console.WriteLine("Akarsz újabb szimulációt (y/n)");
                feldob = char.Parse(Console.ReadLine());
                } // elől tesztelő ciklus vége

                //Console.ReadKey();
            }
        }
    }
}
