#pragma checksum "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c9a60bb32e307ea41de9df04f9c9c848878293a"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/_Imports.razor"
using BlazorMovies.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/_Imports.razor"
using BlazorMovies.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/_Imports.razor"
using BlazorMovies.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/_Imports.razor"
using BlazorMovies.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/_Imports.razor"
using BlazorMovies.Shared.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/_Imports.razor"
using BlazorMovies.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/_Imports.razor"
using BlazorMovies.Client.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/index")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "<h3>In Theaters</h3>\r\n    ");
            __builder.OpenComponent<BlazorMovies.Client.Shared.MoviesList>(2);
            __builder.AddAttribute(3, "Movies", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorMovies.Shared.Entities.Movie>>(
#nullable restore
#line 9 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/Pages/Index.razor"
                InTheaters

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "div");
            __builder.AddMarkupContent(6, "<h3>Upcoming Releases</h3>\r\n    ");
            __builder.OpenComponent<BlazorMovies.Client.Shared.MoviesList>(7);
            __builder.AddAttribute(8, "Movies", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorMovies.Shared.Entities.Movie>>(
#nullable restore
#line 16 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/Pages/Index.razor"
                UpcomingReleases

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/Pages/Index.razor"
       
    private List<Movie> InTheaters;
    private List<Movie> UpcomingReleases;

    protected override async Task OnInitializedAsync()
    {
        var response =  await MoviesRepository.GetIndexPageDTO();
        InTheaters = response.InTheaters;
        UpcomingReleases = response.UpcomingReleases;
    }    

    private async Task<IEnumerable<string>> SearchMethod(string searchText)
    {
        await Task.Delay(2000);
        if (searchText == "test")
        {
            return Enumerable.Empty<string>();
        }
        return new List<string>() { "Winnux", "Reboxyz"};
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMoviesRepository MoviesRepository { get; set; }
    }
}
#pragma warning restore 1591
