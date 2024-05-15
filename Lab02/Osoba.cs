namespace Lab02
{
    public class Osoba
    {

        protected string imie;
        protected string nazwisko;
        protected string dataUrodzenia;

        public Osoba(string imie, string nazwisko, string dataUrodzenia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataUrodzenia = dataUrodzenia;
        }

        public virtual void WypiszInfo() 
        {
            Console.WriteLine($"Imie: {this.imie}");
            Console.WriteLine($"Nazwisko: {this.nazwisko}");
            Console.WriteLine($"Data urodzenia: {this.dataUrodzenia}");
        }

    }
}
