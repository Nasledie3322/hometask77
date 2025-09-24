class PhotoBook
{
    private int numPages;

    public PhotoBook()
    {
        numPages = 16;
    }

    public PhotoBook(int numPages)
    {
        this.numPages = numPages;
    }

    public int GetNumberPages()
    {
        return numPages;
    }
}