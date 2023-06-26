namespace FinalPV.Models
{
    public class Pago
    {
        public int Id { get; set; }
        public int IdSocio { get; set; }
        public decimal ValorCuota { get; set; }
        public DateTime FechadePago { get; set; }
        public int NroCuota { get; set; }
    }
}
