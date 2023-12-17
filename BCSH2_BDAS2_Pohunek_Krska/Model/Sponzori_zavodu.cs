namespace BCSH2_BDAS2_Pohunek_Krska.Model
{
    public class Sponzori_zavodu
    {
        public int Id_Sponzor_Zavodu { get; set; }
        public decimal Prispevek { get; set; }
        public int Id_Sponzor { get; set; }
        public int Id_Zavod { get; set; }
    }
}
