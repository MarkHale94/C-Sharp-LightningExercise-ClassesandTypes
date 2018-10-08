using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello World!");
            Book endersGame = new Book()
                {
                    Title = "Ender's Game",
                    Author = "Orsen Scott",
                    ISBN = "ABC123"
                };
            Book tomSawyer = new Book();
                tomSawyer.Title = "Tom Sawyer";
                tomSawyer.Author = "Mark Twain";
                tomSawyer.ISBN = "23234ASSDFSDA";

            Book lotr = new Book()
                {
                    Title = "Lord of the Rings",
                    Author = "J R R Tolkien",
                    ISBN = "ABC12312313123"
                };

            Book twilight = new Book()
                {
                    Title = "Twilight",
                    Author = "Stephanie Meyers",
                    ISBN = "c2SDFSDF123"
                };

            Library library = new Library()
            {
                Name = "Downtown Library",
                Address = "Someplace Downtown"
            };

            library.AddToInventory(endersGame);
            library.AddToInventory(tomSawyer);
            library.AddToInventory(twilight);
            library.AddToInventory(lotr);
        }
    }
}

