using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgObjectKelner;

namespace testujK
{
    [TestClass]
    public class Klientest
    {
        [TestMethod]
        public void ImieNazwiskoTest()
        {
            //arrange (zaaranuj test)
            Klient klient = new Klient();
            klient.Imie = "Arek";
            klient.Nazwisko = "Nowak";
            string oczekiwana = "Arek, Nowak";
            //Act (działaj)
            string aktualna = klient.ImieNazwisko;
            //Assert
            Assert.AreEqual(oczekiwana,aktualna);
        }
         [TestMethod]
        public void ImieNazwiskoImiePuste()
        {
            //arrange (zaaranuj test)
            Klient klient = new Klient();
            klient.Nazwisko = "Nowak";
            string oczekiwana = "Nowak";
            //Act (działaj)
            string aktualna = klient.ImieNazwisko;
            //Assert
            Assert.AreEqual(oczekiwana,aktualna);
        }

         [TestMethod]
        public void ImieNazwiskoPuste()
        {
            //arrange (zaaranuj test)
            Klient klient = new Klient();
            klient.Imie = "Arek";
            string oczekiwana = "Arek";
            //Act (działaj)
            string aktualna = klient.ImieNazwisko;
            //Assert
            Assert.AreEqual(oczekiwana,aktualna);
        }
        [TestMethod]
        public void StaticTest()
        {
            //arrange (zaaranuj test)
            Klient klient = new Klient();
            klient.Imie = "Marian";
            Klient.licznik += 1;

            Klient klient2 = new Klient();
            klient2.Imie = "Jacek";
            Klient.licznik += 1;

            Klient klient3 = new Klient();
            klient3.Imie = "Władek";
            Klient.licznik += 1;

            //Assert
            Assert.AreEqual(3,Klient.licznik);
        }

        [TestMethod]
        public void ZwalidujTest()
        {
            //arrange (zaaranuj test)
            var klient = new Klient();
            klient.Nazwisko = "Nowak";
            klient.Email = "nowak@dev.pl";
            var oczekiwana = true;
            //ACT działaj
            var aktualna = klient.Zwaliduj();
            //Assert
            Assert.AreEqual(oczekiwana,aktualna);
        }

          [TestMethod]
        public void ZwalidujbrakNazwiskaTest()
        {
            //arrange (zaaranuj test)
            var klient = new Klient();
            klient.Email = "nowak@dev.pl";
            var oczekiwana = false;
            //ACT działaj
            var aktualna = klient.Zwaliduj();
            //Assert
            Assert.AreEqual(oczekiwana,aktualna);
        }

    }
}
