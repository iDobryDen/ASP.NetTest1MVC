namespace Test2MvcApp;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // добавляем поддержку контроллеров с представлениями
        builder.Services.AddControllersWithViews();
        var app = builder.Build();

        // устанавливаем сопоставление маршрутов с контроллерами
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}

