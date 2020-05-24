using System;
using System.Collections.Generic;
namespace ProgObjectKelner
{
    public class ZamowienieRepository
    {
        /// <summary>
        /// Pobieramy jedną pozycje zamowienia
        /// </summary>
        /// <param name="pozycjaZamowieniaId"></param>
        /// <returns></returns>
        public Zamowienie Pobierz (int pozycjaZamowieniaId)
        {

            //tworzymu zamowienie
            Zamowienie zamowienie = new Zamowienie (pozycjaZamowieniaId);
            if (pozycjaZamowieniaId == 10)
            {
                zamowienie.DataZamowienie = new DateTimeOffset (2016, 4, 23, 10, 00, 00, 00, new TimeSpan (7, 0, 0));
            }

            return zamowienie;
        }
        /// <summary>
        /// pobieramy jedno zamowienie do wyświetlenia
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public WyswietlanieZamowienia PobierzZamowienieDoWyswietlenia (int zamowienieId)
        {
            WyswietlanieZamowienia wyswietlanieZamowienia = new WyswietlanieZamowienia ();
            //kod ktory pobierze te dane
            //tymczasowe dane zaokdowane na stałe
            if (zamowienieId == 10)
            {
                wyswietlanieZamowienia.imie = "Pietrek";
                wyswietlanieZamowienia.nazwisko = "Kowalik";
                wyswietlanieZamowienia.datazamowienia = new DateTimeOffset (2018, 4, 14, 10, 00, 00, 00, new TimeSpan (7, 0, 0));
                wyswietlanieZamowienia.adresDostawy = new Adres ()
                {
                    AdresTyp = 1,
                    Ulica = "kosmiczna",
                    Miasto = "Katowice",
                    KodPocztowy = "40-467",
                    Kraj = "Polska",

                };
            }
            wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniaLista = new List<WyswietlaniePozycjiZamowienia> ();
            //kod

            if (zamowienieId == 10)
            {
                var WyswietlaniePozycjiZamowienia = new WyswietlaniePozycjiZamowienia ()
                {
                nazwaProduktu = "Krzesło",
                iloscZamowienia = 4,
                cenaZakupu = 199.77m
                };
                wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniaLista.Add (WyswietlaniePozycjiZamowienia);
                WyswietlaniePozycjiZamowienia = new WyswietlaniePozycjiZamowienia ()
                {
                    nazwaProduktu = "Stolik",
                    iloscZamowienia = 7,
                    cenaZakupu = 249m
                };
                wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniaLista.Add (WyswietlaniePozycjiZamowienia);

            }
            return wyswietlanieZamowienia;
        }

        /// <summary>
        /// Zapisujemy biezaczy element zamowienia
        /// </summary>
        /// <returns></returns>
        public bool Zapisz ()
        {
            return true;
        }
    }
}