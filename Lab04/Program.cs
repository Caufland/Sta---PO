namespace Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<String> list = new MyList<String>();

            list.Add("a");
            list.Add("b");
            list.Add("c");

            Console.WriteLine("Przed usunięciem");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine($"Ilość w tablicy: {list.Count}");

            list.RemoveAt(3);

            Console.WriteLine("Po usunięciu");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine( $"Ilość w tablicy: {list.Count}");

        }
    }
}
