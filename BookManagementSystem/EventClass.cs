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
        public void EndProcess(string bookname)
        {
            Console.WriteLine("Operation Ended");
        }
        protected virtual void OnStart(string bookName)
        {
            BookEvent?.Invoke(this, bookName);
        }
    }
}
