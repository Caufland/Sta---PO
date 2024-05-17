
namespace Lab03
{
    public class Bibliotekarz : Osoba
    {
        private string dataZatrudnienia;
        private double wynagrodzenie;

        public double Wynagrodzenie
        {
            set { value = this.wynagrodzenie; }
            get {  return this.wynagrodzenie;}
        }

        public Bibliotekarz() : base("nieznane", "nieznane") { }
        public Bibliotekarz(string imie, string nazwisko, string dataZatrudnienia, double wynagrodzenie)
        : base(imie,nazwisko)
        {
            this.dataZatrudnienia = dataZatrudnienia;
            this.wynagrodzenie = wynagrodzenie;
        }

        public override string ToString()
        {
            return $"{base.ToString()} \nWynagrodzenie: {this.wynagrodzenie} \nData zatrudnienia: {this.dataZatrudnienia}";
        }
    }
}
