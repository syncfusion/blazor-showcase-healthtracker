using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Syncfusion.Blazor;
using HealthTracker.Shared;
using HealthTracker.Client;
using System.Net.Http;

namespace HealthTracker
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            builder.Services.AddSyncfusionBlazor(true);
            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSingleton<SundayService>();
            builder.Services.AddSingleton<MondayService>();
            builder.Services.AddSingleton<TuesdayService>();
            builder.Services.AddSingleton<WednesdayService>();
            builder.Services.AddSingleton<ThursdayService>();
            builder.Services.AddSingleton<FridayService>();
            builder.Services.AddSingleton<SaturdayService>();      
            await builder.Build().RunAsync();
        }
    }
}
