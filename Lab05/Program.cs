namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tworzymy instancję klasy Wydzial
            Wydzial wydzial = new Wydzial();

            // Tworzymy kilka przykładowych przedmiotów
            Przedmiot matematyka = new Przedmiot("Matematyka", "Matematyka", "Podstawowa", 1, 30);
            Przedmiot fizyka = new Przedmiot("Fizyka", "Fizyka", "Podstawowa", 1, 30);

            // Tworzymy kilka przykładowych jednostek
            Jednostka matematykaJednostka = new Jednostka("Wydział Matematyki", "Kraków");
            Jednostka fizykaJednostka = new Jednostka("Wydział Fizyki", "Kraków");

            // Tworzymy kilka przykładowych studentów
            Student student1 = new Student("Jan", "Kowalski", "1998-05-10", "Informatyka", "Programowanie", 2, 1, 12345);
            Student student2 = new Student("Anna", "Nowak", "1999-07-15", "Informatyka", "Sieci komputerowe", 1, 2, 54321);

            // Dodajemy przedmioty, jednostki i studentów do wydziału
            wydzial.DodajPrzedmiot(matematyka);
            wydzial.DodajPrzedmiot(fizyka);

            wydzial.DodajJednostke(matematykaJednostka.Nazwa, matematykaJednostka.Adres);
            wydzial.DodajJednostke(fizykaJednostka.Nazwa, fizykaJednostka.Adres);

            wydzial.DodajStudenta(student1);
            wydzial.DodajStudenta(student2);

            // Wyświetlamy informacje o wszystkich studentach, jednostkach i przedmiotach
            Console.WriteLine("Informacje o studentach:");
            wydzial.InfoStudenci(infoOceny: true);

            Console.WriteLine("\nInformacje o jednostkach:");
            wydzial.InfoJednostki(infoWykladowacy: true);

            Console.WriteLine("\nInformacje o przedmiotach:");
            wydzial.InfoPrzedmioty();

            // Przenosimy wykładowcę z jednostki matematyki do jednostki fizyki
            Wykladowca wykladowca = new Wykladowca("Adam", "Nowak", "1975-03-20", "dr", "adiunkt");
            wydzial.PrzeniesWykladowce(wykladowca, "Wydział Matematyki", "Wydział Fizyki");

            // Ponownie wyświetlamy informacje o jednostkach
            Console.WriteLine("\nAktualizowane informacje o jednostkach po przeniesieniu wykładowcy:");
            wydzial.InfoJednostki(infoWykladowacy: true);
        }
    }
}
