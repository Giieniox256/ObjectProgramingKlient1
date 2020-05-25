using System;
using System.Collections.Generic;
using Common;

namespace ProgObjectKelner
{
    public class Zamowienie : KlasaBazowa,ILogowanie
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

        public override bool Zwaliduj ()
        {
            var poprawne = true;
            if (DataZamowienie == null)
            {
                poprawne = false;

            }
            return poprawne;
        }
        
        public override string ToString()
        {
            return DataZamowienie.Value.Date + "(" + ZamowienieId +")";
        }

        public string Log()
        {
            var logTekst = ZamowienieId + ": " + "Date: " + DataZamowienie.Value.Date +
                            " " + "Status: " + StanObiektu.ToString();
            return logTekst;
        }
    }
}