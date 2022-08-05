using BookManagementSystem.Model;

namespace BookManagementSystem
{
    public class DelegateClass
    {
        List<Book> books = new();
        public delegate void BookService(Book book);

        
    }
}
