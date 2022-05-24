namespace Learning.Abstract_classes
{
    internal abstract class Animal
    {
        public string Name { get; set; }

        public string GetName()
        {
            Console.WriteLine(Name);

            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public abstract void Eat();
    }
}