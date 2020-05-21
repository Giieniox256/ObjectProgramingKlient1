using System.Collections.Generic;

namespace ProgObjectKelner
{
    public class KlientRepository
    {
         public bool Zapisz () {
            return true;
        }

        public Klient Pobierz (int klientid) {
            //pobieranie klienta

            Klient klient = new Klient(klientid);

            if (klientid == 1)
            {
                klient.Email = "klient@dev.com";
                klient.Nazwisko = "Nowakie";
                klient.Imie = "Pedro";
            }


            return klient;
        }

        public List<Klient> Pobierz () {
            //kod ktory pobiera wszystkich klientow
            return new List<Klient> ();

        }
    }
}