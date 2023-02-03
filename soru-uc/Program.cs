using System;

namespace soru_uc
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

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
                    Console.WriteLine("Girmiş oldugunuz n degeri: " + n);
                    break;
                }
            }
            string[] kelime = new string[n];
            for (int i = 0; i < kelime.Length; i++)
            {
                Console.WriteLine("Lütfen {0}. kelimeyi giriniz: ", i + 1);
                kelime[i] = Console.ReadLine();
            }
            Array.Reverse(kelime);
            foreach (var kelimeler in kelime)
            {
                Console.WriteLine(kelimeler);
            }
        }
    }
}
