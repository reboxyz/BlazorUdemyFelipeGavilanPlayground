using BlazorMovies.Shared.ErrorStateManager;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Client.Helpers
{
    public static class ILoggingBuilderExtensions
    {
        public static ILoggingBuilder CustomLogger(this ILoggingBuilder builder)
        {
            builder.Services
                .AddSingleton<ILoggerProvider, ErrorRecoveryLogProvider>();  
            return builder;
        }
        //public static IServiceCollection AddStateManagemenet(this IServiceCollection services)
        public static IServiceCollection AddCustomDefaultErrorHandler(this IServiceCollection services)
        {
            services.AddSingleton<IErrorHandler, DefaultErrorHandler>();
            services.AddLogging(builder => builder.CustomLogger());
            return services;
        }
    }
}