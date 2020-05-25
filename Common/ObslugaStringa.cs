using System;

namespace Common
{
    public static class ObslugaStringa
    {
        /// <summary>
        /// wstawia spacje przed wielką literą
        /// </summary>
        /// <param name="zrodlo"></param>
        /// <returns></returns>
        public static string WstawSpacje(this string zrodlo)
        {
            string wynik = string.Empty;

            if (!string.IsNullOrWhiteSpace(zrodlo))
            {
                foreach (var litera in zrodlo)
                {
                    if (char.IsUpper(litera))
                    {
                        wynik = wynik.Trim(); //przycinamy wszystkie spacje jakie tam są, a potem dodajemy
                        wynik += " ";
                    }
                    wynik += litera;
                }
                wynik = wynik.Trim();
            }
            return wynik;
        }
    }
}
