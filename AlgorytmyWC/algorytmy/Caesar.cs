using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace AlgorytmyWC
{
    internal class Caesar
    {
        public static void Main(string[] args)
        {
            char[] duzeZnaki = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] maleznaki = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] liczby = "0123456789".ToCharArray();

            //wyswietl komunikat i pobierz od uzytkownika
            Console.WriteLine("wpisz text");
            string text = Console.ReadLine();
            string zaszyfrowany = "";

            foreach (char znak in text)
            {
                if (char.IsUpper(znak))
                {
                    int i = 0;
                    while (znak != duzeZnaki[i])
                    {
                        i++;
                    }

                    zaszyfrowany += duzeZnaki[(i + 4) % duzeZnaki.Length];
                }
                else if (char.IsLower(znak))
                {
                    int i = 0;
                    while (znak != maleznaki[i])
                    {
                        i++;
                    }
                    zaszyfrowany += maleznaki[(i + 4) % maleznaki.Length];
                }
                else if (char.IsDigit(znak))
                {
                    int i = 0;
                    while (znak != liczby[i])
                    {
                        i++;
                    }
                    zaszyfrowany += liczby[(i + 4) % liczby.Length];
                }


            }
            Console.WriteLine("wpisany tekst " + text);
            Console.WriteLine("zaszyfrowany tekst: " + zaszyfrowany);
        }
    }
}
*/