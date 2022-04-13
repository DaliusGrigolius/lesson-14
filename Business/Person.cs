namespace Business
{
    public class Person
    {
        public int Id { get; }
        public string Name { get; }

        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
