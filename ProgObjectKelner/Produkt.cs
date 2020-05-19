using System;
namespace ProgObjectKelner {
    public class Produkt {
        public Produkt () {

        }

        public Produkt (int productId) {
            ProductId = productId;
        }

        public int ProductId { get; private set; }
        public Decimal? AktualnaCena { get; set; }
        public string Opis { get; set; }
        public string NazwaProduktu { get; set; }

        /// <summary>
        /// Pobieramy jeden produkt
        /// </summary>
        /// <param name="productId"></param>
        /// <returns>zwraca nowy produkt</returns>
        public Produkt Pobierz (int productId) {
            //kod który pobiera zdefiniowany produkt
            return new Produkt ();
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
        /// <summary>
        /// sprawdzamy dane produkt
        /// </summary>
        /// <returns></returns>
        public bool Zwaliduj () {
            var poprawne = true;
            if (string.IsNullOrWhiteSpace (NazwaProduktu))
                poprawne = false;

            return poprawne;
        }
    }
}