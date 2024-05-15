namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba o1 = new Osoba("adam", "mis", "20031980");
            Osoba o2 = new Student("adam", "mis", "20031980", 2, 1, 12345);
            Osoba o3 = new Pilkarz("adam", "mis", "20031980", "obronca", "fc czestochowa");

            o1.WypiszInfo();
            o2.WypiszInfo();
            o3.WypiszInfo();

            Student s = new Student("pod", "poddd", "123994", 2, 5, 54321);
            Pilkarz p = new Pilkarz("adam", "mis", "20031980", "napastinik", "ksradlna");

            s.WypiszInfo();
            p.WypiszInfo();

            ((Pilkarz)o3).StrzelGola();
            p.StrzelGola();
            p.StrzelGola();

            o3.WypiszInfo();
            p.WypiszInfo();

            Console.WriteLine("**DRUGIE ZADANIE*");

            ((Student)o2).DodajOcene("PO", "20.02.2011", 5.0);
            ((Student)o2).DodajOcene("Bazy Dancyh", "13.02.2011", 4.0);

            o2.WypiszInfo();
            Console.WriteLine();

            s.DodajOcene("Bazdy dancyh", "01.05.2011", 5.0);
            s.DodajOcene("AWW", "11.05.2011", 5.0);
            s.DodajOcene("AWW", "02.04.2011", 4.5);

            s.WypiszInfo();
            Console.WriteLine();

            s.UsunOcene("AWW", "02.04.2011", 4.5);

            s.WypiszInfo();
            Console.WriteLine();

            s.DodajOcene("AWW", "02.04.2011", 4.5);
            s.WypiszInfo();
            s.UsunOceny("AWW");

            s.WypiszInfo();

            s.DodajOcene("AWW", "02.04.2011", 4.5);
            s.UsunOceny();

            s.WypiszInfo();
        }
    }
}