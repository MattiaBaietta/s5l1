namespace s5l1.Models
{
    public static class Database
    {
        private static List<Dipendenti> _Dipendenti = new List<Dipendenti>();
        private static List<Pagamenti> _Pagamenti = new List<Pagamenti>();


        public static void AddDipendenti(string nome, string cognome, string indirizzo, string cfiscale, bool coniugato, int nfigli, string mansione)
        {
            _Dipendenti.Add(new Dipendenti(nome, cognome, indirizzo, cfiscale, coniugato, nfigli, mansione));

        }

        public static void AddPagamento(string cfiscale, DateOnly datainizio, DateOnly datafine, int pagamento, string tipo)
        {
            _Pagamenti.Add(new Pagamenti(cfiscale, datainizio, datafine, pagamento, tipo));
        }

        public static List<Dipendenti> GetDipendenti()
        {
            return _Dipendenti;
        }
        public static List<Pagamenti> GetPagamenti()
        {
            return _Pagamenti;
        }
    }
}
