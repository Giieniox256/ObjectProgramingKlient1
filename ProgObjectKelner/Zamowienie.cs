using System;
namespace ProgObjectKelner {
    public class Zamowienie {
        public Zamowienie () {

        }

        public Zamowienie(int zamowienieId)
        {
            ZamowienieId = zamowienieId;
        }

        public int ZamowienieId { get; private set; }
        public DateTimeOffset? DataZamowienie {get;set;}
        /// <summary>
        /// Pobieramy jedno zamowienie
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public Zamowienie Pobierz(int zamowienieId){
            return new Zamowienie();
        }
        /// <summary>
        /// Zapisujemy bierzące zamowienie
        /// </summary>
        /// <returns></returns>
        public bool Zapisz(){
            return true;
        }

        public bool Zwaliduj(){
            var poprawne = true;
            if (DataZamowienie==null )
            {
                poprawne = false;

            }
            return poprawne;
        }
    }
}