//namespace TestMvcApp;

//public class Program
//{
//public static void Main(string[] args)
//{
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //Добавляем поддержку контроллеров с представлениями

var app = builder.Build();

// устанавливаем сопоставление маршрутов с контроллерами
app.MapControllerRoute
    (
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
    );

//app.MapGet("/", () => "Hello World!!!");

app.Run();
//}
//}