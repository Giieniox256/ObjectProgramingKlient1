using System.Collections.Generic;
using System;
namespace ProgObjectKelner
{
    public class WyswietlanieZamowienia
    {
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public DateTimeOffset? datazamowienia { get; set; }
        public List<WyswietlaniePozycjiZamowienia> WyswietlaniePozycjiZamowieniaLista{get;set;}
        public int zamowienieId { get; set; }
        public Adres adresDostawy { get; set; }
    }
}