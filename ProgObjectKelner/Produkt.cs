using System;
using Common;

namespace ProgObjectKelner
{
    public class Produkt : KlasaBazowa,ILogowanie
    {
        public Produkt ()
        {

        }

        public Produkt (int productId)
        {
            ProductId = productId;
        }

        public Produkt (int productId, string opis, string nazwaProduktu)
        {
            this.ProductId = productId;
            this.Opis = opis;
            this.NazwaProduktu = nazwaProduktu;

        }
        public int ProductId { get; private set; }
        public Decimal? AktualnaCena { get; set; }
        public string Opis { get; set; }
        private string _NazwaProduktu;
        
        public string NazwaProduktu
        {
            
            get {
                return _NazwaProduktu.WstawSpacje();
                //return ObslugaStringa.WstawSpacje(_NazwaProduktu);
            }
            set { _NazwaProduktu = value; }
        }


        /// <summary>
        /// Pobieramy jeden produkt
        /// </summary>
        /// <param name="productId"></param>
        /// <returns>zwraca nowy produkt</returns>
        public Produkt Pobierz (int productId)
        {
            //kod który pobiera zdefiniowany produkt
            return new Produkt ();
        }

        /// <summary>
        /// Zapisujemy bierzący produkt
        /// </summary>
        /// <param name="productId"></param>
        /// <returns>zwraca nowy produkt</returns>
        public bool Zapisz ()
        {
            //kod który zapisuje zdefiniowany produkt
            return true;
        }
        /// <summary>
        /// sprawdzamy dane produkt
        /// </summary>
        /// <returns></returns>
        public override bool Zwaliduj ()
        {
            var poprawne = true;
            if (string.IsNullOrWhiteSpace (NazwaProduktu))
                poprawne = false;

            return poprawne;
        }

        public override string ToString ()
        {
            return NazwaProduktu;
        }

        public string Log()
        {
            var logTekst = ProductId + ": " +
                            NazwaProduktu + " " +
                            "Opis: " + Opis +" " +
                            "Status: " + StanObiektu.ToString();
            return logTekst;
        }
        
    }
}