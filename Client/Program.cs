using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using BlazorMovies.Client.Helpers;
using Tewr.Blazor.FileReader;

namespace BlazorMovies.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            // Setup DI
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddTransient<IRepository, RepositoryInMemory>();
            builder.Services.AddFileReaderService(opt => opt.InitializeOnFirstCall = true);   // Tewr.Blazor.FileReader

            await builder.Build().RunAsync();
        }
    }
}
