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
        }
    }
}