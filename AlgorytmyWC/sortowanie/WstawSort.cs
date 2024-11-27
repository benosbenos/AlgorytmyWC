using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace AlgorytmyWC.sortowanie
{
    internal class WstawSort
    {
        static void Main()
        {
            // Przykładowy zbiór liczb
            int[] zbior = { 12, 11, 13, 5, 6 };

            // Wywołanie funkcji do sortowania
            SortowaniePrzezWstawianie(zbior);

            // Wyświetlanie posortowanego zbioru
            Console.WriteLine("Posortowana tablica:");
            foreach (var liczba in zbior)
            {
                Console.Write(liczba + " ");
            }
        }

        // Funkcja implementująca algorytm sortowania przez wstawianie
        static void SortowaniePrzezWstawianie(int[] zbior)
        {
            int n = zbior.Length;

            // Iterujemy przez każdy element w zbiorze, zaczynając od drugiego
            for (int i = 1; i < n; i++)
            {
                int klucz = zbior[i]; // Element do wstawienia
                int j = i - 1;

                // Przesuwamy elementy większe od klucza w prawo
                while (j >= 0 && zbior[j] > klucz)
                {
                    zbior[j + 1] = zbior[j];
                    j--;
                }

                // Wstawiamy klucz w odpowiednie miejsce
                zbior[j + 1] = klucz;
            }
        }
    }
}
*/