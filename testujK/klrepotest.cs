using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgObjectKelner;
namespace testujK
{
    [TestClass]
    public class klrepotest
    {
        [TestMethod]
        public void PobierzKlienta(){

            var KlientRepository = new KlientRepository();
            var oczekiwana = new Klient(1){
                Email = "klient@dev.com",
                Imie = "Pedro",
                Nazwisko = "Nowakie"
                
            };

            var aktualna = KlientRepository.Pobierz(1);

            //Assert
            //Assert.AreEqual(oczekiwana, aktualna);
            Assert.AreEqual(oczekiwana.KlientId,aktualna.KlientId);
        }
        
    }
}