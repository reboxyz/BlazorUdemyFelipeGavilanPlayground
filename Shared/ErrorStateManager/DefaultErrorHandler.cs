using System;
using System.Threading.Tasks;

namespace BlazorMovies.Shared.ErrorStateManager
{
    public class DefaultErrorHandler: IErrorHandler
    {
        public event Func<Exception, Task> OnException;
        public async Task Trigger(Exception ex)
        {
            if (OnException != null) await OnException(ex);
        }
    }
}