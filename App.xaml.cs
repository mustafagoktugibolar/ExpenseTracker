using ExpenseTracker.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;
using ExpenseTracker.Services;
using Microsoft.EntityFrameworkCore;
using ExpenseTracker.Views;

namespace ExpenseTracker
{
    public partial class App : Application
    {
        public static IHost AppHost { get; private set; }

        static App()
        {
            AppHost = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContext<SQLiteDbContext>(options =>
                        options.UseSqlite("Data Source=ExpenseTracker.db"));

                    // Register ViewModels
                    services.AddSingleton<MainViewModel>();
                    services.AddSingleton<LoginViewModel>();
                    services.AddSingleton<RegisterViewModel>();
                    services.AddSingleton<SignupViewModel>();

                    // Register Views
                    services.AddSingleton<MainWindow>();
                    services.AddSingleton<LoginView>();
                    services.AddSingleton<SignupView>();

                })
                .Build();   
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            await AppHost.StartAsync();

            var mainWindow = AppHost.Services.GetRequiredService<MainWindow>();
            mainWindow.Show();

            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await AppHost.StopAsync();
            AppHost.Dispose();

            base.OnExit(e);
        }
    }
}
