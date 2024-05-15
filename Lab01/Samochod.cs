namespace Lab01
{
    class Samochod
    {
        private string marka;
        private string model;
        private int iloscDrzwi;
        private double pojemnoscSilnika;
        private double srednieSpalanie;
        private static int iloscSamochodow = 0;
        private string numerRejestracyjny;


        public string Marka
        {
            get { return this.marka; }
            set { this.marka = value; }
        }
        public String Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public int IloscDrzwi
        {
            get { return this.iloscDrzwi; }
            set { this.iloscDrzwi = value; }
        }
        public double PojemnoscSilnika
        {
            get { return this.pojemnoscSilnika; }
            set { this.pojemnoscSilnika = value; }
        }
        public double SrednieSpalanie
        {
            get { return this.srednieSpalanie; }
            set { this.srednieSpalanie = value; }
        }

        public Samochod()
        {
            this.marka = "nieznana";
            this.model = "nieznany";
            this.iloscDrzwi = 0;
            this.pojemnoscSilnika = 0.0;
            this.srednieSpalanie = 0.0;
            this.numerRejestracyjny = "nieznana";
            Samochod.iloscSamochodow += 1;
        }

        public Samochod(string marka, string model, int iloscDrzwi, double pojemnoscSilnika, double srednieSpalanie, string numerRejestracyjny)
        {
            this.marka = marka;
            this.model = model;
            this.iloscDrzwi = iloscDrzwi;
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.srednieSpalanie = srednieSpalanie;
            this.numerRejestracyjny = numerRejestracyjny;
            Samochod.iloscSamochodow += 1;

        }

        private double ObliczSpalanie(double dlugoscTrasy)
        {
            return (this.srednieSpalanie * dlugoscTrasy) / 100.0;
        }

        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {
            return ObliczSpalanie(dlugoscTrasy) * cenaPaliwa;
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Marka " + this.Marka);
            Console.WriteLine("Model " + this.Model);
            Console.WriteLine("IloscDrzwi " + this.IloscDrzwi);
            Console.WriteLine("Pojemność Silnika " + this.PojemnoscSilnika);
            Console.WriteLine("Średnie spalanie " + this.SrednieSpalanie);


        }

        public static void WypiszIloscSamochodw()
        {
            Console.WriteLine("Samochodów jest " + Samochod.iloscSamochodow);
        }
    }
}
