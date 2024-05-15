namespace Lab02
{
    public class Student : Osoba
    {

        private int rok;
        private int grupa;
        private int nrIndeksu;
        private List<Ocena> oceny;

        public Student(string imie, string nazwisko, string dataUrodzenia,int rok, int grupa, int nrIndeksu)
                : base(imie, nazwisko, dataUrodzenia)
        {
            this.rok = rok;
            this.grupa = grupa; 
            this.nrIndeksu = nrIndeksu;
            this.oceny = new List<Ocena>();
        }

        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine($"Rok: {this.rok}");
            Console.WriteLine($"Grupa: {this.grupa}");
            Console.WriteLine($"Numer Indeksu: {this.nrIndeksu}");

            this.WypiszOceny();
        }
        
        public void DodajOcene(string nazwaPrzedmiotu,string data, double wartosc)
        {
            oceny.Add(new Ocena(nazwaPrzedmiotu,data, wartosc));
        }
        public void WypiszOceny()
        {
            foreach (var ocena in oceny)
            {
                ocena.WypiszInfo();
            }
        }
        public void WypiszOceny(string nazwaPrzedmiotu)
        {
            foreach (var ocena in oceny)
            {
                if (ocena.NazwaPrzedmiotu == nazwaPrzedmiotu)
                {
                    ocena.WypiszInfo();
                }
            }
        }

        public void UsunOceny()
        {
            oceny.Clear();
        }

        public void UsunOceny(string nazwaPrzedmiotu)
        {
            for (int i = oceny.Count -1; i >= 0; i--)
            {
                if (oceny[i].NazwaPrzedmiotu == nazwaPrzedmiotu)
                {
                    oceny.Remove(oceny[i]);
                }
            }
        }
        public void UsunOcene(string nazwaPrzedmiotu, string data, double wartosc)
        {
            for (int i = 0; i < oceny.Count; i++)
            {
                if (oceny[i].NazwaPrzedmiotu == nazwaPrzedmiotu &&
                    oceny[i].Data == data &&
                    oceny[i].Wartosc == wartosc)
                {
                    oceny.RemoveAt(i);
                }
            }
        }
        
    }
}
