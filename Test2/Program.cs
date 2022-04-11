class Program
{
    static void Main(string[] args)
    {
        Tasks FirstTask = new Tasks();
        //https://edabit.com/challenge/xfRucdwGksiyjZq4K
        System.Console.WriteLine(FirstTask.SummTwoNumbers(2, 7));
        //https://edabit.com/challenge/bizjGL4wyd8PwR4Ke
        System.Console.WriteLine(FirstTask.ConvertToSeconds(77));
        //https://edabit.com/challenge/nkkKguC5TgWnBiMLA
        System.Console.WriteLine(FirstTask.ConvertAgeToDates(35));
    }
}

public class Tasks
{
    const int Time = 60;
    const int DaisPerYear = 365;

    public int SummTwoNumbers(int a, int b)
    {
        return a + b;
    }

    public int ConvertToSeconds(int Minutes)
    {
        int Seconds = Minutes * Time;
        return Seconds;
    }

    public int ConvertAgeToDates(int Age)
    {
        int AgeInDays = Age * DaisPerYear;
        return AgeInDays;
    }

}



