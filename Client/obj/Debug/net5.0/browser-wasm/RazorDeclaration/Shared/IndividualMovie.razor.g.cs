#pragma checksum "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/Shared/IndividualMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8560aea8868218e899aecbb5a06feca22c4a9125"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorMovies.Client.Shared
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
using BlazorMovies.Shared;

#line default
#line hidden
#nullable disable
    public partial class IndividualMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/Shared/IndividualMovie.razor"
       
    [Parameter] public Movie Movie { get; set; }
    [Parameter] public bool DisplayButtons { get; set; } = false;

    [Parameter] public EventCallback<Movie> DeleteMovie { get; set; }
   

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
