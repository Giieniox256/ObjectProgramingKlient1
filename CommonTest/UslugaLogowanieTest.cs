using System;
using System.Collections.Generic;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgObjectKelner;

namespace CommonTest
{
    [TestClass]
    public class UslugaLogowanieTest
    {
        [TestMethod]
        public void PiszDoPlikuTest()
        {
            //Arrange
            var zmienioneElementy = new List<ILogowanie>();

            var klient = new Klient(1)
            {
                Email = "admin@dev",
                Imie = "Pietrek",
                Nazwisko = "Kowalik",
                ListaAdresow = null
            };
            zmienioneElementy.Add(klient as ILogowanie);

            var produkt = new Produkt(2)
            {
                NazwaProduktu = "klocki",
                Opis = "Klocki do zabawy",
                AktualnaCena = 10m
            };
            zmienioneElementy.Add(produkt as ILogowanie);

            //act
            UslugaLogowania.PiszDoPliku(zmienioneElementy);

            //assert
        }
    }
}
