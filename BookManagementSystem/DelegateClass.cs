using BookManagementSystem.Model;

namespace BookManagementSystem
{
    public class DelegateClass
    {
        List<Book> books = new();
        public delegate void BookService(Book book); // Create and update
        public delegate void Service(Guid id); // Get and delete
        
        public delegate void BookNotification(object obj,string name);

        public void CreateBook(Book book)
        {
            var checkBook = books.FirstOrDefault(x => x.Equals(book));
            if(checkBook is null)
            {
                books.Add(book);
            }
        }

        public void UpdateBookDescription(Book book)
        {
            var findBook = books.FirstOrDefault(x => x.BookId == book.BookId);
            if (findBook != null)
            {
                findBook.Description = book.Description;
            }
        }
    }
}
