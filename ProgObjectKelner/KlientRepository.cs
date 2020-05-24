using System.Collections.Generic;
using System.Linq;

namespace ProgObjectKelner
{
    public class KlientRepository
    {
        private AdresRepository adresrepository { get; set; }
        public KlientRepository ()
        {
            adresrepository = new AdresRepository ();
        }
        public bool Zapisz ()
        {
            return true;
        }

        public Klient Pobierz (int klientid)
        {
            //pobieranie klienta

            Klient klient = new Klient (klientid);
            klient.ListaAdresow = adresrepository.PobierzKlientpoID (klientid).ToList ();

            if (klientid == 1)
            {
                klient.Email = "klient@dev.com";
                klient.Nazwisko = "Nowakie";
                klient.Imie = "Pedro";
            }

            return klient;
        }

        public List<Klient> Pobierz ()
        {
            //kod ktory pobiera wszystkich klientow
            return new List<Klient> ();

        }
    }
}