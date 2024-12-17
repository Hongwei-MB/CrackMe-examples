using Microsoft.Extensions.DependencyInjection;

namespace CrackMe_02;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        var serviceCollection = new ServiceCollection();
        ConfigureServices(serviceCollection);
        using (var serviceProvider = serviceCollection.BuildServiceProvider())
        {
            var mainForm = serviceProvider.GetRequiredService<Start>();
            Application.Run(mainForm);
        }
    }

    private static void ConfigureServices(ServiceCollection services)
    {
        services.AddTransient<ILoginService, LoginService>();
        services.AddTransient<UserLogin>();
        services.AddSingleton<Start>();
    }
}