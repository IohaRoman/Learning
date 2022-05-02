using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

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

        #region Task regarding: TrackRobot - public string TrackRobot(string[])
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
        #endregion
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

        public string XORCipher(string firstXorString, string secondXorString)
        {
            var numbersAndWords = firstXorString.Zip(secondXorString,(first, second) => Convert.ToString(Convert.ToInt32(first.ToString(), 16) ^ Convert.ToInt32(second.ToString(), 16), 16));

            return $"[{string.Join("", numbersAndWords)}]";
        }

        public string CrackCode(string xorValues)
        {
            var result = new int[xorValues.Length];
            var decode = Encoding.ASCII.GetBytes(xorValues);

            for (int i = 0; i < decode.Length; i++)
            {
                result[i] = Convert.ToInt32(decode[i].ToString().Sum(x => char.GetNumericValue(x)));
            }

            return $"[{string.Join(",", result)}]";
        }

        public bool FindAnagramInAnotherString(string firstAnagram, string secondAnagam)
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

        #region Task regarding: Palindromes - public string PalindromeSequence(Long)
        public string PalindromeSequence(long enteredValue)
        {
            if(IsPalindrome(enteredValue))
            {
                for (var value = 1; value <= enteredValue; value++)
                {
                    var result = Convert.ToInt64(value);
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

        public string ReversePalindrome(long supposedPalindrome)
        {
            var revers = supposedPalindrome.ToString().ToCharArray();
            return new string(revers.Reverse().ToArray());
        }

        public bool IsPalindrome(long intendedPalindrome)
        {
            long reminder, sum = 0;
            var temp = intendedPalindrome;
            while (intendedPalindrome > 0)
            {
                reminder = intendedPalindrome % 10;
                sum = (sum * 10) + reminder;
                intendedPalindrome = intendedPalindrome / 10;
            }
            if (temp == sum) return true;
            else return false;
        }
        #endregion

        #region Task regarding: Distance to Nearest Vowel - public string DistanceToNearestVowel(string)
        public string DistanceToNearestVowel(string lettersString)
        {
            var vowel = new[]{'a', 'e', 'i', 'o', 'u'};
            var numsVowel = new int[lettersString.Length];
            var numsVowelReverse = new int[lettersString.Length];
            var trimedString = lettersString.Trim().ToCharArray();
            var tempVowel = 1;
            var tempVowelReverse = 1;

            for (var i = 0; i < lettersString.Length; i++)
            {
                if (vowel.Contains(trimedString[i]))
                {
                    tempVowel = 0;
                    numsVowel[i] = tempVowel;
                    tempVowel++;
                }else numsVowel[i] = tempVowel++;
            }

            for (var j = lettersString.Length; j != 0; j--)
            {
                if (vowel.Contains(trimedString[j-1]))
                {
                    tempVowelReverse = 0;
                    numsVowelReverse[j-1] = tempVowelReverse;
                    tempVowelReverse++;
                }
                else numsVowelReverse[j-1] = tempVowelReverse++;
            }

            return $"({string.Join(",", SortedString(numsVowel, numsVowelReverse))})";
        }

        public int[] SortedString(int[] ascending, int[] descending)
        {
            for (var i = 0; i < ascending.Length - 1; i++)
            {
                if (ascending[i] > descending[i])
                {
                    ascending[i] = descending[i];
                }
            }

            return ascending;
        }
        #endregion

        #region Task regarding: Nico Cipher - public string NicoCipher(string message, string key)
        public string NicoCipher(string message, string key)
        {
            var keyLength = key.Length;
            var stringLength = message.Length;
            var list = new List<String>();
            var result = new StringBuilder();
            var temp = new String[keyLength];

            for (int i = 0; i < stringLength; i += keyLength)
            {
                if (i + keyLength > stringLength)
                {
                    keyLength = stringLength - i;
                    list.Add(message.Substring(i, keyLength));
                }
                list.Add(message.Substring(i, keyLength));
            }

            foreach (var subString in list)
            {
                var tempSubString = subString.ToCharArray();

                for (var i = 0; i < tempSubString.Length; i++)
                {
                    var index = int.Parse(GenerateKey(key)[i].ToString()) - 1;

                    temp[index] = tempSubString[i].ToString();
                }
                result.Append(String.Join("", temp));
            }

            return String.Join("", result);
        }
        public string GenerateKey(string key)
        {
            var createdKey = new StringBuilder();
            var sortKeys = key.ToCharArray();

            Array.Sort(sortKeys);
            foreach (var symbolKey in key)
            {
                createdKey.Append(sortKeys.ToList().IndexOf(symbolKey) + 1);
            }

            return String.Join("", createdKey);
        }
        #endregion

        public int HelpingAlexWithTreasure(int[] boxes)
        {
            //var boxCount = boxes.Length;
            //var data = new int[boxCount + 1];
            //var alexBox = new List<int>();
            //var sindyBox = new List<int>();

            //alexBox[0] = boxes[0];
            //alexBox[1] = boxes.Max() - boxes.Min();

            //for (var i = 0; i < boxCount; i++)
            //{
            //    if (boxCount % 2 == 0)
            //    {
            //        alexBox.Add(boxes[i] - boxes[i - 2]);
            //    }
            //    else
            //    {

            //    }
            //}

            //return alexBox.Sum(x => Convert.ToInt16(x)) - sindyBox.Sum(x => Convert.ToInt16(x));

            return 0;//data[boxCount];
        }
    }
}