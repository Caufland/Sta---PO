namespace Lab01
{
    class Garaz
    {
        private String adres;
        private int pojemnosc;
        private int liczbaSamochodow = 0;
        private Samochod[] samochody;

        public string Adres
        {
            set { this.adres = value; }
            get { return this.adres; }
        }
        public int Pojemnosc
        {
            set
            {
                this.pojemnosc = value;
                this.samochody = new Samochod[this.pojemnosc];
            }
            get { return this.pojemnosc; }
        }
        public Garaz()
        {
            this.Adres = "nieznany";
            this.Pojemnosc = 0;
            this.samochody = null;
        }

        public Garaz(String adres_, int pojemnosc_)
        {
            this.Adres = adres_;
            this.Pojemnosc = pojemnosc_;
        }

        public void WprowadzSamochod(Samochod samochod)
        {
            if (this.liczbaSamochodow >= this.Pojemnosc)
            {
                Console.WriteLine("Garaż zapełniony");
                return;
            }
            samochody[this.liczbaSamochodow] = samochod;
            this.liczbaSamochodow += 1;
        }
        public Samochod WyprowadzSamochod()
        {
            if (this.samochody == null || this.liczbaSamochodow == 0)
            {
                Console.WriteLine("Garaż jest pusty");
                return null;
            }

            int pozycja = this.liczbaSamochodow - 1;
            Samochod keepSamochod = samochody[pozycja];
            samochody[pozycja] = null;
            this.liczbaSamochodow -= 1;
            return keepSamochod;
        }
        public void WypiszInfo()
        {
            if (this.samochody == null || this.liczbaSamochodow == 0)
            {
                Console.WriteLine("Garaż jest pusty");
                return;
            }
            foreach (Samochod car in this.samochody)
            {
                if (car != null)
                {
                    car.WypiszInfo();
                }
            }
        }
    }
}
