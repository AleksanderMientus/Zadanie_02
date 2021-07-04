using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    /// <summary>
    /// program wyliczający opłatę za pobyt w hotelu.
    /// 
    /// Użytkownik podaje swój wiek i ile nocy spędzi w hotelu, a program wylicza, ile trzeba zapłacić.Zasady są takie:
    /// - nieletni (poniżej 18 roku życia) płacą 100 zł za noc
    /// - dorośli(ci, którzy mają przynajmniej 18 lat ale mniej niż 65 lat) płacą:
    /// 	- 200 zł za noc, jeśli nocują jedną noc
    /// 	- 180 zł za noc, jeśli nocują przynajmniej dwie ale mniej niż pięć nocy
    /// 	- 150 zł za noc, jeśli nocują pięć lub więcej nocy
    /// - emeryci(ci, którzy mają przynajmniej 65 lat), płacą jak dorośli, ale z 10% zniżki
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int wiek;
            int iloscNocy;

            wiek = Hotel.PodajWiek();
            iloscNocy = Hotel.PodajIloscNocy();
            Hotel.WyliczPobyt(wiek, iloscNocy);

            Console.ReadKey();
        }
    }
}
