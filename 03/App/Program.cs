using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CrackMe_03;

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

        // Add global exception handling
        Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
        AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);


        var serviceCollection = new ServiceCollection();
        ConfigureServices(serviceCollection);
        using (var serviceProvider = serviceCollection.BuildServiceProvider())
        {
            var mainForm = serviceProvider.GetRequiredService<Start>();
            Application.Run(mainForm);
        }
    }

    private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
    {
        if (e.Exception is ExternalException)
        {
            MessageBox.Show("User Name or Password is not correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            MessageBox.Show(e.Exception.Message, "Unhandled Thread Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
        Exception ex = (Exception)e.ExceptionObject;
        MessageBox.Show(ex.Message, "Unhandled UI Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private static void ConfigureServices(ServiceCollection services)
    {
        services.AddTransient<ILoginService, LoginService>();
        services.AddTransient<UserLogin>();
        services.AddSingleton<Start>();
    }
}