using Learning;
using Learning.University;
using Learning.Photo_book;
using Learning.People;
using Learning.Interfaces;
using Learning.Abstract_classes;

class Program
{
    static void Main(string[] args)
    {
        Tasks FirstTask = new Tasks();
        Tasks SecondTask = new Tasks();
        Tasks ThirdTask = new Tasks();
        Tasks FourthTask = new Tasks();
        Tasks FifthTask = new Tasks();
        Tasks SixthTask = new Tasks();
        Tasks SeventhTask = new Tasks();
        Smoothie MakeSmoothie = new Smoothie(new string[] { "Raspberries", "Strawberries", "Blueberries" });
        Fractional Compare = new Fractional(123.14);
        Fractional Compare2 = new Fractional(1.10);
        TemplateList TemplateList = new TemplateList();
        Money Money = new Money(13, 50);
        Money Money2 = new Money(12, 56);
        #region
        ////https://edabit.com/challenge/xfRucdwGksiyjZq4K
        //Console.WriteLine(FirstTask.SummTwoNumbers(2, 7));
        ////https://edabit.com/challenge/bizjGL4wyd8PwR4Ke
        //Console.WriteLine(FirstTask.ConvertToSeconds(77));
        ////https://edabit.com/challenge/nkkKguC5TgWnBiMLA
        //Console.WriteLine(FirstTask.ConvertAgeToDates(35));
        ////https://edabit.com/challenge/kMWmiNJM4szSv7dLd
        //Console.WriteLine(SecondTask.FindSmallestBiggestNumbers(new int[] { 1, 2, 78, 4, 5, 33, 67, 77 }));
        ////https://edabit.com/challenge/uevxL5FNM77otyo9Z
        //Console.WriteLine(SecondTask.ConvertNumberToCorrespondingMonthName(11));
        ////https://edabit.com/challenge/99oN5igrbXddAjHEL
        //Console.WriteLine(SecondTask.ReverseOfCase("MANY THankS"));
        ////https://edabit.com/challenge/6qFnpAhd3kdmYcNG2
        //Console.WriteLine(SecondTask.ReturntheIndexOfAllCapitalLetters("STRiKE"));
        ////https://edabit.com/challenge/g88PKZrCY6sWPBva7
        //Console.WriteLine(ThirdTask.TrackRobot(new string[] { "right 10", "up 50", "left 30", "down 10", "up 5002" }));
        ////https://edabit.com/challenge/HfpK34Ty4SZhN2d9e
        //Console.WriteLine(FourthTask.NewDrivingLicense("Zebediah", 1, "Bob Jim Becky Pat"));
        ////https://edabit.com/challenge/y4esBva2cYph5QKg5
        //Console.WriteLine(FourthTask.AWeekLater("05/29/2005"));
        ////https://edabit.com/challenge/X3btpQQEBeezX4jhK
        //Console.WriteLine(FourthTask.CupSwapping(new string[] { "BA", "AC", "CA", "BC" }));
        ////https://edabit.com/challenge/etT7orqDDXJF2zGYM
        //Console.WriteLine(FourthTask.PasswordValidation("Fhg933@"));
        ////https://edabit.com/challenge/pcHzxfGheeNE4JDpR
        //Console.WriteLine(FourthTask.ValidName("Herbert G. Wells"));
        ////https://edabit.com/challenge/LYCYnsQpqt2xuB6od
        //Console.WriteLine(FifthTask.XORCipher("c611d9bdd9de38b9eb", "23a0745505d4d25494"));
        ////https://edabit.com/challenge/6gSYbKbevEaBHeE9F
        //Console.WriteLine(FifthTask.CrackCode("something challenging"));
        ////https://edabit.com/challenge/ybAba6PYxnGNW7w5r
        //Console.WriteLine(SixthTask.FindAnagramInAnotherString("bag", "grab"));
        ////https://edabit.com/challenge/ujjTrkH9JxPvMQAMR
        //Console.WriteLine(SixthTask.PalindromeSequence(8836886388));
        ////https://edabit.com/challenge/7CiFmw5SiKf9ZLp2N
        //Console.WriteLine(SeventhTask.DistanceToNearestVowel("abcdabcd"));
        ////https://edabit.com/challenge/rYKtzcuCQ9FQ9t9pH
        //Console.WriteLine(MakeSmoothie.Ingredients());
        //Console.WriteLine(MakeSmoothie.GetCost());
        //Console.WriteLine(MakeSmoothie.GetPrice());
        //Console.WriteLine(MakeSmoothie.GetName());
        ////https://edabit.com/challenge/8n43m5c64BKfGCWr3
        //Console.WriteLine(SeventhTask.NicoCipher("mubashirhassaan", "crazy"));
        ////https://edabit.com/challenge/fY5y4WFdha4betoFz
        //Console.WriteLine(SeventhTask.HelpingAlexWithTreasure(new int[] { 2, 7, 2, 4 }));
        ////https://edabit.com/challenge/vQTiy9fvwRuLWs37W
        //Console.WriteLine(SeventhTask.PrefixNotationEvaluation("+ -10 15"));
        #endregion
        //Console.WriteLine(Compare.GetAmount(Compare, Compare2));
        //Console.WriteLine(Compare.GetDifferential(Compare, Compare2));
        //Console.WriteLine(Compare.GetMultiplication(Compare, Compare2));
        //Console.WriteLine(Compare.СomparisonTwoNumbers(Compare, Compare2));
        //Console.WriteLine(Money.СalculateAmount(Money2));
        //Console.WriteLine(Money.CalculateDifferential(Money2));
        //Console.WriteLine(Money.CalculateMultiplication(Money2));
        //Console.WriteLine(Money.CalculateDivision(Money2));
        //Console.WriteLine(Money.СomparisonTwoNumbers(Money2));
        //Console.WriteLine(TemplateList.IsEmpty());
        //TemplateList.SetValueToStartList(1);
        //Console.WriteLine(TemplateList.IsEmpty());
        //TemplateList.SetValueToEndList(2);
        //TemplateList.SetValueToEndList(3);
        //TemplateList.SetValueToEndList(4);
        //TemplateList.SetValueToStartList(0);
        //Console.WriteLine(TemplateList.IsEmpty());
        //TemplateList.DeleteValue(3);
        //University
        Person person = new Person();
        person.Greet();
        Student Valeria = new Student();
        Valeria.SetAge(21);
        Valeria.Greet();
        Valeria.ShowAge();
        Professor Gohn = new Professor();
        Gohn.SetAge(56);
        Gohn.Greet();
        Gohn.Explain();
        //Photo book
        PhotoBook newBook = new PhotoBook();
        Console.WriteLine(newBook.GetNumberPages());
        PhotoBook newBook2 = new PhotoBook(24);
        Console.WriteLine(newBook2.GetNumberPages());
        BigPhotoBook bigPhotoBook = new BigPhotoBook();
        Console.WriteLine(bigPhotoBook.GetNumberPages());
        // names and stores of people
        Human[] persona = new Human[3];
        persona[0] = new Teachers("Juan");
        persona[1] = new Students("Sara");
        persona[2] = new Students("Carlos");
        ((Teachers)persona[0]).Explain();
        ((Students)persona[1]).Study();
        ((Students)persona[2]).Study();
        //Interfaces
        Car car = new Car(0);
        car.fuel = 10;
        car.Drive();
        car.fuel = 0;
        car.Drive();
        //Abstract classes
        Dog dog = new Dog();
        dog.SetName("Wolfe");
        dog.GetName();
        dog.Eat();
    }
}