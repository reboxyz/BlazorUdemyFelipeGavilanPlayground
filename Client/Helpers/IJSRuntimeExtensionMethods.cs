using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace BlazorMovies.Client.Helpers
{
    public static class IJSRuntimeExtensionMethods
    {
        public static async ValueTask<bool> Confirm(this IJSRuntime jSRuntime, string message)
        {
            await jSRuntime.InvokeVoidAsync("console.log", "Testing console.log");
            return await jSRuntime.InvokeAsync<bool>("confirm", message);  // Execute JS window.confirm method
        }

        public static async ValueTask MyFunction(this IJSRuntime jSRuntime, string message)
        {
            // Note! 'my_function' is defined in wwwroot/js/CustomUtilities.js which 
            // is set in the index.html as <script src="js/CustomUtilities.js"></script>
            await jSRuntime.InvokeVoidAsync("my_function", message);
        }
    }
}