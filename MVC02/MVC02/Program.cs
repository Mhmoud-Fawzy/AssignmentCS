using System.Xml.Linq;

var builder = WebApplication.CreateBuilder(args);

// Add MVC services with view support
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline
app.UseStaticFiles();

app.UseRouting();

// Map the default controller route
app.MapControllerRoute(
    name: "Default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

// Optional: You can uncomment and use this if you want a specific default route
// app.MapControllerRoute(
//     name: "DefaultPatternsRoute",
//     pattern: "{controller=Movies}/{action=GetMovie}/{id}"
// );

app.Run();
