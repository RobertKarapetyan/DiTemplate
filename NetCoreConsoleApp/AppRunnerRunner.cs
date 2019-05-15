using System;
using NetCoreConsoleApp.Services.HelloWorld;

namespace NetCoreConsoleApp
{
    public class AppRunnerRunner : IAppRunner
    {
        private readonly IHelloWorldService _helloWorldService;
        public AppRunnerRunner(IHelloWorldService helloWorldService)
        {
            _helloWorldService = helloWorldService;
        }

        public void Run()
        {
            Console.WriteLine(_helloWorldService.Greeting());
        }
    }
}
