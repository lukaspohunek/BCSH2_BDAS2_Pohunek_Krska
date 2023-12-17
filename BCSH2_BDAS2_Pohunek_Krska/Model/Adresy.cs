namespace BCSH2_BDAS2_Pohunek_Krska.Model
{
    public class Adresy
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
