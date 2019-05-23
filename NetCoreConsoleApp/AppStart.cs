using Microsoft.Extensions.DependencyInjection;
using NetCoreConsoleApp.Services.GoodAfternoon;
using NetCoreConsoleApp.Services.GoodMorning;
using NetCoreConsoleApp.Services.Greeting;

namespace NetCoreConsoleApp
{
    public static class AppStart
    {
        private static void Main()
        {
            ServiceCollection serivceCollection = ServiceCollection();
            serivceCollection.StartServices();
        }

        private static void StartServices(this IServiceCollection serviceCollection)
        {
            ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();
            serviceProvider.GetService<IAppRunner>().Run();
        }

        private static ServiceCollection ServiceCollection()
        {
            ServiceCollection result = new ServiceCollection();

            result.AddScoped<IGoodMorningService, GoodMorningService>();
            result.AddScoped<IGoodAfternoonService, GoodAfternoonService>();
            result.AddScoped<IGreetingService, GreetingService>();
            result.AddScoped<IAppRunner, AppRunner>();
            return result;
        }
    }
}
