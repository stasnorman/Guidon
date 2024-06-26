using GuidonApp.Models;
using GuidonApp.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Microsoft.Extensions.DependencyInjection;
using GuidonApp.ActionApp.OdbContext; // �������� ���� using, ���� ��� ���

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<GameService>();

// ���������� ��������� ���� ������ � ��������� DI
builder.Services.AddDbContext<ConnectOdbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// ���������� �������� � ������������� ���� ������
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ConnectOdbContext>();
    dbContext.Database.Migrate(); // ��������� ��� ��������
    // ����� ����� �������� ��� ��� ������������� ��������� ������, ���� �����
}

if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger(option =>
    {
        option.RouteTemplate = "api/{documentName}/swagger.json";
    });
    app.UseSwaggerUI(option =>
    {
        option.SwaggerEndpoint("/api/v1/swagger.json", "������������ � ����");
        option.RoutePrefix = "api";
    });

}
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
