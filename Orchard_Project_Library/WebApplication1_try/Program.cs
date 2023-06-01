using WebApplication1_try.Migrations;
using WebApplication1_try.Models;
using OrchardCore.ContentManagement;
using OrchardCore.Data.Migration;
using OrchardCore.ContentManagement.Display.ContentDisplay;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//builder.Services.AddContentPart<BookPart>();
builder.Services.AddSingleton<ContentPart, BookPart>();
builder.Services.AddScoped<IDataMigration, BookMigration>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();


//app.UseRouting();

//app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
