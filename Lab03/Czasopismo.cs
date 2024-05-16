
namespace Lab03
{
    public class Czasopismo : Pozycja
    {
        private int numer;

        public Czasopismo() { }
        public Czasopismo(string tytul, int id, string wydawnictwo, int rokWydania, int numer)
            :base(tytul, id, wydawnictwo, rokWydania)
        {
            this.numer = numer;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine($"Tytuł: {tytul}\nId: {id}\nWydawnictwo: {wydawnictwo}\nRok wydania: {rokWydania}\nNumer: {numer}\n>>>>>>>>>>>>>>");
        }
    }
}
