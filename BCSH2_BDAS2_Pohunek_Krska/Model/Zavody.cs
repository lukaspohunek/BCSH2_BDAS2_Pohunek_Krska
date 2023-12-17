namespace BCSH2_BDAS2_Pohunek_Krska.Model
{
    public class Zavody
    {
        public int Id_Zavod { get; set; }
        public string Nazev { get; set; }
        public decimal Startovne { get; set; }
        public DateTime Datum { get; set; }
        public TimeSpan Cas_Start { get; set; }
        public int Id_Adresa { get; set; }
        public int Id_Turnaj { get; set; }
    }
}
