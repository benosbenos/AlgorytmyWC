using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace AlgorytmyWC
{
    internal class BambelSort
    {
        static void Main()
        {
            // Przykładowy zbiór liczb
            int[] zbior = { 5, 1, 9, 3, 7, 6, 8, 2 };

            // Wywołanie funkcji do sortowania
            SortowanieBabelkowe(zbior);

            // Wyświetlanie posortowanego zbioru
            Console.WriteLine("Posortowana tablica:");
            foreach (var liczba in zbior)
            {
                Console.Write(liczba + " ");
            }
        }

        // Funkcja implementująca algorytm sortowania bąbelkowego
        static void SortowanieBabelkowe(int[] zbior)
        {
            int n = zbior.Length;
            bool zamiana;

            // Powtarzamy proces dopóki w trakcie całej iteracji nie dojdzie do żadnej zamiany
            do
            {
                zamiana = false;

                // Iteracja przez elementy, porównując pary sąsiadujących elementów
                for (int i = 0; i < n - 1; i++)
                {
                    // Jeśli element na lewej pozycji jest większy, zamieniamy miejscami
                    if (zbior[i] > zbior[i + 1])
                    {
                        // Zamiana miejscami
                        int temp = zbior[i];
                        zbior[i] = zbior[i + 1];
                        zbior[i + 1] = temp;

                        // Oznaczamy, że była zamiana
                        zamiana = true;
                    }
                }

                // Po każdej iteracji największy element jest na swoim miejscu
                n--; // Zmniejszamy zakres porównań (ostatni element jest już na odpowiednim miejscu)

            } while (zamiana); // Powtarzamy, dopóki w iteracji nie było żadnej zamiany
        }
    }
}
*/