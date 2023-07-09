#define cw2_v2
#if (cw2_v1)
using System;
namespace cw2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int iloscLiczbParzystych = 10;
            int licznikLosowan = 0;
            Console.Write("Wersja 1: ");
            for(int i = 0; i < iloscLiczbParzystych; i++)
            {
                int wylosowanaLiczba;
                do
                {
                    wylosowanaLiczba = rnd.Next(-8, 9);
                    licznikLosowan++;
                } while (wylosowanaLiczba % 2 != 0);
                Console.Write(wylosowanaLiczba);
                if(i < iloscLiczbParzystych - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Liczba wykonanych losowan: " + licznikLosowan);
        }
    }
}
#endif

#if (cw2_v2)
using System;
namespace cw2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int iloscLiczbParzystych = 10;
            int licznikLosowan = 0;
            Console.Write("Wersja 2: ");
            for(int i = 0; i < iloscLiczbParzystych; i++)
            {
                int wylosowanaLiczba = rnd.Next(-4, 5);
                licznikLosowan++;
                Console.Write(wylosowanaLiczba);
                if(i < iloscLiczbParzystych - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Liczba wykonanych losowan: " + licznikLosowan); 
        }
    }
}

#endif