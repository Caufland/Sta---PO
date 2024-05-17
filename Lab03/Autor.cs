using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public class Autor : Osoba
    {
        private string imie;
        private string nazwisko;
        private string narodowosc;

        public string Imie
        {
            get { return this.imie; }
        }
        public string Nazwisko
        {
            get { return this.nazwisko; }
        }

        public Autor() : base("nieznane", "nieznane") { }
        public Autor(string imie, string nazwisko, string narodowosc)
            : base(imie, nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.narodowosc = narodowosc;
        }


    }
}
