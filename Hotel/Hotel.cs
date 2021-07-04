using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Hotel
    {

        /// <summary>
        /// Pobiera liczbę całkowitą większą od zera
        /// </summary>
        /// <param name="komunikat">string Treść komunikatu dla użytkownika</param>
        /// <returns>int </returns>
        private static int PobierzIntDodatni(string komunikat)
        {
            string sLiczba;
            int nLiczba = 0;
            bool czyLiczba = false;
            do
            {
                Console.Write("{0}", komunikat);
                sLiczba = Console.ReadLine();
                if (int.TryParse(sLiczba, out nLiczba))
                {
                    if (nLiczba > 0)
                        czyLiczba = true;
                    else
                        Console.WriteLine("Nieprawidłowa wartość: {0}.", sLiczba);
                }
                else
                {
                    Console.WriteLine("Nieprawidłowa wartość: {0}.", sLiczba);
                }
            } while (!(czyLiczba));
            return nLiczba;
        }

        /// <summary>
        /// Pobiera wiek użytkownika
        /// </summary>
        /// <returns>int wiek</returns>
        public static int PodajWiek()
        {
            int nLiczba = PobierzIntDodatni("Podaj wiek w latach: ");
            return nLiczba;
        }
        /// <summary>
        /// Pobiera ilość nocy od użytkownika
        /// </summary>
        /// <returns></returns>
        public static int PodajIloscNocy()
        {
            int nLiczba = PobierzIntDodatni("Podaj ilość noclegów: ");
            return nLiczba;
        }
        /// <summary>
        /// Wylicza opłatę za pobyt w hotelu.
        /// Podaje swój wiek i ile nocy spędzi w hotelu, a program wylicza, ile trzeba zapłacić.Zasady są takie:
        /// - nieletni (poniżej 18 roku życia) płacą 100 zł za noc
        /// - dorośli(ci, którzy mają przynajmniej 18 lat ale mniej niż 65 lat) płacą:
        /// 	- 200 zł za noc, jeśli nocują jedną noc
        /// 	- 180 zł za noc, jeśli nocują przynajmniej dwie ale mniej niż pięć nocy
        /// 	- 150 zł za noc, jeśli nocują pięć lub więcej nocy
        /// - emeryci(ci, którzy mają przynajmniej 65 lat), płacą jak dorośli, ale z 10% zniżki
        /// </summary>
        /// <param name="wiek">int wiek</param>
        /// <param name="iloscNocy">int ilość nocy</param>
        public static void WyliczPobyt(int wiek, int iloscNocy)
        {
            double wartosc;
            double cenaNoclegu = 200;
            double rabat = 0;
            if (iloscNocy < 1)
            {
                Console.WriteLine("Ilość noclegów musi być większa od 0.");
            } 
            else
            {
                if (wiek < 18)  // nieletni
                {
                    WyswietlanieWartosciPobytu(iloscNocy, cenaNoclegu);
                }
                else if (wiek >= 65)  // emeryci
                {
                    rabat = 10;
                    cenaNoclegu *= (100 - rabat) / 100.0;
                    WyswietlanieWartosciPobytu(iloscNocy, cenaNoclegu);
                }
                else if (wiek > 0)    // pozostali - dorośli
                {
                    if (iloscNocy >= 5)
                    {
                        cenaNoclegu = 150.00;
                        WyswietlanieWartosciPobytu(iloscNocy, cenaNoclegu);
                    }
                    else if (iloscNocy >= 2)
                    {
                        cenaNoclegu = 180.00;
                        WyswietlanieWartosciPobytu(iloscNocy, cenaNoclegu);
                    }
                    else
                    {
                        cenaNoclegu = 200.00;
                        WyswietlanieWartosciPobytu(iloscNocy, cenaNoclegu);
                    }
                }
                else
                {
                    Console.WriteLine("Wiek musi być większy od 0.");
                }
            }
        }

        /// <summary>
        /// Wyświetla info o cenie za pobyt.
        /// </summary>
        /// <param name="iloscNocy"></param>
        /// <param name="cenaNoclegu"></param>
        private static void WyswietlanieWartosciPobytu(int iloscNocy, double cenaNoclegu)
        {
            Console.WriteLine("\nPobyt kosztuje: {0,1:0.00}", iloscNocy * cenaNoclegu);
            Console.WriteLine("Ilość noclegów: {0}", iloscNocy);
            Console.WriteLine("Cena za nocleg: {0}", cenaNoclegu);
        }
    }
}
