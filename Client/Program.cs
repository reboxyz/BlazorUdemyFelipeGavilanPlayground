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
using BlazorMovies.Client.Repository;
using BlazorMovies.Client.Auth;
using Microsoft.AspNetCore.Components.Authorization;
using Client.Helpers;

namespace BlazorMovies.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            // Setup DI
            builder.Services.AddAuthorizationCore();
            //builder.Services.AddScoped<AuthenticationStateProvider, DummyAuthenticationStateProvider>();
            
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddTransient<IRepository, RepositoryInMemory>();
            
            builder.Services.AddScoped<IHttpService, HttpService>();
            builder.Services.AddScoped<IGenreRepository, GenreRepository>();
            builder.Services.AddScoped<IPersonRepository, PersonRepository>();
            builder.Services.AddScoped<IMoviesRepository, MoviesRepository>();
            builder.Services.AddScoped<IAccountsRepository, AccountsRepository>();
            builder.Services.AddScoped<IRatingRepository, RatingRepository>();
            builder.Services.AddScoped<IDisplayMessage, DisplayMessage>();
            builder.Services.AddScoped<IUsersRepository, UsersRepository>();

            builder.Services.AddFileReaderService(opt => opt.InitializeOnFirstCall = true);   // Tewr.Blazor.FileReader

            // Note! JWTAuthenticationStateProvider implements both AuthenticationStateProvider and ILoginService
            builder.Services.AddScoped<JWTAuthenticationStateProvider>();  // This is the same instance to be used in injecting to AuthenticationStateProvider and ILoginService 

            builder.Services.AddScoped<AuthenticationStateProvider, JWTAuthenticationStateProvider>(
                provider => provider.GetRequiredService<JWTAuthenticationStateProvider>()
            );
            builder.Services.AddScoped<ILoginService, JWTAuthenticationStateProvider>(
                provider => provider.GetRequiredService<JWTAuthenticationStateProvider>()
            );
            

            await builder.Build().RunAsync();
        }
    }
}
