namespace Lab03
{
    public interface IZarzadzaniePozycjami
    {
        public Pozycja ZnajdzPozycjePoTytule(string tytul);
        public Pozycja ZnajdzPozycjePoId(int id);
        public void WypiszWszystkiePozycje();

    }
}
