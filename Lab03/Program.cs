namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Katalog kat1 = new Katalog("Fajne książki");

            Ksiazka k1 = new Ksiazka("Atomowe nawyki", 0, "Nasza Klasa", 2014, 321);
            Ksiazka k2 = new Ksiazka("Wiedzmin", 2, "Zaraz ci powiem", 2019, 350);

            Czasopismo cz1 = new Czasopismo("Dokąd nocą tupa jeż", 1, "Jakieś zjeby", 2024, 5);

            Bibliotekarz bibliotekarz1 = new Bibliotekarz("czar", "nuch", "dzisiaj", 0);
            Bibliotekarz bibliotekarz2 = new Bibliotekarz("giga", "chad", "wczoraj", 2000.50);

            k1.DodajAutora(new Autor("David", "Goggins", "polska"));

            kat1.DodajPozycje(k1);
            kat1.DodajPozycje(cz1);

            Console.WriteLine("---------teraz biblioteka---------");

            Biblioteka b1 = new Biblioteka("Radlna 92b");
            b1.DodajBibliotekarza(bibliotekarz1);
            b1.DodajBibliotekarza(bibliotekarz2);
            Console.WriteLine("---wyp biblio---");
            b1.WypiszBibliotekarzy();
            b1.UsunBibliotekarza("czar", "nuch");
            Console.WriteLine("---wyp biblio---");
            b1.WypiszBibliotekarzy();
            b1.ZmienWynagrodzenieBibliotekarza("giga", "chad", 4200.42);
            Console.WriteLine("---wyp biblio---");
            b1.WypiszBibliotekarzy();
        }
    }
}
