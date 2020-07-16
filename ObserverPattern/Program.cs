namespace ObserverPattern
{
    class Program
    {
        static void Main()
        {
            var eventManager = new EventManager();
            var loggingObserver = new LoggingObserver();
            var emailAlertsObserver = new EmailAlertsObserver();
            
            eventManager.Subscribe("click", loggingObserver);
            eventManager.Subscribe("click", emailAlertsObserver);
            
            eventManager.Notify("click", "test1");
            
            eventManager.Unsubscribe("click", loggingObserver);
            
            eventManager.Notify("click", "test2");
        }
    }
}