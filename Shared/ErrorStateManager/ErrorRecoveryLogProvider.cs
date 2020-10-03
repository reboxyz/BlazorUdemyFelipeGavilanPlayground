using Microsoft.Extensions.Logging;

namespace BlazorMovies.Shared.ErrorStateManager
{
    public class ErrorRecoveryLogProvider : ILoggerProvider
    {
        private readonly IErrorHandler _handler;
        public ErrorRecoveryLogProvider(IErrorHandler handler)
        {
            _handler = handler;
        }

        public ILogger CreateLogger(string categoryName)
        {
            return new ErrorRecoveryLogger(_handler);
        }

        public void Dispose()
        {
                
        }
    }
}