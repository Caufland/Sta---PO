namespace Lab03
{
    public class Osoba
    {
        protected string imie;
        protected string nazwisko;

        public string Imie
        {
            get { return this.imie; }
        }
        public string Nazwisko
        {
            get { return this.nazwisko; }
        }

        public Osoba() { }
        public Osoba(string imie, string nazwisko) 
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public override string ToString()
        {
            return $"Imię: {this.imie} \nNazwisko: {this.nazwisko}";
        }

    }


}
