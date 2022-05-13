
namespace Learning
{
    internal class Fractional
    {
        public Fractional(double firstValue, double secondValue)
        {
            GetFirstValue = firstValue;
            GetSecondValue = secondValue;
        }
        public double GetFirstValue { get; set; }
        public double GetSecondValue { get; set; }

        public double СalculateAmount()
        {
            return GetFirstValue + GetSecondValue;
        }

        public double CalculateDifferential()
        {
            return GetFirstValue - GetSecondValue;
        }

        public double CalculateMultiplication()
        {
            return GetFirstValue * GetSecondValue;
        }

        public string СomparisonTwoNumbers()
        {
            if (GetFirstValue > GetSecondValue)
            {
                return $"{GetFirstValue}' '>' '{GetSecondValue}";
            }
            else return $"{GetFirstValue}' '<' '{GetSecondValue}";
        }
    }
}
