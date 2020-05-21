using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgObjectKelner;

namespace testujK
{
    [TestClass]
    public class ProduktRepoTest
    {
        [TestMethod]
        public void PobierzProdukt(){
            var produktRepo = new ProduktRepo();

            var oczekiwana = new Produkt(2)
            {
                NazwaProduktu = "klocki",
                Opis = "klocki do zabawy dla dzieci powyej 3 lat",
                AktualnaCena = 120,
            };

            var aktulna = produktRepo.Pobierz(2);

            Assert.AreEqual(oczekiwana.NazwaProduktu,aktulna.NazwaProduktu);
            Assert.AreEqual(oczekiwana.Opis,aktulna.Opis);
            Assert.AreEqual(oczekiwana.AktualnaCena,aktulna.AktualnaCena);


            
        }
    }
}