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
            inputSting = inputString;
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
}
