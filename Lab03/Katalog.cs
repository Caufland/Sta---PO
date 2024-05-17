
namespace Lab03
{
    public class Katalog : IZarzadzaniePozycjami
    {
        private string dzialTematyczny;
        private List<Pozycja> pozycje;

        public string DzialTematyczny
        {
            get { return this.dzialTematyczny; }
        }

        public List<Pozycja> Pozycje
        {
            get { return this.pozycje; }
        }

        public Katalog() { }

        public Katalog(string działTematyczny)
        {
            this.dzialTematyczny = działTematyczny;
            this.pozycje = new List<Pozycja>();
        }

        public void DodajPozycje(Pozycja pozycja)
        {
            this.pozycje.Add(pozycja);
        }


        public Pozycja ZnajdzPozycjePoTytule(string tytul)
        {
            foreach (var pozycja in pozycje)
            {
                if (pozycja.Tytul.Equals(tytul))
                {
                    return pozycja;
                }
            }

            return null;
        }

        public Pozycja ZnajdzPozycjePoId(int id)
        {
            foreach (var pozycja in pozycje)
            {
                if (pozycja.Id.Equals(id))
                {
                    return pozycja;
                }
            }

            return null;
        }

        public void WypiszWszystkiePozycje()
        {
            Console.WriteLine($"Dział tematyczny: {this.dzialTematyczny}");
            foreach (var pozycja in pozycje)
            {
                pozycja.WypiszInfo();
            }
        }
    }
}
