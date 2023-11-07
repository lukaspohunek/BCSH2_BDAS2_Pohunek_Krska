namespace BCSH2_BDAS2_Pohunek_Krska
{
    public class Entity
    {
        public class Model
        {
            public int Id_model { get; set; }
            public string Nazev { get; set; }
            public string Vyrobce { get; set; }
            public decimal Cena { get; set; }
        }
        public class Kolobezka
        {
            public int Id_kolobezka { get; set; }
            public decimal Hmotnost { get; set; }
            public decimal Sirka_desky { get; set; }
            public decimal Delka_desky { get; set; }
            public decimal Vyska_riditek { get; set; }

        }
        public class Bezna_kolobezka : Kolobezka
        {
            public decimal Prumer_kolecek { get; set; }
        }

        public class Elektrokolobezka : Kolobezka
        {
            public decimal Vykon { get; set; }
            public decimal Kapacita_baterie { get; set; }
        }
        public class Osoba
        {
            public int Id_osoba { get; set; }
            public string Jmeno { get; set; }
            public string Prijmeni { get; set; }
            public DateTime Datum_narozeni { get; set; }
        }

        public class Zavodnik : Osoba
        {
            public decimal Vyska { get; set; }
            public decimal Vaha { get; set; }
        }

        public class Zamestnanec : Osoba
        {
            public string Pozice { get; set; }
            public int Uroven_opravneni { get; set; }
        }
        public class Ucastnik_zavodu
        {
            public int Id_ucastnik_zavodu { get; set; } 
            public int Umisteni { get; set; }
        }

        public class Zamestnanec_zavodu
        {
            public int Id_zamestnanec_zavodu { get; set; }
            public decimal Vyplata { get; set; }
        }
        public class Adresa
        {
            public int Id_adresa { get; set; } 
            public string Stat { get; set; } 
            public string Mesto { get; set; } 
            public string Mestska_cast { get; set; } 
            public string Ulice { get; set; }
            public int Cislo_popisne { get; set; } 
            public int PSC { get; set; } // PSČ (Poštovní směrovací číslo)
            public string Doplnujici_udaj { get; set; } 

        }
    }
}
