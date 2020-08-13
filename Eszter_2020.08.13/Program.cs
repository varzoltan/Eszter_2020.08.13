using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eszter_2020._08._13
{
    class Program
    {
        static void Main(string[] args)
        {
            //11. Írj programot, amely beolvas egy egész számot, 
            //majd elosztja 2-vel annyiszor,ahányszor lehet és közben felírja a számot a kettes számok       
            //szorzataként megszorozva egy olyan számmal, amely már nem osztható 2-vel. Például: 120=2*2*2*15
            Console.Write("Kérem adjon meg egy egész számot! ");
            int szam = int.Parse(Console.ReadLine());
            Console.Write($"{szam}=");
            while(szam % 2 == 0)
            {
                szam = szam  /  2;
                Console.Write($"2*");
            }
            Console.Write($"{szam}");

            //12. Bekérünk a felhasználótól egy számot, majd eldönti róla, hogy az adott szám prímszám-e.
            Console.Write("Kérem adjon meg egy egész számot! ");
            int egesz = int.Parse(Console.ReadLine());
            int ertek = 2;
            for (int i = 2; i < egesz/2 ; i++ )
            {
                if (egesz % i == 0)
                {
                    ertek++;
                }
            }
            if (ertek>2)
            {
                Console.WriteLine("A szám nem prímszám!");
            }
            else
            {
                Console.WriteLine("A szám prímszám!");
            }
            Console.ReadKey();
        }
    }
}
