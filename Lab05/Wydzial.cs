namespace Lab05
{
    public class Wydzial
    {
        public static List<Przedmiot> Przedmioty { get; private set; }
        public static List<Jednostka> Jednostki { get; private set; }
        public static List<Student> Studenci;

        static Wydzial()
        {
            Przedmioty = new List<Przedmiot>();
            Jednostki = new List<Jednostka>();
            Studenci = new List<Student>();
        }

        public void DodajJednostke(string nazwa, string adres)
        {
            Jednostki.Add(new Jednostka(nazwa,adres));
        }
        
        public void DodajPrzedmiot(Przedmiot przedmiot)
        {
            Przedmioty.Add(przedmiot); 
        }

        public void DodajStudenta(Student student)
        {
            Studenci.Add(student);
        }

        public void InfoStudenci(bool infoOceny)
        {
            foreach (var student in Studenci)
            {
                    student.WypiszInfo();
                if (infoOceny)
                    student.InfoOceny();

            }
        }

        public void InfoJednostki(bool infoWykladowacy)
        {
            foreach (var jednostka in Jednostki)
            {
                jednostka.WypiszInfo();

                if (infoWykladowacy)
                    jednostka.InfoWykladowcy();
            }
        }

        public void InfoPrzedmioty()
        {
            foreach (var przedmiot in Przedmioty)
            {
                przedmiot.WypiszInfo();
            }
        }

        public bool DodajOcene(int nrIndeksu, string nazwaPrzedmiotu, int ocena, string data)
        {
            foreach (var przedmiot in Przedmioty)
            {
                if (przedmiot.Nazwa.Equals(nazwaPrzedmiotu))
                {
                    foreach (var student in Studenci)
                    {
                        if (student.NrIndeks == nrIndeksu)
                        {
                            return student.DodajOcene(nazwaPrzedmiotu, (double)ocena, data);
                        }
                    }
                }
            }
            return false;
        }

        public bool UsunStudenta(int nrIndeksu)
        {
            foreach (var student in Studenci)
            {
                if (student.NrIndeks == nrIndeksu)
                    return Studenci.Remove(student);
            }
            return false;
        }

        public bool PrzeniesWykladowce(Wykladowca wykladowca, string obecnaJednostka, string nowaJednostka)
        { 
            List<Jednostka> jednostkiCopy = new List<Jednostka>(Jednostki);

            foreach (var jednostka in jednostkiCopy)
            {
                if (jednostka.Nazwa.Equals(obecnaJednostka))
                    Jednostki.Remove(jednostka); 

                if (jednostka.Nazwa.Equals(nowaJednostka))
                {
                    jednostka.DodajWykladowce(wykladowca);
                    return true;
                }
            }
            return false;
        }
    }
}
