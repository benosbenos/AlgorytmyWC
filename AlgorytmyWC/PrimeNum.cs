using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace AlgorytmyWC
{
    internal class PrimeNum
    {
        
            // Funkcja do sprawdzenia, czy liczba jest pierwsza
            static bool IsPrime(int number)
            {
                // Liczba podana jest mniejsza niż 2, nie jest ona liczbą pierwszą
                if (number < 2) return false;

                // Sprawdzamy podzielność do pierwiastka z liczby
                for (int i = 2; i * i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        return false; // Liczba nie jest pierwsza, bo dzieli się przez i
                    }
                }

                // Jeśli pętla się zakończyła, to liczba jest pierwsza
                return true;
            }

            static void Main()
            {
                Console.WriteLine("Podaj liczbę:");
                int number = int.Parse(Console.ReadLine());

                if (IsPrime(number))
                {
                    Console.WriteLine($"{number} jest liczbą pierwszą.");
                }
                else
                {
                    Console.WriteLine($"{number} nie jest liczbą pierwszą.");
                }
            }
        
    }
}
*/
