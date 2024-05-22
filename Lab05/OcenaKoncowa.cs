namespace Lab05
{
    public class OcenaKoncowa : IInfo
    {

        private double wartosc;
        private string data;
        private Przedmiot przedmiot;

        public OcenaKoncowa()
        {
            this.wartosc = 0.0;
            this.data = "";
            this.przedmiot = null;
        }
        public OcenaKoncowa(double wartosc, string data, Przedmiot przedmiot) 
        {
            this.wartosc = wartosc; 
            this.data = data;
            this.przedmiot = przedmiot;
        }
        public void WypiszInfo()
        {
            Console.WriteLine(przedmiot.ToString() + $" Ocena: {this.wartosc} | Data: {this.data}");
        }

        public override string ToString()
        {
            return przedmiot.ToString() + $" Ocena: {this.wartosc} | Data: {this.data}";
        }
    }
}
