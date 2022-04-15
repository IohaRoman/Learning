using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Learning
{
    internal class Tasks
    {
        const int DaysPerYear = 365;
        const int TimeToResolveIssue = 20;

        public int SummTwoNumbers(int a, int b)
            {
                return a + b;
            }

        public int ConvertToSeconds(int minutes)
            {
                return Convert.ToInt32(TimeSpan.FromMinutes(minutes).TotalSeconds);
            }

        public int ConvertAgeToDates(int age)
            {
                var AgeInDays = age * DaysPerYear;
                return AgeInDays;
            }

        public string FindSmallestBiggestNumbers(int[] mass)
            {
                return $"[{mass.Min()},{mass.Max()}]";
            }

        public string ConvertNumberToCorrespondingMonthName(int monthNumber)
            {
                return DateTimeFormatInfo.CurrentInfo.GetAbbreviatedMonthName(monthNumber);
            }

        public string ReverseOfCase(string typedString)
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

        public string ReturntheIndexOfAllCapitalLetters(string typedString)
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

        public string TrackRobot(string[] cordinates)
            {
                var point = new Point();
                foreach (var cordinate in cordinates)
                {
                    var subs = cordinate.Split(' ');
                    SetValue(subs.First(), Convert.ToInt32(subs.Last()), point);
                }

                return point.ToString();
            }

        private void SetValue(string setVector, int value, Point point)
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

        public int NewDrivingLicense(string name, int agents, string queue)
        {
            var queueNames = new string(queue + ' ' + name);
            var splitedQueueNames = queueNames.Split(' ');

            Array.Sort(splitedQueueNames);

            return (Array.IndexOf(splitedQueueNames, name) / agents * TimeToResolveIssue + TimeToResolveIssue);
        }

        public string AWeekLater(string dateTime)
        {
            DateTime increasedDate = Convert.ToDateTime(dateTime);

            return increasedDate.AddDays(7).ToShortDateString();
        }

        public string CupSwapping(string[] movements)
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

        public bool PasswordValidation(string password)
        {
            Regex regex = new Regex(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[\!\@\#\$\%\^\&\*\(\)\+\=\-\{\}\[\]\:\;\'\?\<\>\,\.]).{6,24}$)");
            var repitLetters = !Regex.IsMatch(password, @"^((.)\1{2,})");

            return regex.IsMatch(password) && repitLetters;
        }

        public bool ValidName(string name)
        {
            return Regex.IsMatch(name, @"^[A-Z]([a-z]+|\.)\s[A-Z]([a-z]+|\.)\s[A-Z][a-z]+$");
        }

    }
}