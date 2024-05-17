using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public class Biblotekarz : Osoba
    {
        private string dataZatrudnienia;
        private double wynagrodzenie;

        public Biblotekarz() : base("nieznane", "nieznane") { }
        public Biblotekarz(string imie, string nazwisko, string dataZatrudnienia, double wynagrodzenie)
        : base(imie,nazwisko)
        {
            this.dataZatrudnienia = dataZatrudnienia;
            this.wynagrodzenie = wynagrodzenie;
        }
    }
}
