using System;
namespace cw3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wysokosc trojkata");
            int wysokosc = Convert.ToInt32(Console.ReadLine()); //wysokosc = liczba wierszy
            int szerokoscPodstawy = wysokosc * 2 - 1;
            int liczbaSpacji = szerokoscPodstawy / 2;
            for(int i = 0; i < wysokosc; i++)
            {
                for(int j = 0;  j < liczbaSpacji; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 0; k < (i*2+1); k++)
                {
                    Console.Write("+");
                }
                Console.WriteLine();
                liczbaSpacji--;
            }
        }
    }
}