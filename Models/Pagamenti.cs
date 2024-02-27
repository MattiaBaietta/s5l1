using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace s5l1.Models
{
    public class Pagamenti
    {
        public string Cfiscale { get; set; }
        public DateOnly Datainizio { get; set; }
        public DateOnly Datafine { get; set; }
        public int Pagamento { get; set; }
        public string Tipo { get; set; }
        public Pagamenti(string cfiscale, DateOnly datainizio, DateOnly datafine, int pagamento, string tipo)
        {
            Cfiscale = cfiscale;
            Datainizio = datainizio;
            Datafine = datafine;
            Pagamento = pagamento;
            Tipo = tipo;
        }



    }
}
