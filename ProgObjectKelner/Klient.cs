using System.Collections.Generic;
using Common;

namespace ProgObjectKelner
{
    public class Klient : KlasaBazowa, ILogowanie
    {
        public Klient () : this (0)
        {

        }

        public Klient (int klientId)
        {
            KlientId = klientId;
            ListaAdresow = new List<Adres> ();
        }

        public List<Adres> ListaAdresow { get; set; }
        public static int licznik { get; set; }

        private string _nazwisko;

        public string Nazwisko
        {
            get
            {
                return _nazwisko;
            }

            set
            {
                _nazwisko = value;
            }
        }

        public string Imie { get; set; }
        public string Email { get; set; }
        public int KlientId { get; private set; }
        public int klientTyp { get; set; }
        /// <summary>
        /// Łączy imie i nazwisko
        /// </summary>
        /// <value></value>
        public string ImieNazwisko
        {
            get
            {
                string imieNazwisko = Imie;
                if (!string.IsNullOrWhiteSpace (Nazwisko))
                {
                    if (!string.IsNullOrWhiteSpace (imieNazwisko))
                    {
                        imieNazwisko += ", ";
                    }
                    imieNazwisko += Nazwisko;
                }

                return imieNazwisko;
            }

        }

        public override bool Zwaliduj ()
        {
            var poprawne = true;

            if (string.IsNullOrWhiteSpace (Nazwisko))
            {
                poprawne = false;
            }
            if (string.IsNullOrWhiteSpace (Email))
            {
                poprawne = false;
            }
            return poprawne;
        }
        /// <summary>
        /// zapisujemy obecnego klienta
        /// </summary>
        /// <returns></returns>
        public bool Zapisz ()
        {
            return true;
        }

        public Klient Pobierz (int klientid)
        {
            //pobieranie klienta
            return new Klient ();
        }

        public List<Klient> Pobierz ()
        {
            //kod ktory pobiera wszystkich klientow
            return new List<Klient> ();

        }

       public  override  string  ToString(){
           return ImieNazwisko;
       }

        public string Log()
        {
            var logTekst = KlientId + ": " +
                            ImieNazwisko + " " +
                            "Eamail: " + Email + " " +
                            "Status: " + StanObiektu.ToString();
            return logTekst;
        }

    }
}