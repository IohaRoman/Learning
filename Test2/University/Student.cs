namespace Learning.University
{
    internal class Student : Person
    {
        public Student()
        {
        }

        public void Print()
        {
            Console.WriteLine("I'm studying");
        }

        public void ShowAge()
        {
            Console.WriteLine("My age is: " + age + " years old");
        }
    }
}