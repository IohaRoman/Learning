using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;

namespace Learning
{
    internal class Tasks
    {
        const int DaysPerYear = 365;
        const int TimeToResolveIssue = 20;

        public static int SummTwoNumbers(int a, int b)
            {
                return a + b;
            }

        public static int ConvertToSeconds(int minutes)
            {
                return Convert.ToInt32(TimeSpan.FromMinutes(minutes).TotalSeconds);
            }

        public static int ConvertAgeToDates(int age)
            {
                var AgeInDays = age * DaysPerYear;
                return AgeInDays;
            }

        public static string FindSmallestBiggestNumbers(int[] mass)
            {
                return $"[{mass.Min()},{mass.Max()}]";
            }

        public static string ConvertNumberToCorrespondingMonthName(int monthNumber)
            {
                return DateTimeFormatInfo.CurrentInfo.GetAbbreviatedMonthName(monthNumber);
            }

        public static string ReverseOfCase(string typedString)
            {
                var CharArray = typedString.ToCharArray();
                var RevertedArray = new StringBuilder();

                for (var i = 0; i < CharArray.Length; i++)
                {
                    if (char.IsUpper(CharArray[i]))
                    {

                        RevertedArray.Append(char.ToLower(CharArray[i]));
                    }
                    else
                    {
                        RevertedArray.Append(char.ToUpper(CharArray[i]));
                    }
                }

                return RevertedArray.ToString();
            }

        public static string ReturntheIndexOfAllCapitalLetters(string typedString)
            {
                var CharArray = typedString.ToCharArray();
                var builder = new StringBuilder();

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

                return $"[{builder}]";
            }

        #region Task regarding TrackRobot - public string TrackRobot(string[])
        public static string TrackRobot(string[] cordinates)
            {
                var point = new Point();
                foreach (var cordinate in cordinates)
                {
                    var subs = cordinate.Split(' ');
                    SetValue(subs.First(), Convert.ToInt32(subs.Last()), point);
                }

                return point.ToString();
            }

        private static void SetValue(string setVector, int value, Point point)
            {
                switch (setVector)
                {
                    case "right":
                        point.X += value;
                        break;

                    case "left":
                        point.X -= value;
                        break;

                    case "up":
                        point.Y += value;
                        break;

                    case "down":
                        point.Y -= value;
                        break;
                }

            }

        class Point
            {
                public int X { get; set; }
                public int Y { get; set; }

                public override string ToString()
                {
                    return $"{X},{Y}";
                }

            }
        #endregion
        public static int NewDrivingLicense(string name, int agents, string queue)
        {
            var queueNames = new string(queue + ' ' + name);
            var splitedQueueNames = queueNames.Split(' ');

            Array.Sort(splitedQueueNames);

            return (Array.IndexOf(splitedQueueNames, name) / agents * TimeToResolveIssue + TimeToResolveIssue);
        }

        public static string AWeekLater(string dateTime)
        {
            DateTime increasedDate = Convert.ToDateTime(dateTime);

            return increasedDate.AddDays(7).ToShortDateString();
        }

        public static string CupSwapping(string[] movements)
        {
            var currentPosition = ("B");

            foreach (var movement in movements)
            {
                if (movement.Contains(currentPosition))
                {
                    currentPosition = movement.Trim(Convert.ToChar(currentPosition));
                }
            }

            return currentPosition;
        }

        public static bool PasswordValidation(string password)
        {
            Regex regex = new Regex(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[\!\@\#\$\%\^\&\*\(\)\+\=\-\{\}\[\]\:\;\'\?\<\>\,\.]).{6,24}$)");
            var repitLetters = !Regex.IsMatch(password, @"^((.)\1{2,})");

            return regex.IsMatch(password) && repitLetters;
        }

        public static bool ValidName(string name)
        {
            return Regex.IsMatch(name, @"^[A-Z]([a-z]+|\.)\s[A-Z]([a-z]+|\.)\s[A-Z][a-z]+$");
        }

        public static string XORCipher(string firstXorString, string secondXorString)
        {
            var numbersAndWords = firstXorString.Zip(secondXorString,(first, second) => Convert.ToString(Convert.ToInt32(first.ToString(), 16) ^ Convert.ToInt32(second.ToString(), 16), 16));

            return $"[{string.Join("", numbersAndWords)}]";
        }

        public static string CrackCode(string xorValues)
        {
            var result = new int[xorValues.Length];
            var decode = Encoding.ASCII.GetBytes(xorValues);

            for (int i = 0; i < decode.Length; i++)
            {
                result[i] = Convert.ToInt32(decode[i].ToString().Sum(x => char.GetNumericValue(x)));
            }

            return $"[{string.Join(",", result)}]";
        }

        public static bool FindAnagramInAnotherString(string firstAnagram, string secondAnagam)
        {

            for (var i = 0; i <= secondAnagam.Length - firstAnagram.Length; i++)
            {
                var temp = secondAnagam.Substring(i, firstAnagram.Length);
                var compare1 = temp.OrderBy(x => x);
                var compare2 = firstAnagram.OrderBy(x => x);

                if (compare1.SequenceEqual(compare2))
                {
                    return true;
                }
            }

            return false;
        }

        #region Task regarding Palindromes - public string PalindromeSequence(Long)
        public static string PalindromeSequence(long enteredValue)
        {
            if(IsPalindrome(enteredValue) == true)
            {
                for (int value = 1; value <= enteredValue; value++)
                {
                    long result = value;
                    for (var counter = 1; ; counter++)
                    {
                        if (result == Convert.ToInt64(ReversePalindrome(result))) break;

                        result += Convert.ToInt64(ReversePalindrome(result));

                        if (result == enteredValue) return $"({value},{counter})";

                        if (result > enteredValue) break;
                    }
                }
            }
            return $"({enteredValue},{0})";
        }

        public static string ReversePalindrome(long supposedPalindrome)
        {
            var revers = supposedPalindrome.ToString().ToCharArray();
            return new string(revers.Reverse().ToArray());
        }

        public static bool IsPalindrome(long intendedPalindrome)
        {
            long remineder, sum = 0;
            var temp = intendedPalindrome;
            while (intendedPalindrome > 0)
            {
                remineder = intendedPalindrome % 10;
                sum = (sum * 10) + remineder;
                intendedPalindrome = intendedPalindrome / 10;
            }
            if (temp == sum) return true;
            else return false;
        }
        #endregion
    }
}
