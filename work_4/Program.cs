using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Work4.Data;



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddDbContext<BookContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("Work4Context") ?? throw new InvalidOperationException("Connection string 'BookContext' not found.")));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseStaticFiles(); 
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();
app.Run();
