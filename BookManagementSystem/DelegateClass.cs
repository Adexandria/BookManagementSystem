using BookManagementSystem.Model;

namespace BookManagementSystem
{
    public class DelegateClass
    {
        static List<Book> books = new();

        public delegate void BookService(Book book); // Create and update
        public delegate void Service(int id);  // Get and delete    

        public delegate void BookNotification(object obj,string name);

        // Event objects
        static EventClass createEvent = new();
        static EventClass updateDescriptionEvent = new();
        static EventClass updateBookNameEvent = new();
        static EventClass updatebookAuthorEvent = new();
        static EventClass deleteBookEvent = new();
        static EventClass getEvent = new();
        static EventClass endEvent = new();
        static EventHandler eventHandler = new();
        
      

        public void GetBook(int id)
        {
            var _book = books.FirstOrDefault(x => x.BookId == id);
            getEvent.StartProcess(_book.Name);
            if (_book != null)
            {
                Console.WriteLine($"The book name {_book.Name} has an author {_book.Author} with description {_book.Description} and id {_book.BookId}");
            }
            else Console.WriteLine("Book not found");
            
            endEvent.EndProcess(_book.Name);
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
            
            endEvent.EndProcess(book.Name);
        }

        public void UpdateBookDescription(Book book)
        {
            updateDescriptionEvent.BookEvent += eventHandler.UpdateBookDescription;
            updateDescriptionEvent.StartProcess(book.Name);
            var findBook = books.FirstOrDefault(x => x.BookId == book.BookId);
            if (findBook != null)
            {
                findBook.Description = book.Description;
            }
            endEvent.EndProcess(book.Name);

        }

        public void UpdateBookAuthor(Book book)
        {
            updatebookAuthorEvent.BookEvent += eventHandler.UpdateBookAuthor;
            updatebookAuthorEvent.StartProcess(book.Name);
            var findBook = books.FirstOrDefault(x => x.BookId == book.BookId);
            if (findBook != null)
            {
                findBook.Author = book.Author;
            }
            endEvent.EndProcess(book.Name);
        }

        public void UpdateBookName(Book book)
        {
            updateBookNameEvent.BookEvent += eventHandler.UpdateBookName;
            updateBookNameEvent.StartProcess(book.Name);
            var findBook = books.FirstOrDefault(x => x.BookId == book.BookId);
            if (findBook != null)
            {
                findBook.Name = book.Name;
            }
            endEvent.EndProcess(book.Name);
        }
        
          public void DeleteBookById(int id)
          {          
            var _book = books.FirstOrDefault(x => x.BookId == id);
            deleteBookEvent.BookEvent += eventHandler.DeleteBook;
            deleteBookEvent.StartProcess(_book.Name);
            if (_book != null)
            {
                books.Remove(_book);
            }
            endEvent.EndProcess(_book.Name);
          }
    }
}
