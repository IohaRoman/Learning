namespace Learning.Photo_book
{
    internal class PhotoBook
    {
        public int numPages { get; set; }

        public PhotoBook()
        {
            numPages = 16;
        }

        public PhotoBook(int value)
        {
            numPages = value;
        }

        public int GetNumberPages()
        {
            return numPages;
        }
    }
}
