namespace Lab05
{
    public class Przedmiot : IInfo
    {
        private string nazwa;
        private string kierunek;
        private string specjalnosc;
        private int semestr;
        private int iloscGodzin;

        public string Nazwa
        {
            get { return this.nazwa; } 
        }

        public Przedmiot()
        {
            this.nazwa = "";
            this.kierunek = "";
            this.specjalnosc = "";
            this.semestr = 0;
            this.iloscGodzin = 0;
        }

        public Przedmiot(string nazwa, string kierunek, string specjalnosc, int semestr, int iloscGodzin)
        {
            this.nazwa = nazwa;
            this.kierunek = kierunek;
            this.specjalnosc = specjalnosc;
            this.semestr = semestr;
            this.iloscGodzin = iloscGodzin;
        }

        public void WypiszInfo()
        {
            Console.WriteLine($"\nPrzedmiot: {this.nazwa} | Kierunek: {this.kierunek} | Specjalnosc: {this.specjalnosc} | Semestr: {this.semestr} | Ilość Godzin: {this.iloscGodzin}");
        }

        public override string ToString()
        {
            return $"\nPrzedmiot: {this.nazwa} | Kierunek: {this.kierunek} | Specjalnosc: {this.specjalnosc} | Semestr: {this.semestr} | Ilość Godzin: {this.iloscGodzin}";
        }
    }
}
