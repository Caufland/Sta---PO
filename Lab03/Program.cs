namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Katalog kat1 = new Katalog("Fajne książki");

            Ksiazka k1 = new Ksiazka("Atomowe nawyki", 0, "Nasza Klasa", 2014, 321);

            Czasopismo cz1 = new Czasopismo("Dokąd nocą tupa jeż", 1, "Jakieś zjeby", 2024, 5);

            k1.WypiszInfo();
            k1.DodajAutora(new Autor("David", "Goggins"));
            k1.WypiszInfo();

            cz1.WypiszInfo();

            kat1.DodajPozycje(k1);
            kat1.DodajPozycje(cz1);

            Console.WriteLine($"Znaleziono: {kat1.ZnajdzPozycjePoTytule("Atomowe nawyki").Tytul}");

            kat1.WypiszWszystkiePozycje();
        }
    }
}
