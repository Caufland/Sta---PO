
namespace Lab02
{
    public class PilkazReczny : Pilkarz
    {
        public PilkazReczny(string imie, string nazwisko, string dataUrodzenia, string pozycja, string klub) 
            : base(imie, nazwisko, dataUrodzenia, pozycja, klub) 
        {

        }

        public override void StrzelGola()
        {
            base.StrzelGola();

            Console.WriteLine("Ręczny strzelił!");
        }
    }
}
