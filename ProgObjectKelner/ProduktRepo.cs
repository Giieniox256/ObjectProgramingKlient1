namespace ProgObjectKelner
{
    public class ProduktRepo
    {
         /// <summary>
        /// Pobieramy jeden produkt
        /// </summary>
        /// <param name="productId"></param>
        /// <returns>zwraca nowy produkt</returns>
        public Produkt Pobierz (int productId) {

            Produkt produkt = new Produkt(productId);
            //kod który pobiera zdefiniowany produkt

            //tymczasowe zakodowane wartosści
            if (productId == 2)
            {
                produkt.NazwaProduktu = "klocki";
                produkt.Opis = "klocki do zabawy dla dzieci powyej 3 lat";
                produkt.AktualnaCena = 120;
            }
            return produkt;
        }

        /// <summary>
        /// Zapisujemy bierzący produkt
        /// </summary>
        /// <param name="productId"></param>
        /// <returns>zwraca nowy produkt</returns>
        public bool Zapisz () {
            //kod który zapisuje zdefiniowany produkt
            return true;
        }


    }
}