
namespace Lab04
{
    public class Person
    {

        public int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        static int _id = 101;

        public Person(string FirstName, string LastName, int Age)
        {
            this.Id = _id++;
            this.FirstName = FirstName; this.LastName = LastName; this.Age = Age;
        }

        public override string ToString() => $"{FirstName} {LastName} age: {Age} id: {Id}";
    }
}
