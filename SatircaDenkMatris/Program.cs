using System;
using System.Collections.Generic;

namespace SatircaDenkMatris
{
    class SatircaDenk
    {
        int[][] matris;  
        int matris_boyutu_x;
        int matris_boyutu_y;

        public SatircaDenk(int a, int b, int[][] c)
        {
            matris_boyutu_x = a;
            matris_boyutu_y = b;
            matris = c;

            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("Lütfen geçerli bir boyut giriniz.");
            }
            else
            {
                Console.WriteLine("Matris:");

                for (int i = 0; i < matris_boyutu_x; i++)
                {
                    for (int j = 0; j < matris_boyutu_y; j++)
                    {
                        Console.Write(matris[j][i] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Matrisin satır sayısını giriniz:");
            int satir = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Matrisin sütun sayısını giriniz:");
            int sutun = Convert.ToInt32(Console.ReadLine());

            int[][] matrisArray = new int[sutun][];
            for (int j = 0; j < sutun; j++)
            {
                matrisArray[j] = new int[satir];  

                Console.WriteLine($"{j + 1}. sütunun elemanlarını giriniz:");

                for (int i = 0; i < satir; i++)
                {
                    Console.Write($"Matris[{i},{j}] = ");
                    if (int.TryParse(Console.ReadLine(), out int element))
                    {
                        matrisArray[j][i] = element;
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz bir sayı girdiniz. Lütfen geçerli bir değer giriniz.");
                        i--;  
                    }
                }
            }

            
            SatircaDenk m1 = new SatircaDenk(satir, sutun, matrisArray);
           
        }
    }
}
