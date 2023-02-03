using System;

namespace soru_iki
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            Console.WriteLine("Soru 2");
            int n;
            Console.Write("n degerini giriniz: ");
            while (true)
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n <= 0)
                {
                    Console.WriteLine("Pozitif bir deger giriniz!");
                }
                else
                {
                    Console.WriteLine("Girdiğiniz n degeri: " + n);
                    break;
                }
            }


            int m;
            Console.Write("m degerini giriniz: ");
            while (true)
            {
                m = Convert.ToInt32(Console.ReadLine());
                if (m <= 0)
                {
                    Console.WriteLine("Pozitif bir deger giriniz!");
                }
                else
                {
                    Console.WriteLine("Girdiğiniz m degeri: " + m);
                    break;
                }
            }
            int[] sayiDizisi = new int[n];
            for (int i = 0; i < sayiDizisi.Length; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz: ", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            foreach (var sayi in sayiDizisi)
            {
                if (sayi == m && sayi % m == 0)
                {
                    Console.WriteLine("Girmiş oldugunuz sayılar mye eşit veya tam bölünen sayılar");
                    Console.WriteLine(sayi);
                }

            }
        }
    }
}
