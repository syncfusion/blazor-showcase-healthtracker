using HealthTracker;
using HealthTracker.Shared;
using Syncfusion.Blazor;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddSyncfusionBlazor();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<SundayService>();
builder.Services.AddSingleton<MondayService>();
builder.Services.AddSingleton<TuesdayService>();
builder.Services.AddSingleton<WednesdayService>();
builder.Services.AddSingleton<ThursdayService>();
builder.Services.AddSingleton<FridayService>();
builder.Services.AddSingleton<SaturdayService>();
await builder.Build().RunAsync();
