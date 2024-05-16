using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public class Autor
    {
        private string imie;
        private string nazwisko;

        public string Imie
        {
            get { return this.imie; }
        }
        public string Nazwisko
        {
            get { return this.nazwisko; }
        }

        public Autor() { }
        public Autor(string imie, string nazwisko) 
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }


    }
}
