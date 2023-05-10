using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using P138FirstDBMigration.DataAccestLayer;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer("Server=DESKTOP-EUTDEFL\\SQLEXPRESS;Database=P138FirstMigrationDb;Trusted_Connection=true;");
});

var app = builder.Build();

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

app.Run();