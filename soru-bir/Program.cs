using System;

namespace soru_bir
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın. */

            Console.WriteLine("Soru 1");
            Console.WriteLine();
            int sayi;
            Console.Write("Pozitif sayı giriniz:");
            while (true)
            {
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi <= 0)
                {
                    Console.WriteLine("Pozitif bir sayı girmediniz! Lütfen tekrar deneyiniz.");
                }
                else
                {
                    Console.WriteLine("Girdiğiniz sayi :" + sayi);
                    break;
                }

            }

            Console.WriteLine();

            Console.WriteLine("Lütfen gireceğiniz sayı adedini belirtiniz: ");

            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {



                Console.WriteLine("Lütfen {0}. sayıyı giriniz: ", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());



            }


            foreach (var sayilar in sayiDizisi)
            {

                if (sayilar % 2 == 0)
                {
                    Console.WriteLine(sayilar);
                }

            }

            Console.Read();
        }

    }
}
