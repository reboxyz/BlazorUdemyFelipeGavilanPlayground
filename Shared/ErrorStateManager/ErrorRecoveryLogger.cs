using System;
using Microsoft.Extensions.Logging;

namespace BlazorMovies.Shared.ErrorStateManager
{
    public class ErrorRecoveryLogger: ILogger
    {
        private readonly IErrorHandler _errorHendler;
        public ErrorRecoveryLogger(IErrorHandler errorHendler)
        {
            _errorHendler = errorHendler;
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return new FakeScope();
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return logLevel >= LogLevel.Error;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
             if (logLevel < LogLevel.Error) return;
             _errorHendler.Trigger(exception);
        }
    }

     public class FakeScope : IDisposable
    {
        public void Dispose()
        {
            
        }
    }
}