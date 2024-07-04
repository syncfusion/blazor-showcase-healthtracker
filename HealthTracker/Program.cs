using HealthTracker.Client;
using HealthTracker.Client.Pages;
using HealthTracker.Components;
using HealthTracker.Shared;
using Syncfusion.Blazor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents();
builder.Services.AddSyncfusionBlazor();
builder.Services.AddSingleton<SundayService>();
builder.Services.AddSingleton<MondayService>();
builder.Services.AddSingleton<TuesdayService>();
builder.Services.AddSingleton<WednesdayService>();
builder.Services.AddSingleton<ThursdayService>();
builder.Services.AddSingleton<FridayService>();
builder.Services.AddSingleton<SaturdayService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Routes).Assembly);

app.Run();
