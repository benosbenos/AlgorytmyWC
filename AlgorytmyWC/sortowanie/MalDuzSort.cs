using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace AlgorytmyWC
{
    internal class MalDuzSort
    {
        static void Main()
        {
            // Przykładowy zbiór liczb
            int[] zbior = { 12, 7, 22, -5, 0, 15, 9 };

            // Wywołanie funkcji do znalezienia najmniejszego i największego elementu
            var wyniki = ZnajdzNajmniejszyINajwiekszy(zbior);

            // Wyświetlanie wyników
            Console.WriteLine($"Najmniejszy element: {wyniki.Item1}");
            Console.WriteLine($"Największy element: {wyniki.Item2}");
        }

        // Funkcja do znalezienia najmniejszego i największego elementu
        static Tuple<int, int> ZnajdzNajmniejszyINajwiekszy(int[] zbior)
        {
            // Zakładamy, że pierwszy element zbioru jest zarówno najmniejszy, jak i największy
            int najmniejszy = zbior[0];
            int najwiekszy = zbior[0];

            // Iterujemy przez zbiór, zaczynając od drugiego elementu
            foreach (var liczba in zbior)
            {
                if (liczba < najmniejszy)
                {
                    najmniejszy = liczba; // Aktualizujemy najmniejszy element
                }
                if (liczba > najwiekszy)
                {
                    najwiekszy = liczba; // Aktualizujemy największy element
                }
            }

            // Zwracamy wynik w postaci krotki (tuple)
            return Tuple.Create(najmniejszy, najwiekszy);
        }
    }
}
*/