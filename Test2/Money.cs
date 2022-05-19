namespace Learning
{
    internal class Money
    {
        public long GetFirstValue { get; set; }
        public byte GetSecondValue { get; set; }

        public Money(long firstValue, byte secondValue)
        {
            GetFirstValue = firstValue;
            GetSecondValue = secondValue;
        }

        public string СalculateAmount(Money value)
        {
            GetFirstValue += value.GetFirstValue;
            GetSecondValue += value.GetSecondValue;

            return $"{GetFirstValue},{(byte)(GetSecondValue % 100)}";
        }

        public string CalculateDifferential(Money value)
        {
            GetFirstValue -= value.GetFirstValue;
            GetSecondValue -= value.GetSecondValue;

            return $"{GetFirstValue},{(byte)(GetSecondValue % 100)}";
        }

        public string CalculateMultiplication(Money value)
        {
            GetFirstValue *= value.GetFirstValue;
            GetSecondValue *= value.GetSecondValue;

            return $"{GetFirstValue},{(byte)(GetSecondValue % 100)}";
        }

        public string CalculateDivision(Money value)
        {
            GetFirstValue /= value.GetFirstValue;
            GetSecondValue /= value.GetSecondValue;

            return $"{GetFirstValue},{(byte)(GetSecondValue % 100)}";
        }

        public string СomparisonTwoNumbers(Money value)
        {
            GetFirstValue -= value.GetFirstValue;
            GetSecondValue -= value.GetSecondValue;
            var pennies = (byte)(GetSecondValue % 100);

            if (GetFirstValue > 0 & pennies > 0)
            {
                return $"{GetFirstValue},{GetSecondValue}' '>' '{value.GetFirstValue},{value.GetSecondValue}";
            }
            else return $"{GetFirstValue},{GetSecondValue}' '<' '{value.GetFirstValue},{value.GetSecondValue}";
        }
    }
}
