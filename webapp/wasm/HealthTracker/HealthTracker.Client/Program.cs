using HealthTracker.Shared;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
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
