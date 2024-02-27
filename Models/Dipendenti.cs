namespace s5l1.Models
{
    public class Dipendenti
    {

        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Indirizzo { get; set; }
        public string Cfiscale { get; set; }
        public bool Coniugato { get; set; }
        public int Nfigli { get; set; }
        public string Mansione { get; set; }
        public Dipendenti(string nome, string cognome, string indirizzo, string cfiscale, bool coniugato, int nfigli, string mansione)
        {
            Nome = nome;
            Cognome = cognome;
            Indirizzo = indirizzo;
            Cfiscale = cfiscale;
            Coniugato = coniugato;
            Nfigli = nfigli;
            Mansione = mansione;
        }


    }
}
