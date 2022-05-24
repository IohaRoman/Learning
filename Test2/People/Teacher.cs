namespace Learning.People
{
    internal class Teachers : Human
    {
        public Teachers (string name) : base(name)
        {
            Name = name;
        }

        public void Explain()
        {
            Console.WriteLine("Explain");
        }
    }
}