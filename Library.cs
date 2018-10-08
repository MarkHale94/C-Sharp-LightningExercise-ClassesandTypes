using System.Collections.Generic;

namespace Library
{
        public class Library
    {
        private List <Book> _bookList;

        public string Address { get; set; }
        public string Name { get; set; }
        public void AddToInventory (Book book)
        {
            _bookList.Add(book);
        }
    }
    
}