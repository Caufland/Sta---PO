
namespace Lab03
{
    public class Katalog 
    {
        private string działTematyczny;
        private List<Pozycja> pozycje;

        public Katalog() { }

        public Katalog(string działTematyczny)
        {
            this.działTematyczny = działTematyczny;
            this.pozycje = new List<Pozycja>();
        }

        public void DodajPozycje(Pozycja pozycja)
        {
            this.pozycje.Add(pozycja);
        }

        public Pozycja ZnajdzPozycje(string tytul)
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

        public void WypiszWszystkiePozycje()
        {
            Console.WriteLine($"Dział tematyczny: {this.działTematyczny}");
            foreach (var pozycja in pozycje)
            {
                pozycja.WypiszInfo();
            }
        }
    }
}
