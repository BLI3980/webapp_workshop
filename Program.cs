// var builder = WebApplication.CreateBuilder(args);
// var app = builder.Build();
// app.MapGet("/", () => "Hello World!");
// app.Run();

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
var app = builder.Build();

app.UseRouting();

app.UseEndpoints(e =>
{
    // http://example.ru/home/index
    e.MapControllerRoute("default", "{controller}/{action}");
});

app.MapGet("/", () => "Hello World!");

app.Run();
