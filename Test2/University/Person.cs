namespace Learning.University
{
    internal class Person
    {
        public int age { get; set; }

        public Person()
        {
        }

        public void Greet()
        {
            Console.WriteLine("Hello!");
        }

        public void SetAge(int age)
        {
            this.age = age;
        }
    }
}