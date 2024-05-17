namespace Lab03
{
    public interface IZarzadzanieBibliotekarzami
    {
        public void DodajBibliotekarza(Bibliotekarz biblotekarz);
        public void UsunBibliotekarza(string imie, string nazwisko);
        public void WypiszBibliotekarzy();
        public void ZmienWynagrodzenieBibliotekarza(string imie, string nazwisko, double noweWynagrodzenie);
    }
}
