
namespace Lab02
{
    public class PilkazNozny : Pilkarz
    {
        public PilkazNozny(string imie, string nazwisko, string dataUrodzenia, string pozycja, string klub)
            : base(imie, nazwisko, dataUrodzenia, pozycja, klub)
        {

        }

        public override void StrzelGola()
        {
            base.StrzelGola();

            Console.WriteLine("Nożny strzelił!");
        }
    }
}
