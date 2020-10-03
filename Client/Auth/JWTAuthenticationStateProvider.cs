using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;
using BlazorMovies.Client.Helpers;
using System.Security.Claims;
using System.Net.Http;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text.Json;
using System;
using System.Linq;

namespace BlazorMovies.Client.Auth
{
    public class JWTAuthenticationStateProvider: AuthenticationStateProvider, ILoginService
    {
        private readonly string JWT_TOKEN_KEY = "JWTTOKENKEY";
        private AuthenticationState Anonymous => new AuthenticationState(
                new ClaimsPrincipal(new ClaimsIdentity())
            );
        private readonly IJSRuntime _js;
        private readonly HttpClient _httpClient;

        public JWTAuthenticationStateProvider(IJSRuntime js, HttpClient httpClient)
        {
            _httpClient = httpClient;
            _js = js;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            // Read token from Local Storage
            var token = await _js.GetFromLocalStorage(JWT_TOKEN_KEY);

            if (string.IsNullOrEmpty(token))
            {
                return Anonymous;
            }

            return BuildAuthenticationState(token);
        }

        public AuthenticationState BuildAuthenticationState(string jwtToken)
        {
            // Setup bearer Header in the HttpClient so that each request will contain the bearer token
            // Note! HttpClient is Singleton service
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", jwtToken);
            return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity(ParseClaimsFromJwt(jwtToken), "jwt")));
        }

        // Note! This code is from Microsoft
        private IEnumerable<Claim> ParseClaimsFromJwt(string jwt)
        {
            var claims = new List<Claim>();
            var payload = jwt.Split('.')[1];
            var jsonBytes = ParseBase64WithoutPadding(payload);
            var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);

            keyValuePairs.TryGetValue(ClaimTypes.Role, out object roles);

            if (roles != null)
            {
                if (roles.ToString().Trim().StartsWith("["))
                {
                    var parsedRoles = JsonSerializer.Deserialize<string[]>(roles.ToString());

                    foreach (var parsedRole in parsedRoles)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, parsedRole));
                    }
                }
                else
                {
                    claims.Add(new Claim(ClaimTypes.Role, roles.ToString()));
                }

                keyValuePairs.Remove(ClaimTypes.Role);
            }

            claims.AddRange(keyValuePairs.Select(kvp => new Claim(kvp.Key, kvp.Value.ToString())));
            return claims;
        }

        // Note! This code is from Microsoft
        private byte[] ParseBase64WithoutPadding(string base64)
        {
            switch (base64.Length % 4)
            {
                case 2: base64 += "=="; break;
                case 3: base64 += "="; break;
            }
            return Convert.FromBase64String(base64);
        }

        public async Task Login(string token)
        {
            // Set new token to Local Storage
            await _js.SetInLocalStorage(JWT_TOKEN_KEY, token);
            // Build a new AuthenticationState based on the new token
            var authState = BuildAuthenticationState(token);
            NotifyAuthenticationStateChanged(Task.FromResult(authState));
        }

        public async Task Logout()
        {
            // Set new token to Local Storage
            await _js.RemoveItem(JWT_TOKEN_KEY);
            // Clear bear token Header
            _httpClient.DefaultRequestHeaders.Authorization = null;
            // Set back to Anonymous
            NotifyAuthenticationStateChanged(Task.FromResult(Anonymous));
        }
    }
}