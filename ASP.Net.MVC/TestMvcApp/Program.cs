namespace TestMvcApp;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers(); //Добавляем поддержку контроллеров

        var app = builder.Build();

        // устанавливаем сопоставление маршрутов с контроллерами
        app.MapControllerRoute
            (
                name: "default",
                pattern: "{controller=name}/{action=Index}/{id?}" 
            );

        app.MapGet("/", () => "Hello World!!!");

        app.Run();
    }
}

