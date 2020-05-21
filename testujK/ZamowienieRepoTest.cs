using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgObjectKelner;
namespace testujK
{
    [TestClass]
    public class ZamowienieRepoTest
    {
        [TestMethod]
        public void PobierzZamowienie(){
            var zamowienieRepoi = new ZamowienieRepository();

            var oczekiwana = new Zamowienie(10){
                DataZamowienie = new DateTimeOffset(2016,4,23,10,00,00,00,new TimeSpan(7,0,0))
            };

            var aktualna = zamowienieRepoi.Pobierz(10);
            

            Assert.AreEqual(oczekiwana.DataZamowienie,aktualna.DataZamowienie);
            Assert.AreEqual(oczekiwana.ZamowienieId,aktualna.ZamowienieId);

        
        }

        
    }
}