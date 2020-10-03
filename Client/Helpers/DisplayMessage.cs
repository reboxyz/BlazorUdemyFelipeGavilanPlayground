using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace BlazorMovies.Client.Helpers
{
    public class DisplayMessage : IDisplayMessage
    {
        private readonly IJSRuntime _jSRuntime;
        public DisplayMessage(IJSRuntime jSRuntime)
        {
            _jSRuntime = jSRuntime;
        }

        private async ValueTask DoDisplayMessage(string title, string message, string messageType)
        {
            await _jSRuntime.InvokeVoidAsync("Swal.fire", title, message, messageType);
        }        

        public async ValueTask DisplayErrorMessage(string message)
        {
            await DoDisplayMessage("Error", message, "error");
        }

        public async ValueTask DisplaySuccessMessage(string message)
        {
            await DoDisplayMessage("Success", message, "success");
        }

        public async ValueTask DisplayWarningMessage(string message)
        {
            await DoDisplayMessage("Warning", message, "warning");
        }

        public async ValueTask DisplayInfoMessage(string message)
        {
            await DoDisplayMessage("Info", message, "info");
        }
    }
}