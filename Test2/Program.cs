using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        Tasks FirstTask = new Tasks();
        Tasks SecondTask = new Tasks();
        //https://edabit.com/challenge/xfRucdwGksiyjZq4K
        System.Console.WriteLine(FirstTask.SummTwoNumbers(2, 7));
        //https://edabit.com/challenge/bizjGL4wyd8PwR4Ke
        System.Console.WriteLine(FirstTask.ConvertToSeconds(77));
        //https://edabit.com/challenge/nkkKguC5TgWnBiMLA
        System.Console.WriteLine(FirstTask.ConvertAgeToDates(35));
        //https://edabit.com/challenge/kMWmiNJM4szSv7dLd
        SecondTask.FindSmallestBiggestNumbers(new int[] { 1, 2, 78, 4, 5, 33, 67, 77 });
        //https://edabit.com/challenge/uevxL5FNM77otyo9Z
        SecondTask.ConvertNumbertoCorrespondingMonthName(11);
        //https://edabit.com/challenge/99oN5igrbXddAjHEL
        SecondTask.ReverseOfCase("Happy Birthday");
        //https://edabit.com/challenge/6qFnpAhd3kdmYcNG2
        SecondTask.ReturntheIndexOfAllCapitalLetters("STRiKE");
    }
}

public class Tasks
{
    const int Time = 60;
    const int DaisPerYear = 365;
    string[] MonthOfYear = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
         
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

    public int[] FindSmallestBiggestNumbers(int[] Mass)
    {
        var builder = new StringBuilder("[");

        int[] Result = new int[2];
        Result[0] = Mass.Min();
        Result[1] = Mass.Max();

        for(var i= 0; i < Result.Length; i++)  
        {
            builder.Append(Result[i]);

            if(i < Result.Length - 1)
            {
                builder.Append(",");
            }

        }

        builder.Append("]");

        var StringResult = builder.ToString();
        Console.WriteLine(StringResult);

        return Result;
    }

    public int ConvertNumbertoCorrespondingMonthName(int MonthNumber)
    {
        Console.WriteLine(MonthOfYear[MonthNumber - 1]);
        return 0;
    }

    public string ReverseOfCase(string TypedString)
    {
        char[] CharArray = TypedString.ToCharArray();
        var RevertedArray = new StringBuilder();

        for (var i = 0; i < CharArray.Length; i++)
        {
            if (char.IsUpper(CharArray[i]))
            {
              
                RevertedArray.Append(char.ToLower(CharArray[i]));
            }
            else
            {
                RevertedArray.Append(Char.ToUpper(CharArray[i]));
            }
        }

        Console.WriteLine(RevertedArray);
        return RevertedArray.ToString();
    }

    public string ReturntheIndexOfAllCapitalLetters(string TypedString)
    {
        char[] CharArray = TypedString.ToCharArray();
        var builder = new StringBuilder("[");

        for (var i = 0; i < CharArray.Length; i++)
        {
            if (char.IsUpper(CharArray[i]))
            {
                builder.Append(i);

                if (i < CharArray.Length - 1)
                {
                    builder.Append(",");
                }
            }        
        }

        builder.Append("]");

        var IndedxUpperCasesArray = builder.ToString();
        Console.WriteLine(IndedxUpperCasesArray);

        return IndedxUpperCasesArray;
    }
}




