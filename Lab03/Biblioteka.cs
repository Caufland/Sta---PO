
namespace Lab03
{
    public class Biblioteka : IZarzadzaniePozycjami, IZarzadzanieBibliotekarzami
    {
        private string adres;
        private List<Bibliotekarz> biblotekarze;
        private List<Katalog> katalogi;

        public Biblioteka() 
        {
            this.biblotekarze = null;
            this.katalogi = null;
        }
        
        public Biblioteka(string adres)
        {
            this.adres = adres;
            this.biblotekarze = new List<Bibliotekarz>();
            this.katalogi = new List<Katalog>();
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

        public void DodajBibliotekarza(Bibliotekarz biblotekarz)
        {
            this.biblotekarze.Add(biblotekarz);
        }

        public void WypiszBibliotekarzy()
        {
            foreach (var biblotekarz in biblotekarze)
            {
                Console.WriteLine(biblotekarz.ToString());
            }
        }

        public void UsunBibliotekarza(string imie, string nazwisko)
        {
            Bibliotekarz biblotekarz = ZnajdzBiblotekarza(imie, nazwisko);

            if (biblotekarz == null)
            {
                Console.WriteLine("Nie ma takiego biblotekarza");
                return;
            }

            biblotekarze.Remove(biblotekarz);
        }

        public void ZmienWynagrodzenieBibliotekarza(string imie, string nazwisko, double noweWynagrodzenie)
        {
            Bibliotekarz biblotekarz = ZnajdzBiblotekarza(imie, nazwisko);

            if (biblotekarz == null)
            {
                Console.WriteLine("Nie ma takiego biblotekarza");
                return;
            }

            biblotekarz.Wynagrodzenie = noweWynagrodzenie;

        }

        private Bibliotekarz ZnajdzBiblotekarza(string imie, string nazwisko)
        {
            foreach (var biblotekarz in biblotekarze)
            {
                if (biblotekarz.Imie.Equals(imie) &&
                    biblotekarz.Nazwisko.Equals(nazwisko))
                {
                    return biblotekarz;
                }
            }
            return null;
        }
    }
}
