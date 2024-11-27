using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace AlgorytmyWC
{
    internal class WybSort
    {
        static void Main()
        {
            // Przykładowy zbiór liczb
            int[] zbior = { 64, 25, 12, 22, 11 };

            // Wywołanie funkcji do sortowania
            SortowaniePrzezWybór(zbior);

            // Wyświetlanie posortowanego zbioru
            Console.WriteLine("Posortowana tablica:");
            foreach (var liczba in zbior)
            {
                Console.Write(liczba + " ");
            }
        }

        // Funkcja implementująca algorytm sortowania przez wybór
        static void SortowaniePrzezWybór(int[] zbior)
        {
            int n = zbior.Length;

            // Iterujemy po każdym elemencie
            for (int i = 0; i < n - 1; i++)
            {
                // Zakładamy, że bieżący element jest najmniejszy
                int minIndex = i;

                // Przeszukujemy pozostałą część zbioru
                for (int j = i + 1; j < n; j++)
                {
                    // Jeśli znaleźliśmy mniejszy element, aktualizujemy indeks najmniejszego
                    if (zbior[j] < zbior[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Jeśli indeks najmniejszego elementu różni się od obecnego, zamieniamy miejscami
                if (minIndex != i)
                {
                    int temp = zbior[i];
                    zbior[i] = zbior[minIndex];
                    zbior[minIndex] = temp;
                }
            }
        }
    }
}
*/