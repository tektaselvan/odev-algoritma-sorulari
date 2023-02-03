using System;

namespace soru_dort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            string cumle;
            Console.Write("Lütfen bir cümle giriniz: ");
            cumle = Console.ReadLine();
            Console.WriteLine("Harf sayısı: " + cumle.Length);
            string[] kelimeler = cumle.Split(' ');
            Console.WriteLine("Kelime Sayısı: " + kelimeler.Length);
            foreach (var kelime in kelimeler)
            {
                Console.WriteLine(kelime);

            }
            Console.ReadLine();
        }
    }
}
