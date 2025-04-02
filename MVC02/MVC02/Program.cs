using System.Xml.Linq;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();

//app.MapGet(pattern: "/", () => "Hello World!"); //Static


//app.MapGet("/{name}", async  context =>         //Variable
//{
//    var name = context.GetRouteValue("name");
//    await context.Response.WriteAsync($"Hello, {name}!");
//});


//app.MapGet("/Movies/GetMovie", async context =>         
//{
//    await context.Response.WriteAsync("Hello, Movie!");
//});

app.MapControllerRoute(
    name: "Default",
    pattern: "{controller}/{action}/{id?}"
    //,defaults: new { Controller = "Movies", action = "Index" }
);


//app.MapControllerRoute(
//                        name: "DefaultPatternsRoute",
//                        pattern: "{controller=Movies}/{action=GetMovie}/{id}"

//                        );








app.Run();
