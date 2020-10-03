using System;

namespace BlazorMovies.Shared.DTO
{
    public class UserToken
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }  // Note! Token itself has Expiration but this prop will make it simple to verify the Expiration without manipulating the Token
    }
}