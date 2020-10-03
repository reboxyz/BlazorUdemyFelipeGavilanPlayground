#pragma checksum "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/Shared/MoviesList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b9603a2d138d2c0b81b8f0f4776c0d6f9d13a2a"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class MoviesList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "movies-container");
            __Blazor.BlazorMovies.Client.Shared.MoviesList.TypeInference.CreateGenericList_0(__builder, 2, 3, 
#nullable restore
#line 5 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/Shared/MoviesList.razor"
                       Movies

#line default
#line hidden
#nullable disable
            , 4, (movie) => (__builder2) => {
                __builder2.OpenComponent<BlazorMovies.Client.Shared.IndividualMovie>(5);
                __builder2.AddAttribute(6, "Movie", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorMovies.Shared.Entities.Movie>(
#nullable restore
#line 8 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/Shared/MoviesList.razor"
                       movie

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "DeleteMovie", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorMovies.Shared.Entities.Movie>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorMovies.Shared.Entities.Movie>(this, 
#nullable restore
#line 9 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/Shared/MoviesList.razor"
                             DeleteMovie

#line default
#line hidden
#nullable disable
                )));
                __builder2.SetKey(
#nullable restore
#line 10 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/Shared/MoviesList.razor"
                      movie.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseComponent();
            }
            , 8, (__builder2) => {
                __builder2.AddMarkupContent(9, "<text>Loading...</text>");
            }
            , 10, (__builder2) => {
                __builder2.AddMarkupContent(11, "<text>There are no records to display</text>");
            }
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/Shared/MoviesList.razor"
       
    [Parameter] public List<Movie> Movies { get; set; } 
   
    private async Task DeleteMovie(Movie movie)
    {
        await JSRuntime.MyFunction("Calling DeleteMovie");
       
        // Note! Execute JS window.confirm method using BlazorMovies.Client.Helpers.IJSRuntimeExtensionMethods 
        var confirmed = await JSRuntime.Confirm($"Are you sure you want to delete {movie.Title}?");

        if (confirmed)
        {
            await MoviesRepository.DeleteMovie(movie.Id);

            Movies.Remove(movie);
        }    
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMoviesRepository MoviesRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
namespace __Blazor.BlazorMovies.Client.Shared.MoviesList
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGenericList_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::BlazorMovies.Client.Shared.GenericList<TItem>>(seq);
        __builder.AddAttribute(__seq0, "List", __arg0);
        __builder.AddAttribute(__seq1, "ElementTemplate", __arg1);
        __builder.AddAttribute(__seq2, "NullContent", __arg2);
        __builder.AddAttribute(__seq3, "EmptyContent", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
