using System.Text;

namespace Learning.OOP_Base_string
{
    internal class ComplexNumber : StringNew
    {
        public string GetValue { get; set; }

        public ComplexNumber(int x)
        {
            var complex = new StringBuilder();

            if (x < 0)
            {
                complex.Append('-');
            }
            x = Math.Abs(x);

            while (x > 0)
            {
                int temp = x % 10;
                complex.Insert(0, temp.ToString());
                x /= 10;
            }

            GetValue = complex.ToString();
        }

        public bool IsEqual(ComplexNumber x, ComplexNumber y)
        {
            if (x == y)
            {
                return true;
            }
            else return false;
        }

        public int СalculateAmount(ComplexNumber x, ComplexNumber y)
        {
            return Convert.ToInt32(x.GetValue) + Convert.ToInt32(y.GetValue);
        }

        public int CalculateMultiplication(ComplexNumber x, ComplexNumber y)
        {
            return Convert.ToInt32(x.GetValue) * Convert.ToInt32(y.GetValue);
        }
    }
}
