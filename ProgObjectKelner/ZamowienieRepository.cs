using System;
namespace ProgObjectKelner
{
    public class ZamowienieRepository
    {
         /// <summary>
        /// Pobieramy jedną pozycje zamowienia
        /// </summary>
        /// <param name="pozycjaZamowieniaId"></param>
        /// <returns></returns>
        public Zamowienie Pobierz (int pozycjaZamowieniaId) {

            //tworzymu zamowienie
            Zamowienie zamowienie = new Zamowienie(pozycjaZamowieniaId);
            if (pozycjaZamowieniaId == 10)
            {
                zamowienie.DataZamowienie = new DateTimeOffset(2016,4,23,10,00,00,00,new TimeSpan(7,0,0));
                
            }

            return zamowienie;
        }
        /// <summary>
        /// Zapisujemy biezaczy element zamowienia
        /// </summary>
        /// <returns></returns>
        public bool Zapisz () {
            return true;
        }
    }
}