namespace Lab05
{
    public class Jednostka : IInfo
    {
        private string nazwa;
        private string adres;
        private List<Wykladowca> wykladowcy;

        public Jednostka(string nazwa, string adres)
        {
            this.nazwa = nazwa;
            this.adres = adres;
            this.wykladowcy = new List<Wykladowca>();
        }

        public string Nazwa
        {
            get { return this.nazwa; }
        }
        public string Adres
        {
            get { return this.adres; }
        }

        public List<Wykladowca> Wykladowcy
        {
            get { return this.wykladowcy; }
        }

        public void DodajWykladowce(Wykladowca wykladowca)
        {
            this.wykladowcy.Add(wykladowca);
        }

        public bool UsunWykladowce(Wykladowca wykladowca)
        {
            return this.wykladowcy.Remove(wykladowca);
        }
        public bool UsunWykladowce(string imie, string nazwisko)
        {
            foreach (var wykladowca in this.Wykladowcy)
            {
                if (wykladowca.Imie.Equals(imie) && wykladowca.Nazwisko.Equals(nazwisko))
                    return this.Wykladowcy.Remove(wykladowca);
            }
            return false;
        }

        public void InfoWykladowcy()
        {
            foreach (var wykladowca in this.Wykladowcy)
            {
                Console.WriteLine(wykladowca.ToString());
            }
        }

        public void WypiszInfo()
        { 
            Console.WriteLine($"\nNazwa: {this.nazwa} | Adres: {this.adres}");
        }
    }
}
