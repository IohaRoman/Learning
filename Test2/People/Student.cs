namespace Learning.People
{
    internal class Students : Human
    {
        public Students(string name) : base(name)
        {
            Name = name;
        }

        public void Study()
        {
            Console.WriteLine("Study");
        }
    }
}