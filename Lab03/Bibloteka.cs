
namespace Lab03
{
    public class Bibloteka : IZarzadzaniePozycjami
    {
        private string adres;
        private List<Biblotekarz> biblotekarze;
        private List<Katalog> katalogi;

        public Bibloteka() 
        {
            this.biblotekarze = null;
            this.katalogi = null;
        }
        
        public Bibloteka(string adres)
        {
            this.adres = adres;
            this.biblotekarze = new List<Biblotekarz>();
            this.katalogi = new List<Katalog>();
        }

        public void DodajBiblotekarza(Biblotekarz biblotekarz)
        {
            this.biblotekarze.Add(biblotekarz);
        }

        public void WypiszBiblotekarzy()
        {
            foreach (var biblotekarz in biblotekarze)
            {
                Console.WriteLine(biblotekarz.ToString());
            }
        }

        public void DodajKatalog(Katalog katalog)
        {
            this.katalogi.Add(katalog);
        }

        public void DodajPozycje(Pozycja p, string dzialTematyczny)
        {
            foreach (var katalog in katalogi)
            {
                if (katalog.DzialTematyczny.Equals(dzialTematyczny))
                {
                    katalog.DodajPozycje(p);
                }
            }
        }

        public Pozycja ZnajdzPozycjePoTytule(string tytul)
        {
            foreach (var katalog in katalogi)
            {
                return katalog.ZnajdzPozycjePoTytule(tytul);
            }
            return null;
        }

        public Pozycja ZnajdzPozycjePoId(int id)
        {
            foreach (var katalog in katalogi)
            {
                return katalog.ZnajdzPozycjePoId(id);
            }
            return null;
        }

        public void WypiszWszystkiePozycje()
        {
            foreach (var katalog in katalogi)
            {

                foreach (var pozycja in katalog.Pozycje)
                {
                    pozycja.WypiszInfo();
                }

            }
        }


}
}
