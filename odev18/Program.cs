using System;

namespace Ornek223
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("İsmi Giriniz: ");
            string isim = Console.ReadLine();

            char[] karakterler = isim.ToCharArray(); // String'i karakter dizisine çevirme

            bool[] D = new bool[karakterler.Length];
            Random rastgele = new Random();

            Console.Write("Rastgele Karıştırılmış İsim: ");

            for (int a = 0; a < karakterler.Length; a++)
            {
                int sayi;
                do
                {
                    sayi = rastgele.Next(karakterler.Length);
                } while (D[sayi]);

                D[sayi] = true;
                Console.Write(karakterler[sayi]);
            }

            Console.Write("\n\n\nPress any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}