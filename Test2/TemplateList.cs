
namespace Learning
{
    internal class TemplateList
    {
        public Point Head { get; set; }
        public Point Tail { get; set; }
        public int Length { get; set; }

        public class Point
        {
            public Point NextPoint { get; set; }
            public Point PreviousPoint { get; set; }
            public int Value { get; set; }

            public Point(int Value, Point NextPoint, Point PreviousPoint)
            {
                this.NextPoint = NextPoint;
                this.PreviousPoint = PreviousPoint;
                this.Value = Value;
            }
        }

        public TemplateList()
        {
        }

        public bool IsEmpty()
        {
            return Length == 0 && Head == null;
        }

        public void SetValueToStartList(int value)
        {
            var TempPoint = new Point(value, Head, null);

            if (Head == null && Tail == null)
            {
                Head = TempPoint;
                Tail = TempPoint;
            }
            else Head.PreviousPoint = TempPoint;

            Length++;
        }

        public void SetValueToEndList(int value)
        {
            var TempPoint = new Point(value, null, Tail);

            if (Head == null && Tail == null)
            {
                Head = TempPoint;
                Tail = TempPoint;
            }
            else Tail.NextPoint = TempPoint;

            Length++;
        }

        public string DeleteValue(int itemToDelete)
        {
            var count = 0;
            var currentPoint = Head;

            for (var i = 0; i < Length; i++)
            {
                var temp = currentPoint.Value;

                if (temp == itemToDelete  && currentPoint.NextPoint != null && currentPoint.PreviousPoint != null)
                {
                    currentPoint.PreviousPoint.NextPoint = currentPoint.NextPoint;
                    currentPoint.NextPoint.PreviousPoint = currentPoint.PreviousPoint;
                    count++;
                    Length--;
                }

                currentPoint = currentPoint.NextPoint;

                if (currentPoint == null)
                {
                    break;
                }

            }

            return $"count - {count}";
        }
        public string GetCoutValues(int itemToDelete)
        {
            var count = 0;
            var currentPoint = Head;

            for (var i = 0; i < Length; i++)
            {
                var temp = currentPoint.Value;

                if (temp == itemToDelete && currentPoint.NextPoint != null && currentPoint.PreviousPoint != null)
                {
                    count++;
                    Length--;
                }

                currentPoint = currentPoint.NextPoint;

                if (currentPoint == null)
                {
                    break;
                }

            }

            return $"count - {count}";
        }
    }
}
