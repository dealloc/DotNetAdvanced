namespace EventCode
{
    public class ManagerService
    {
        public delegate void SomethingHandler(string eventThatHappened);
        public event SomethingHandler Something;

        public void DoSomething()
        {
            // This triggers the handlers of the "Something" event
            Something("Something has happened!");
        }
    }
}
