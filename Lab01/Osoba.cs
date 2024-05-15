namespace Lab01
{
    class Osoba
    {
        private string imie;
        private string nazwisko;
        private string adresZamieszkania;
        private int iloscSamochodow = 0;
        private string[] samochody;

        public Osoba()
        {
            samochody = null;

        }

        public Osoba(string imie, string nazwisko, string adresZamieszkania)
        {
            this.samochody = new string[3];
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.adresZamieszkania = adresZamieszkania;
        }

        public void DodajSamochod(string numerRejestracyjny)
        {
            if (this.iloscSamochodow >= 3)
            {
                Console.WriteLine("Nie możesz mieć więcej samochodów");
                return;
            }


            for (int i = 0; i < this.samochody.Length; i++)
            {
                if (this.samochody[i] == null)
                {
                    this.samochody[i] = numerRejestracyjny;
                    this.iloscSamochodow++;
                    return;
                }

            }

        }
        public void UsunSamochod(string numerRejestracyjny)
        {

            for (int i = 0; i < this.samochody.Length; i++)
            {
                if (this.samochody[i] == numerRejestracyjny)
                {
                    this.samochody[i] = null;
                    this.iloscSamochodow -= 1;
                }
            }

        }
        public void WypiszInfo()
        {
            Console.WriteLine($"Imię: {this.imie}");
            Console.WriteLine($"Naziwsko: {this.nazwisko}");
            Console.WriteLine($"Adres zamieszkania: {this.adresZamieszkania}");
            Console.WriteLine($"Ilość samochodów: {this.iloscSamochodow}");

            foreach (var numer in samochody)
            {
                Console.WriteLine($"Samochód o numerze rejestracyjnym: {numer} ");
            }
        }
    }
}
