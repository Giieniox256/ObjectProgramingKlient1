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
    }
}
