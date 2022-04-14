using Learning;
class Program
{
    static void Main(string[] args)
    {
        Tasks FirstTask = new Tasks();
        Tasks SecondTask = new Tasks();
        Tasks ThirdTask = new Tasks();
        Tasks FourthTask = new Tasks();
        //https://edabit.com/challenge/xfRucdwGksiyjZq4K
        Console.WriteLine(FirstTask.SummTwoNumbers(2, 7));
        //https://edabit.com/challenge/bizjGL4wyd8PwR4Ke
        Console.WriteLine(FirstTask.ConvertToSeconds(77));
        //https://edabit.com/challenge/nkkKguC5TgWnBiMLA
        Console.WriteLine(FirstTask.ConvertAgeToDates(35));
        //https://edabit.com/challenge/kMWmiNJM4szSv7dLd
        Console.WriteLine(SecondTask.FindSmallestBiggestNumbers(new int[] { 1, 2, 78, 4, 5, 33, 67, 77 }));
        //https://edabit.com/challenge/uevxL5FNM77otyo9Z
        Console.WriteLine(SecondTask.ConvertNumberToCorrespondingMonthName(11));
        //https://edabit.com/challenge/99oN5igrbXddAjHEL
        Console.WriteLine(SecondTask.ReverseOfCase("MANY THankS"));
        //https://edabit.com/challenge/6qFnpAhd3kdmYcNG2
        Console.WriteLine(SecondTask.ReturntheIndexOfAllCapitalLetters("STRiKE"));
        //https://edabit.com/challenge/g88PKZrCY6sWPBva7
        Console.WriteLine(ThirdTask.TrackRobot(new string[] {"right 10", "up 50", "left 30", "down 10", "up 5002"}));
        //https://edabit.com/challenge/HfpK34Ty4SZhN2d9e
        Console.WriteLine(FourthTask.NewDrivingLicense("Zebediah", 1, "Bob Jim Becky Pat"));
        //https://edabit.com/challenge/y4esBva2cYph5QKg5
        Console.WriteLine(FourthTask.AWeekLater("05/29/2005"));
        //https://edabit.com/challenge/X3btpQQEBeezX4jhK
        Console.WriteLine(FourthTask.CupSwapping(new string[] {"BA", "AC", "CA", "BC"}));
    }
}