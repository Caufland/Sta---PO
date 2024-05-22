namespace Lab05
{
    public class Student : Osoba
    {

        private string kierunek;
        private string specjalnosc;
        private int rok;
        private int grupa;
        private int nrIndeksu;
        private List<OcenaKoncowa> oceny;

        public int NrIndeks
        {
            get { return this.nrIndeksu; }
        }

        public Student(): base()
        {
            this.kierunek = "";
            this.specjalnosc = "";
            this.rok = 0;
            this.grupa = 0;
            this.nrIndeksu = 0;
            this.oceny = null;
        }

        public Student(string imie, string nazwisko, string dataUrodzenia, string kierunek, string specjalnosc, int rok, int grupa, int nrIndeksu) : base(imie,nazwisko,dataUrodzenia)
        {
            this.kierunek = kierunek;
            this.specjalnosc = specjalnosc;
            this.rok = rok;
            this.grupa = grupa;
            this.nrIndeksu = nrIndeksu;
            this.oceny = new List<OcenaKoncowa>();
        }
        public void WypiszInfo()
        {
            Console.WriteLine(base.ToString() + $"Kierunek: {this.kierunek} | Specjalność: {this.specjalnosc} | Rok: {this.rok} | Grupa: {this.grupa} | Indeks: {this.nrIndeksu}");
        }
        public void InfoOceny()
        {
            foreach (var ocena in oceny)
            {
                Console.WriteLine(ocena.ToString());
            }
        }

        public bool DodajOcene(string nazwaPrzedmiotu, double ocena, string data)
        {
            foreach (var przedmiot in Wydzial.Przedmioty)
            {
                if (przedmiot.Nazwa.Equals(nazwaPrzedmiotu))
                {
                    oceny.Add(new OcenaKoncowa(ocena, data, przedmiot));
                    return true;
                }
            }
            return false;
        }

    }
}
