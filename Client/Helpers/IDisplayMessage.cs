using System.Threading.Tasks;

namespace BlazorMovies.Client.Helpers
{
    public interface IDisplayMessage
    {
        ValueTask DisplayErrorMessage(string message);
        ValueTask DisplaySuccessMessage(string message);
        ValueTask DisplayWarningMessage(string message);
        ValueTask DisplayInfoMessage(string message);
    }
} 