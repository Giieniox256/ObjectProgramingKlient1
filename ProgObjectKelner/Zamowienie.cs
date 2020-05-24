using System;
using System.Collections.Generic;

namespace ProgObjectKelner
{
    public class Zamowienie
    {
        public Zamowienie ()
        {

        }

        public Zamowienie (int zamowienieId)
        {
            ZamowienieId = zamowienieId;
        }
        public List<PozycjaZamowienia> pozycjeZamowienia { get; set; }
        public int klientId { get; set; }
        public int AdresdostawyId { get; set; }

        public int ZamowienieId { get; private set; }
        public DateTimeOffset? DataZamowienie { get; set; }
        /// <summary>
        /// Pobieramy jedno zamowienie
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public Zamowienie Pobierz (int zamowienieId)
        {
            return new Zamowienie ();
        }
        /// <summary>
        /// Zapisujemy bierzące zamowienie
        /// </summary>
        /// <returns></returns>
        public bool Zapisz ()
        {
            return true;
        }

        public bool Zwaliduj ()
        {
            var poprawne = true;
            if (DataZamowienie == null)
            {
                poprawne = false;

            }
            return poprawne;
        }
    }
}