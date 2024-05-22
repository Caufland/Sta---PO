namespace Lab05
{
    public class Wykladowca : Osoba
    {
        private string tytulNaukowy;
        private string stanowisko;

        public Wykladowca() : base()
        {
        }
        public Wykladowca(string imie, string nazwisko, string dataUrodzenia, string tytulNaukowy, string stanowisko) : base(imie,nazwisko,dataUrodzenia)
        {
            this.tytulNaukowy = tytulNaukowy;
            this.stanowisko = stanowisko;
        }

        public override string ToString()
        {
            return "Wykładowca: "+base.ToString() + $"Tytuł Naukowy: {this.tytulNaukowy} | Stanowisko: {this.stanowisko}";
        }
    }
}
