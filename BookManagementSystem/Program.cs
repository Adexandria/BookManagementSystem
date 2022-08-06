using BookManagementSystem;
using BookManagementSystem.Model;
using static BookManagementSystem.DelegateClass;

DelegateClass operations = new();


BookService updateService;

BookService createService = new(operations.CreateBook);
BookService updateDescriptionService = new(operations.UpdateBookDescription);
BookService updateAuthorService = new(operations.UpdateBookAuthor);
BookService updateBookNameService = new(operations.UpdateBookName);
Service getBookService = new(operations.GetBook);
Service DeleteBookService = new(operations.DeleteBookById);

//New book object
Book book = new()
{
    Author = "James",
    Description = "James is a good author",
    Name = "James",
    BookId = 1
};


//updated book object
Book updatedBook = new()
{
    Name = "James Charles",
    Description = "James is a bad author",
    Author = "James",
    BookId = 1
};

//Add new book
createService(book);

//update book description
updateDescriptionService(updatedBook);

//update book author
updateAuthorService(updatedBook);

//update book name
updateBookNameService(updatedBook);

// Get branch 
getBookService(1);

//Delete branch
DeleteBookService(1);

//update all book properties
/*updateAuthorService(book);

updateService = updateAuthorService;
updateService += updateDescriptionService;
updateService += updateBookNameService;

updateService(updatedBook);*/





