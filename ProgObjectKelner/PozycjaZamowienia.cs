namespace ProgObjectKelner {
    public class PozycjaZamowienia {
        public PozycjaZamowienia () {

        }

        public PozycjaZamowienia (int pozycjaZamowieniaId) {
            PozycjaZamowieniaId = pozycjaZamowieniaId;
        }

        public int PozycjaZamowieniaId { get; private set; }
        public int ilosc { get; set; }
        public int ProduktId { get; set; }
        public decimal? CenaZakupu { get; set; }
        /// <summary>
        /// Pobieramy jedną pozycje zamowienia
        /// </summary>
        /// <param name="pozycjaZamowieniaId"></param>
        /// <returns></returns>
        public PozycjaZamowienia Pobierz (int pozycjaZamowieniaId) {
            return new PozycjaZamowienia ();
        }
        /// <summary>
        /// Zapisujemy biezaczy element zamowienia
        /// </summary>
        /// <returns></returns>
        public bool Zapisz () {
            return true;
        }
        /// <summary>
        /// Sprawdzamy dane w pozycji zamowienia
        /// </summary>
        /// <returns></returns>
        public bool Zwaliduj () {

            var poprawne = true;

            if (ilosc <= 0)
                poprawne = true;
            if (ProduktId <= 0)
                poprawne = false;
            if (CenaZakupu == null)
                poprawne = false;

            return poprawne;
        }
    }
}