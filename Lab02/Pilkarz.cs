namespace Lab02
{
    public class Pilkarz : Osoba
    {
        private string pozycja;
        private string klub;
        private int liczbaGoli;

        public Pilkarz(string imie, string nazwisko, string dataUrodzenia, string pozycja, string klub)
                        : base(imie, nazwisko, dataUrodzenia)
        {
            this.pozycja = pozycja;
            this.klub = klub;
        }

        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine($"Pozycja: {this.pozycja}");
            Console.WriteLine($"Klub: {this.klub}");
            Console.WriteLine($"Liczba Goli: {this.liczbaGoli}");
        }

        public virtual void StrzelGola()
        {
            this.liczbaGoli++;
        }
    }
}
