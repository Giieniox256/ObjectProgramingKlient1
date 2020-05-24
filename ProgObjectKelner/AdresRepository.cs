using System.Collections.Generic;

namespace ProgObjectKelner
{
    public class AdresRepository
    {
        public Adres Pobierz(int adresId)
        {
            Adres adres = new Adres(adresId);

            if (adresId == 1)
            {
                adres.AdresTyp = 1;
                adres.Ulica = "Matuszczaka";
                adres.Kraj = "Polska";
                adres.Miasto = "Katowice";
                adres.KodPocztowy = "37-220";
            }

            return adres;
        }

        public IEnumerable<Adres> PobierzKlientpoID(int klientId)
        {
            var adresList = new List<Adres>();
            Adres adres = new Adres(1)
            {
                AdresTyp = 1,
                Ulica = "MAtuszczaka",
                Miasto = "Katowice",
                Kraj = "Polska",
                KodPocztowy = "37-220"
            };

            adresList.Add(adres);
             adres = new Adres(2)
            {
                AdresTyp = 2,
                Ulica = "Dworcowa",
                Miasto = "Rzeszow",
                Kraj = "Polska",
                KodPocztowy = "30-220"
            };

            adresList.Add(adres);

            return adresList;

            
        }
    }
}