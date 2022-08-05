using static BookManagementSystem.DelegateClass;

namespace BookManagementSystem
{
    public  class EventClass
    {
        public event BookNotification BookEvent;
        
        public void StartProcess(string bookName)
        {
            Console.WriteLine("Starting Operation");
            OnStart(bookName);
        }
        
        protected virtual void OnStart(string bookName)
        {
            BookEvent?.Invoke(this, bookName);
        }
    }
}
