using EventCode;

void Handler1(string name)
{
    Console.WriteLine("Handler 1");
}

void Handler2(string name)
{
    Console.WriteLine("Handler 2");
}

var manager = new ManagerService();
manager.Something += Handler1; // Subscribes Handler1 to the Something event
manager.Something += Handler2; // Subscribes Handler2 to the Something event

manager.DoSomething();
Console.WriteLine("--- second event trigger ---");

manager.Something -= Handler1;

manager.DoSomething();