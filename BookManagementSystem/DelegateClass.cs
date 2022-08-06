using BookManagementSystem.Model;

namespace BookManagementSystem
{
    public class DelegateClass
    {
        static List<Book> books = new();

        public delegate void BookService(Book book); // Create and update
        public delegate void Service(int id);  // Get and delete    

        public delegate void BookNotification(object obj,string name);

        public static void DeleteBook(int id)
        {
            var _book = books.FirstOrDefault(x => x.BookId == id);
            if (_book != null)
            {
                books.Remove(_book);
            }
        }

        public static void GetBook(int id)
        {
            var _book = books.FirstOrDefault(x => x.BookId == id);
            if (_book != null)
            {
                Console.WriteLine(_book);
            }
            else Console.WriteLine("Book not found");
        }
        
    }
}
