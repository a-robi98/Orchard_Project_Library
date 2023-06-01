using OrchardCore.ContentManagement;
using WebApplication1_try.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOrchardCms();
//    .ConfigureServices(tenantServices=>
//{
//    tenantServices.AddContentPart<BookPart>();
//});
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseStaticFiles();
app.UseOrchardCore();

app.Run();
