namespace ProgObjectKelner
{
    public class Klient
    {
        private string _nazwisko;

        public string Nazwisko
        {
            get
            {
                return _nazwisko;
            }

            set
            {
                _nazwisko = value;
            }
        }

        public string Imie{get;set;}
        public string Email { get; set; }
        public int KlientId { get; set; }
        /// <summary>
        /// Łączy imie i nazwisko
        /// </summary>
        /// <value></value>
        public string ImieNazwisko 
        { 
            get
            {
                string imieNazwisko = Imie;
                if(!string.IsNullOrWhiteSpace(Nazwisko))
                {
                    if(!string.IsNullOrWhiteSpace(imieNazwisko))
                    {
                        imieNazwisko += ", ";
                    }
                    imieNazwisko += Nazwisko;
                }
                
                return imieNazwisko;
            } 
        
         }
    }
}