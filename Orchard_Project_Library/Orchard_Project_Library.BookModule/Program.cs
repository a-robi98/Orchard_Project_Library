using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Orchard_Project_Library.BookModule.Migrations;
using Orchard_Project_Library.BookModule.Models;
using OrchardCore.ContentManagement;
using OrchardCore.Data.Migration;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddContentPart<BookPart>();
builder.Services.AddScoped<IDataMigration, BookMigration>();
var app = builder.Build();



app.Run();
