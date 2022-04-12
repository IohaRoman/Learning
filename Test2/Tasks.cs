﻿using System.Text;
using System.Globalization;

namespace Learning
{
    internal class Tasks
    {
            const int DaysPerYear = 365;

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
        }
    }