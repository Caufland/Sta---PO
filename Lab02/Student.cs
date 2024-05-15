namespace Lab02
{
    public class Student : Osoba
    {

        private int rok;
        private int grupa;
        private int nrIndeksu;

        public Student(string imie, string nazwisko, string dataUrodzenia,int rok, int grupa, int nrIndeksu)
                : base(imie, nazwisko, dataUrodzenia)
        {
            this.rok = rok;
            this.grupa = grupa; 
            this.nrIndeksu = nrIndeksu;
        }

        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine($"Rok: {this.rok}");
            Console.WriteLine($"Grupa: {this.grupa}");
            Console.WriteLine($"Numer Indeksu: {this.nrIndeksu}");
        }
    }
}
