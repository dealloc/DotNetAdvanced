using GenericsPlayground;

var example1 = new GenericExample();
example1.ExampleMethod<string>("test");
example1.ExampleMethod("test");

var names = new string[] { "test" };

names.Where(name => name.Contains("test"));
