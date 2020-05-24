using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgObjectKelner;
namespace testujK
{
    [TestClass]
    public class klrepotest
    {
        [TestMethod]
        public void PobierzKlienta ()
        {

            var KlientRepository = new KlientRepository ();
            var oczekiwana = new Klient (1)
            {
                Email = "klient@dev.com",
                Imie = "Pedro",
                Nazwisko = "Nowakie"

            };

            var aktualna = KlientRepository.Pobierz (1);

            //Assert
            //Assert.AreEqual(oczekiwana, aktualna);
            Assert.AreEqual (oczekiwana.KlientId, aktualna.KlientId);
        }

        [TestMethod]
        public void PobierzKlientaAdres ()
        {

            var KlientRepository = new KlientRepository ();
            var oczekiwana = new Klient (1)
            {
                Email = "klient@dev.com",
                Imie = "Pedro",
                Nazwisko = "Nowakie",
                ListaAdresow = new List<Adres>
                {
                new Adres (1)
                {
                AdresTyp = 1,
                Ulica = "MAtuszczaka",
                Miasto = "Katowice",
                Kraj = "Polska",
                KodPocztowy = "37-220"
                },
                new Adres (2)
                {
                AdresTyp = 2,
                Ulica = "Dworcowa",
                Miasto = "Rzeszow",
                Kraj = "Polska",
                KodPocztowy = "30-220"
                },

                }

            };

            var aktualna = KlientRepository.Pobierz (1);

            //Assert
            //Assert.AreEqual(oczekiwana, aktualna);
            Assert.AreEqual (oczekiwana.KlientId, aktualna.KlientId);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(oczekiwana.ListaAdresow[i].AdresTyp,aktualna.ListaAdresow[i].AdresTyp);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].Ulica,aktualna.ListaAdresow[i].Ulica);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].Miasto,aktualna.ListaAdresow[i].Miasto);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].KodPocztowy,aktualna.ListaAdresow[i].KodPocztowy);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].Kraj,aktualna.ListaAdresow[i].Kraj);
            }

        }

    }
}