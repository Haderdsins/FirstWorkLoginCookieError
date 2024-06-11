using Microsoft.EntityFrameworkCore;
using ToDoList.Domain;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection"); //считываем строку подключения
builder.Services.AddDbContext<ToDoListContext>(opt =>
    opt.UseSqlServer(
        connectionString)); //регистрируеим контекст базы данных в контрейнер зависимости, также указываем что в качестве настройки используем субд sql сервер
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    "default",
    "{controller=Home}/{action=Index}/{id?}");

app.Run();