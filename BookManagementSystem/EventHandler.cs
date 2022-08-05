using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem
{
    public class EventHandler
    {
        public static void AddBook(object obj,string name)
        {
            Console.WriteLine($"{name} book added successfully");
        }
        
        public static void UpdateBook(object obj, string name)
        {
            Console.WriteLine($"{name} book updated successfully");
        }
        
        public static void DeleteBook(object obj, string name)
        {
            Console.WriteLine($"{name} book deleted successfully");
        }

        /*        public static void GetExistingBook(object obj, string name)
        {
            Console.WriteLine($"{name} book Added");
        }*/
    }
}
