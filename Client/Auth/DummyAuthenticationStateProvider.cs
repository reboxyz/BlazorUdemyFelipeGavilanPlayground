using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;

namespace BlazorMovies.Client.Auth
{
    public class DummyAuthenticationStateProvider : AuthenticationStateProvider
    {
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            //await Task.Delay(3000);
            
            var anonymous = new ClaimsIdentity();       // Not-authenticated
            
            /*  // Authenticated
            var anonymous = new ClaimsIdentity(new List<Claim>() {
                new Claim("key1", "value1"),
                new Claim("key2", "value2"),
                new Claim(ClaimTypes.Name, "Winnux"),
                new Claim(ClaimTypes.Email, "reboxyz@test.com"),
                new Claim(ClaimTypes.Role, "Admin")
            }, "dummy");
            */
            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(anonymous)));
        }
    }
}