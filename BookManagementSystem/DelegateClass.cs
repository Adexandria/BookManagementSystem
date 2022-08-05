using BookManagementSystem.Model;

namespace BookManagementSystem
{
    public class DelegateClass
    {
        List<Book> books = new();
        public delegate void BookService(Book book); // Create and update
        public delegate void DeleteBookService(int id);  // delete
        public delegate Book GetBookService(int id);    // Get

        public delegate void BookNotification(object obj,string name);

        public void DeleteBook(int id)
        {
            var _book = books.FirstOrDefault(x => x.BookId == id);
            if (_book != null)
            {
                books.Remove(_book);
            }
        }

        public Book GetBook(int id)
        {
            var _book = books.FirstOrDefault(x => x.BookId == id);
            if (_book != null)
            {
                return _book;
            }
            else return null;
        }
    }
}
