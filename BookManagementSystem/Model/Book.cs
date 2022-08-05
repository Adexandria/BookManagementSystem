

namespace BookManagementSystem.Model
{
    public class Book
    {
        public Guid BookId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
    }
}
