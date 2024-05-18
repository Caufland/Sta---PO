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

            var list2 = new MyList<Person>
            {
                new Person("Jan", "Kowalski", 12),
                new Person("Ala", "Nowak", 32),
                new Person("Maja", "Marchewka", 14),
                new Person("Jakub", "Kowalski", 17),
                new Person("Janusz", "Nosacz", 65),
            };

            Console.WriteLine("\nosoby");

            int j = 0;

            foreach (Person p in list2) 
            {
                Console.WriteLine($"\t[{++j}]=> {p}");
            }

            Console.WriteLine("\nkobiety:");
            var sublist = list2.Where(e => e.FirstName.EndsWith("a"));
            sublist.ToList().ForEach(e => Console.WriteLine(e));

            Console.ReadKey();

        }
    }
}
