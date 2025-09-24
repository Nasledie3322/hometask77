
        PhotoBook defaultBook = new PhotoBook();
        Console.WriteLine(defaultBook.GetNumberPages());

        PhotoBook customBook = new PhotoBook(24);
        Console.WriteLine(customBook.GetNumberPages());

        BigPhotoBook bigBook = new BigPhotoBook();
        Console.WriteLine(bigBook.GetNumberPages());
    