using BookManagementSystem.Model;

namespace BookManagementSystem
{
    public class DelegateClass
    {
        List<Book> books = new();
        public delegate void BookService(Book book); // Create and update
        public delegate void Service(Guid id); // Get and delete
        


    }
}
