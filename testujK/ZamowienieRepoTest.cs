using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgObjectKelner;
namespace testujK
{
    [TestClass]
    public class ZamowienieRepoTest
    {
        [TestMethod]
        public void PobierzZamowienie ()
        {
            var zamowienieRepoi = new ZamowienieRepository ();

            var oczekiwana = new Zamowienie (10)
            {
                DataZamowienie = new DateTimeOffset (2016, 4, 23, 10, 00, 00, 00, new TimeSpan (7, 0, 0))
            };

            var aktualna = zamowienieRepoi.Pobierz (10);

            Assert.AreEqual (oczekiwana.DataZamowienie, aktualna.DataZamowienie);
            Assert.AreEqual (oczekiwana.ZamowienieId, aktualna.ZamowienieId);

        }

        [TestMethod]
        public void PobierzZamowienieDoWyswietleniaTest ()
        {
            var zamowienieRepoi = new ZamowienieRepository ();

            var oczekiwana = new WyswietlanieZamowienia ()
            {
                imie = "Pietrek",
                nazwisko = "Kowalik",
                datazamowienia = new DateTimeOffset (2018, 4, 14, 10, 00, 00, 00, new TimeSpan (7, 0, 0)),
                adresDostawy = new Adres ()
                {
                AdresTyp = 1,
                Ulica = "kosmiczna",
                Miasto = "Katowice",
                KodPocztowy = "40-467",
                Kraj = "Polska",

                },
                WyswietlaniePozycjiZamowieniaLista = new List<WyswietlaniePozycjiZamowienia> ()
                {
                new WyswietlaniePozycjiZamowienia ()
                {
                nazwaProduktu = "Krzesło",
                iloscZamowienia = 4,
                cenaZakupu = 199.77m

                },
                new WyswietlaniePozycjiZamowienia ()
                {
                nazwaProduktu = "Stolik",
                iloscZamowienia = 7,
                cenaZakupu = 249m

                }

                }
            };

            var aktualna = zamowienieRepoi.PobierzZamowienieDoWyswietlenia (10);

            Assert.AreEqual (oczekiwana.zamowienieId, aktualna.zamowienieId);
            Assert.AreEqual (oczekiwana.datazamowienia, aktualna.datazamowienia);
            Assert.AreEqual (oczekiwana.imie, aktualna.imie);
            Assert.AreEqual (oczekiwana.nazwisko, aktualna.nazwisko);
            Assert.AreEqual (oczekiwana.adresDostawy.AdresTyp, aktualna.adresDostawy.AdresTyp);
            Assert.AreEqual (oczekiwana.adresDostawy.Ulica, aktualna.adresDostawy.Ulica);
            Assert.AreEqual (oczekiwana.adresDostawy.Miasto, aktualna.adresDostawy.Miasto);
            Assert.AreEqual (oczekiwana.adresDostawy.KodPocztowy, aktualna.adresDostawy.KodPocztowy);
            Assert.AreEqual (oczekiwana.adresDostawy.Kraj, aktualna.adresDostawy.Kraj);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual (oczekiwana.WyswietlaniePozycjiZamowieniaLista[i].nazwaProduktu, aktualna.WyswietlaniePozycjiZamowieniaLista[i].nazwaProduktu);
                Assert.AreEqual (oczekiwana.WyswietlaniePozycjiZamowieniaLista[i].iloscZamowienia, aktualna.WyswietlaniePozycjiZamowieniaLista[i].iloscZamowienia);
                Assert.AreEqual (oczekiwana.WyswietlaniePozycjiZamowieniaLista[i].cenaZakupu, aktualna.WyswietlaniePozycjiZamowieniaLista[i].cenaZakupu);
            }
        }

    }
}