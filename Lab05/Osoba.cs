namespace Lab05
{
    public class Osoba : IInfo
    {

        private string imie;
        private string nazwisko;
        private string dataUrodzenia;

        public string Imie
        {
            get { return this.imie; }
        }

        public string Nazwisko
        {
            get { return this.nazwisko; }
        }

        public Osoba()
        {
            this.imie = "";
            this.nazwisko = "";
            this.dataUrodzenia = "";
        }

        public Osoba(string imie, string nazwisko, string dataUrodzenia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataUrodzenia = dataUrodzenia;
        }
    
        public void WypiszInfo()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"\n\tImie {this.imie} | Nazwisko: {this.nazwisko} | Data Urodzenia: {this.dataUrodzenia}";
        }
    }
}