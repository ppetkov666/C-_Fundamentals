namespace _04___Book_Comparer
{
    using System;
    class StartUp
    {
        static void Main()
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);
            var library = new Library(bookOne, bookTwo, bookThree);
            foreach (var item in library)
            {
                Console.WriteLine(item);
            }
        }
    }
}
