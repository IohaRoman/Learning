namespace Learning
{
    internal class Fractional
    {
        private double GetIntegral;
        private double GetFractional;

        public double GetNumber { get; set; }

        public Fractional(double number)
        {
            GetIntegral = Math.Truncate(number);
            GetFractional = number - GetIntegral;
        }

        public string GetAmount(Fractional firstValue, Fractional secondValue)
        {
            var resultIntegral = firstValue.GetIntegral * secondValue.GetFractional + secondValue.GetIntegral * firstValue.GetFractional;
            var commonDenominator = firstValue.GetFractional * secondValue.GetFractional;

            return $"{resultIntegral + commonDenominator}";
        }

        public string GetDifferential(Fractional firstValue, Fractional secondValue)
        {
            var resultIntegral = firstValue.GetIntegral * secondValue.GetFractional - secondValue.GetIntegral * firstValue.GetFractional;
            var commonDenominator = firstValue.GetFractional * secondValue.GetFractional;

            return $"{resultIntegral + commonDenominator}";
        }

        public string GetMultiplication(Fractional firstValue, Fractional secondValue)
        {
            var resultIntegral = firstValue.GetIntegral * secondValue.GetIntegral;
            var commonDenominator = firstValue.GetFractional * secondValue.GetFractional;

            return $"{resultIntegral + commonDenominator}";
        }

        public string СomparisonTwoNumbers(Fractional firstValue, Fractional secondValue)
        {
            if (firstValue.GetIntegral + firstValue.GetFractional > secondValue.GetIntegral + secondValue.GetFractional)
            {
                return $"{firstValue.GetIntegral + firstValue.GetFractional}' '>' '{secondValue.GetIntegral + secondValue.GetFractional}";
            }
            else return $"{firstValue.GetIntegral + firstValue.GetFractional}' '<' '{secondValue.GetIntegral + secondValue.GetFractional}";
        }
    }
}