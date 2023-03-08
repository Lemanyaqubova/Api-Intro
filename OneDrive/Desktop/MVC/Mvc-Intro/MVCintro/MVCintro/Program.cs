var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.MapControllerRoute(
    "default",
    "{controller}/{action}/{id}");



app.Run();
