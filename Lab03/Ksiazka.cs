
namespace Lab03
{
    public class Ksiazka : Pozycja
    {
        private int liczbaStron;
        private List<Autor> autorzy;

        public Ksiazka() { }
        public Ksiazka(string tytul, int id, string wydawnictwo, int rokWydania, int liczbaStron)
        : base(tytul,id,wydawnictwo,rokWydania)
        {
            this.liczbaStron = liczbaStron;
            this.autorzy = new List<Autor>();
        }

        public void DodajAutora(Autor autor)
        {
            this.autorzy.Add(autor);
        }

        public override void WypiszInfo()
        {
            Console.WriteLine($"Tytuł: {tytul}\nId: {id}\nWydawnictwo: {wydawnictwo}\nRok wydania: {rokWydania}\nLiczba stron: {liczbaStron}\n>>>>>>>>>>>>>>");
            foreach (var autor in autorzy)
            {
                Console.WriteLine($"Autor: {autor.Imie} {autor.Nazwisko}");
            }
        }

    }
}
