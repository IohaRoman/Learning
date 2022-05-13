using System.Text;

namespace Learning
{
    internal class StringNew
    {
        public ushort length;
        public string inputSting;

        public StringNew()
        {
        }

        public StringNew(string inputString)
        {
            this.inputSting = inputString;
            length = (ushort)inputString.Length;
        }

        public StringNew(char simbol)
        {
            inputSting = Convert.ToString(simbol);
            length = 1;
        }
        public int StringLength()
        {
            return length;
        }

        public void Clear()
        {
            inputSting = "";
            length = 0;
        }

        ~StringNew()
        {
        }
    }
    internal class ComplexNumber : StringNew
    {
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

        public string GetValue { get; set; }

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
