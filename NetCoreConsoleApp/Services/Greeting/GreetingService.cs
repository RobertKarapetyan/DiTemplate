using NetCoreConsoleApp.Services.GoodAfternoon;
using NetCoreConsoleApp.Services.GoodMorning;
using static System.Console;

namespace NetCoreConsoleApp.Services.Greeting
{
    public class GreetingService : IGreetingService
    {
        private readonly IGoodMorningService _goodMorningService;
        private readonly IGoodAfternoonService _goodAfternoonService;

        public GreetingService(IGoodMorningService goodMorningService, 
            IGoodAfternoonService goodAfternoonService)
        {
            _goodMorningService = goodMorningService;
            _goodAfternoonService = goodAfternoonService;
        }

        public void SayGoodMorning()
        {
            WriteLine(_goodMorningService.GoodMorningMessage());
        }

        public void SayGoodAfternoon()
        {
            WriteLine(_goodAfternoonService.GoodAfternoonMessage());
        }
    }
}
