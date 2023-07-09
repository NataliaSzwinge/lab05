using System;
namespace cw1
{
    class Program
    {
        static void Main(string[] args)
        {
            //n - tyle liczb, liczba pierwsza = x/x && x/1, 
            Console.WriteLine("Podaj n");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n + " liczb pierwszych");
            int liczba = 2;
            int liczbaLiczbPierwszych = 0;
            while(liczbaLiczbPierwszych < n)
            {
                if (CzyLiczbaPierwsza(liczba))
                {
                    Console.WriteLine(liczba);
                    liczbaLiczbPierwszych++;
                }
                liczba++;
            }
        }
        static bool CzyLiczbaPierwsza(int liczba)
        {
            if(liczba < 2)
            {
                return false;
            }
            for(int i = 2; i*i <= liczba; i++)
            {
                if (liczba % i == 0)
                {
                    return false;                   
                }
            }
            return true;
        }
    }
}