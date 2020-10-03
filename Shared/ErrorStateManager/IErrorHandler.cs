using System;
using System.Threading.Tasks;

namespace BlazorMovies.Shared.ErrorStateManager
{
    public interface IErrorHandler
    {
        event Func<Exception, Task> OnException;
        Task Trigger(Exception ex);
    }
}