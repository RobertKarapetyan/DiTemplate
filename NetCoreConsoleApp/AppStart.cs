using Microsoft.Extensions.DependencyInjection;
using NetCoreConsoleApp.Services.HelloWorld;

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
            ServiceCollection serivceCollection = new ServiceCollection();

            serivceCollection.AddScoped<IHelloWorldService, HelloWorldService>();
            serivceCollection.AddScoped<IAppRunner, AppRunnerRunner>();
            return serivceCollection;
        }
    }
}
