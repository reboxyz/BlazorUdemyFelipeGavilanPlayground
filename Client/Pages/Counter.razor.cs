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
        protected int currentCount = 0;
        
        // NOte! This is a method to be called from JS 
        [JSInvokable]
        public void IncrementCount()
        {
            currentCount++;
        }   
    }
}