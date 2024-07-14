using YahyaFarms.Web.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using YahyaFarms.Web.Data;
using YahyaFarms.Web.Service.IService;
using YahyaFarms.Web.Service;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextFactory<YahyaFarmsWebDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("YahyaFarmsWebDbContext") ?? throw new InvalidOperationException("Connection string 'YahyaFarmsWebDbContext' not found.")));

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddScoped<IFileUpload, FileUpload>();
builder.Services.AddServerSideBlazor().AddCircuitOptions(option =>
{
    option.DetailedErrors = true;
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<YahyaFarmsWebDbContext>();
    db.Database.Migrate();
}
app.Run();
