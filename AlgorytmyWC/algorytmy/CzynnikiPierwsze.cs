using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace AlgorytmyWC
{
    internal class CzynnikiPierwsze
    {
        static void Main()
        {
            Console.Write("Podaj liczbę do rozkładu na czynniki pierwsze: ");
            int n = int.Parse(Console.ReadLine());

            List<int> czynnikiPierwsze = RozkladNaCzynnikiPierwsze(n);

            Console.WriteLine("Czynniki pierwsze liczby " + n + ":");
            foreach (int czynnik in czynnikiPierwsze)
            {
                Console.Write(czynnik + " ");
            }
        }

        // Funkcja do rozkładu liczby n na czynniki pierwsze
        static List<int> RozkladNaCzynnikiPierwsze(int n)
        {
            List<int> czynnikiPierwsze = new List<int>();

            // Dzielimy liczbę n przez 2, dopóki jest podzielna przez 2
            while (n % 2 == 0)
            {
                czynnikiPierwsze.Add(2);
                n /= 2;
            }

            // Sprawdzamy dzielniki nieparzyste od 3 do pierwiastka z n
            for (int i = 3; i * i <= n; i += 2)
            {
                while (n % i == 0)
                {
                    czynnikiPierwsze.Add(i);
                    n /= i;
                }
            }

            // Jeżeli pozostała liczba n jest większa niż 2, to jest liczbą pierwszą
            if (n > 2)
            {
                czynnikiPierwsze.Add(n);
            }

            return czynnikiPierwsze;
        }
    }
}
*/