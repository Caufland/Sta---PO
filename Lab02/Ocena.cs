namespace Lab02
{
    public class Ocena
    {
        private string nazwaPrzedmiotu;
        private string data;
        private double wartosc;

        public string NazwaPrzedmiotu
        {
            set { this.nazwaPrzedmiotu = value; }
            get { return this.nazwaPrzedmiotu; }   
        }
        public string Data
        {
            set { this.data = value; }
            get { return this.data; }   
        }
        public double Wartosc
        {
            set { this.wartosc = value; }
            get { return this.wartosc; }   
        }


        public Ocena(string nazwaPrzedmiotu,string data, double wartosc)
        {
            this.nazwaPrzedmiotu = nazwaPrzedmiotu;
            this.wartosc = wartosc;
            this.data = data;
        }

        public void WypiszInfo()
        {
            Console.WriteLine($"Przedmiot: {this.nazwaPrzedmiotu}");
            Console.WriteLine($"Data: {this.data}");
            Console.WriteLine($"Ocena: {this.wartosc}");
        }
    }
}
