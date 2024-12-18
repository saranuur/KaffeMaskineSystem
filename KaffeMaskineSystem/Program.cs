using KaffeMaskineSystem.Repository;
using KaffeMaskineSystem.Models;
using KaffeMaskineSystem.Services;
using KaffeMaskineSystem.Data;
using Microsoft.EntityFrameworkCore;
using KaffeMaskineSystem.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));





// Tilføj services
builder.Services.AddRazorPages(); // Tilføj Razor Pages service


builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<UserService>();

builder.Services.AddScoped<ICleaningRepository, CleaningRepository>();
builder.Services.AddScoped<CleaningService>();

builder.Services.AddScoped<ICoffeeMachineRepository, CoffeeMachineRepository>();
builder.Services.AddScoped<CoffeeMachineService>();

builder.Services.AddScoped<IRefillRepository, RefillRepository>();
builder.Services.AddScoped<RefillService>();

builder.Services.AddScoped<HistoryService>();
builder.Services.AddScoped<IHistoryRepository, HistoryRepository>();

builder.Services.AddScoped<TrayEmptyingRecordService>();
builder.Services.AddScoped<ITrayEmptyingRecordRepository, TrayEmptyingRecordRepository>();

builder.Services.AddScoped<TubeChangeService>();
builder.Services.AddScoped<ITubeChangeRepository, TubeChangeRepository>();

builder.Services.AddScoped<MachineMaintenanceRecordService>();
builder.Services.AddScoped<IMachineMaintenanceRecordRepository, MachineMaintenanceRecordRepository>();

builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<INotificationRepository, NotificationRepository>();
// Aktiver sessioner
builder.Services.AddSession();

var app = builder.Build();
// Konfigurer HTTP pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Brug sessioner
app.UseSession();

// Mapper Razor Pages
app.MapRazorPages();

// Kør applikationen
app.Run();
