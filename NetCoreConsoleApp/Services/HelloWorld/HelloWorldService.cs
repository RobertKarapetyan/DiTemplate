namespace NetCoreConsoleApp.Services.HelloWorld
{
    public class HelloWorldService : IHelloWorldService
    {
        public string Greeting()
        {
            return "Greetings, from Hello World Service!";
        }
    }
}
