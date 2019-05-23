using NetCoreConsoleApp.Services.Greeting;

namespace NetCoreConsoleApp
{
    public class AppRunner : IAppRunner
    {
       
        private readonly IGreetingService _greetingService;

        public AppRunner(IGreetingService greetingService)
        {
            
            _greetingService = greetingService;
        }

        public void Run()
        {
            _greetingService.SayGoodMorning();
            _greetingService.SayGoodAfternoon();
        }
    }

    public interface IAppRunner
    {
        void Run();
    }
}
