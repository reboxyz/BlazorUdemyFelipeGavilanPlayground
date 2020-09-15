using System.Threading.Tasks;
using BlazorMovies.Client;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using BlazorMovies.Shared;

namespace BlazorMovies.Client.Pages
{
    // Note! Class name should have a suffix of 'Base' and should inherits 'ComponentBase'
    public class CounterBase: ComponentBase
    {
        [Inject] public SingletonService SingletonService { get; set; }
        [Inject] public TransientService TransientService { get; set; }
        [Inject] public IJSRuntime JSRuntime { get; set; }
        /*
        [CascadingParameter(Name="Color")] public string Color { get; set; }
        [CascadingParameter(Name="Size")] public string Size { get; set; }
        */
        [CascadingParameter] public AppState AppState { get; set; }

        protected int currentCount = 0;
        private static int currentCountStatic = 0;

        // NOte! This is a method to be called from JS 
        [JSInvokable]
        public async Task IncrementCount()
        {
            currentCount++;
            currentCountStatic++;
            TransientService.Value = currentCount;
            SingletonService.Value = currentCount;

            await JSRuntime.InvokeVoidAsync("dotnetStaticInvocation");
        }   

        // NOte! This is a method to be called from JS 
        [JSInvokable]
        public static Task<int> GetCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }

        public async Task IncrementCountJavaScript()
        {
            await JSRuntime.InvokeVoidAsync("dotnetInstanceInvocation",
                DotNetObjectReference.Create(this)   // Note! Reference to an Instance Object where the 'IncrementCount' or method to invoke is defined
            );
        }

    }
}