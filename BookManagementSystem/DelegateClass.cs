using BookManagementSystem.Model;

namespace BookManagementSystem
{
    public class DelegateClass
    {
        static List<Book> books = new();

        public delegate void BookService(Book book); // Create and update
        public delegate void Service(int id);  // Get and delete    

        public delegate void BookNotification(object obj,string name);

        static EventClass createEvent = new();
        static EventClass updateEvent = new();
        static EventClass deleteEvent = new();
        static EventClass getEvent = new();
        static EventHandler eventHandler = new();
        
      

        public static void GetBook(int id)
        {
            var _book = books.FirstOrDefault(x => x.BookId == id);
            if (_book != null)
            {
                Console.WriteLine(_book);
            }
            else Console.WriteLine("Book not found");
        }
        

        public void CreateBook(Book book)
        {
            createEvent.BookEvent += eventHandler.AddBook;
            createEvent.StartProcess(book.Name);
            var checkBook = books.FirstOrDefault(x => x.Equals(book));
            if(checkBook is null)
            {
                books.Add(book);
            }
            createEvent.EndProcess(book.Name);
            
        }

        public void UpdateBookDescription(Book book)

        {
            updateEvent.BookEvent += eventHandler.UpdateBookDescription;
            updateEvent.StartProcess(book.Name);
            var findBook = books.FirstOrDefault(x => x.BookId == book.BookId);
            if (findBook != null)
            {
                findBook.Description = book.Description;
            }
            updateEvent.EndProcess(book.Name);

        }

        public void UpdateBookAuthor(Book book)
        {
            updateEvent.BookEvent += eventHandler.UpdateBookAuthor;
            updateEvent.StartProcess(book.Name);
            var findBook = books.FirstOrDefault(x => x.BookId == book.BookId);
            if (findBook != null)
            {
                findBook.Author = book.Author;
            }
            updateEvent.EndProcess(book.Name);
        }

        public void UpdateBookName(Book book)
        {
            updateEvent.BookEvent += eventHandler.UpdateBookName;
            updateEvent.StartProcess(book.Name);
            var findBook = books.FirstOrDefault(x => x.BookId == book.BookId);
            if (findBook != null)
            {
                findBook.Name = book.Name;
            }
            updateEvent.EndProcess(book.Name);
        }
        
          public static void DeleteBook(int id)
        {
            var _book = books.FirstOrDefault(x => x.BookId == id);
            if (_book != null)
            {
                books.Remove(_book);
            }
        }
    }
}
