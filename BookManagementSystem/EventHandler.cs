using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem
{
    public class EventHandler
    {
        public  void AddBook(object obj,string name)
        {
            Console.WriteLine($"{name} book added successfully");
        }
        
        public  void UpdateBookDescription(object obj, string name)
        {
            Console.WriteLine($"{name} book description updated successfully");
        }

        public void UpdateBookName(object obj, string name)
        {
            Console.WriteLine($"{name} book name updated successfully");
        }

        public void UpdateBookAuthor(object obj, string name)
        {
            Console.WriteLine($"{name} book author updated successfully");
        }

        public void DeleteBook(object obj, string name)
        {
            Console.WriteLine($"{name} book deleted successfully");
        }

      
    }
}
