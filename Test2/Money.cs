
namespace Learning
{
    internal class Money
    {
        public Money(long firstValue, byte secondValue)
        {
            GetFirstValue = firstValue;
            GetSecondValue = secondValue;
        }

        public long GetFirstValue { get; set; }
        public byte GetSecondValue { get; set; }

        public override string ToString()
        {
            return string.Format("{0},{1:00}", GetFirstValue, GetSecondValue);
        }

        public string СalculateAmount(Money a, Money b)
        {
            var summRubles = a.GetFirstValue + b.GetFirstValue;
            var summPennies = a.GetSecondValue + b.GetSecondValue;
            var pennies = (byte)(summPennies % 100);

            return $"{summRubles},{pennies}";
        }

        public string CalculateDifferential(Money a, Money b)
        {
            var summRubles = a.GetFirstValue - b.GetFirstValue;
            var summPennies = a.GetSecondValue - b.GetSecondValue;
            var pennies = (byte)(summPennies % 100);

            return $"{summRubles},{pennies}";
        }

        public string CalculateMultiplication(Money a, Money b)
        {
            var summRubles = a.GetFirstValue * b.GetFirstValue;
            var summPennies = a.GetSecondValue * b.GetSecondValue;
            var pennies = (byte)(summPennies % 100);

            return $"{summRubles},{pennies}";
        }

        public string CalculateDivision(Money a, Money b)
        {
            var summRubles = a.GetFirstValue / b.GetFirstValue;
            var summPennies = a.GetSecondValue / b.GetSecondValue;
            var pennies = (byte)(summPennies % 100);

            return $"{summRubles},{pennies}";
        }

        public string СomparisonTwoNumbers(Money a, Money b)
        {
            var summRubles = a.GetFirstValue - b.GetFirstValue;
            var summPennies = a.GetSecondValue - b.GetSecondValue;
            var pennies = (byte)(summPennies % 100);

            if (summRubles > 0 & pennies > 0)
            {
                return $"{a}' '>' '{b}";
            }
            else return $"{a}' '<' '{b}";
        }
    }
}
