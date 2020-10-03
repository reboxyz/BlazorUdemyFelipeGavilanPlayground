using System.Threading.Tasks;
using BlazorMovies.Client;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using BlazorMovies.Shared;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace BlazorMovies.Client.Pages
{
    // Note! Class name should have a suffix of 'Base' and should inherits 'ComponentBase'
    public class CounterBase: ComponentBase
    {
        protected int currentCount = 0;

        [CascadingParameter] private Task<AuthenticationState> AuthenticationState { get; set; }

        
        // NOte! This is a method to be called from JS 
        [JSInvokable]
        public async Task IncrementCount()
        {
            var authState = await AuthenticationState;
            var user = authState.User;

            if (user.Identity.IsAuthenticated)
            {
                currentCount++;     
            } else 
            {
                currentCount--;
            }
        }   
    }
}