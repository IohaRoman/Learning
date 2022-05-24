namespace Learning.People
{
    internal class Human
    {
        public string Name { get; set; }

        public Human(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"name - {Name}";
        }
    }
}