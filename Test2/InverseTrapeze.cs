
namespace Learning
{
    internal class InverseTrapeze
    {
        protected int x1, y1, x2, y2, x3, y3, x4, y4;
        protected double AB, BC, CD, DA;
        public InverseTrapeze(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
            this.x4 = x4;
            this.y4 = y4;
        }

        public string GetLength()
        {
            AB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            BC = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            CD = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            DA = Math.Sqrt(Math.Pow(x1 - x4, 2) + Math.Pow(y1 - y4, 2));

            return $"AB = {AB},BC = {BC},CD = {CD},DA = {DA}";
        }

        public bool IsEquilateralTrapezoid()
        {
            if (AB == CD)
            {
                return true;
            }
            else return false;
        }

        public string GetPerimeter()
        {
            return $"Perimeter = {AB + BC + CD + DA}";
        }

        public string GetSquare()
        {
            return $"Square = {Math.Sqrt(Math.Pow(y2 - y1, 2)) * (BC + DA) / 2}";
        }
    }

}
