#pragma checksum "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/Shared/GenericList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a48be98aa0b05eb5304bde48a699fd9b2bf72bee"
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
    public partial class GenericList<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/Shared/GenericList.razor"
 if(List == null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/Shared/GenericList.razor"
     if (NullContent != null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, 
#nullable restore
#line 8 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/Shared/GenericList.razor"
         NullContent

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 8 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/Shared/GenericList.razor"
                    
    } else 
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "Loading...");
#nullable restore
#line 11 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/Shared/GenericList.razor"
                               
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/Shared/GenericList.razor"
     
} else if (List.Count == 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/Shared/GenericList.razor"
     if (EmptyContent != null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, 
#nullable restore
#line 17 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/Shared/GenericList.razor"
         EmptyContent

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 17 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/Shared/GenericList.razor"
                     
    } else 
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "There are no records to display");
#nullable restore
#line 20 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/Shared/GenericList.razor"
                                                    
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/Shared/GenericList.razor"
     
} else {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/Shared/GenericList.razor"
     if (ElementTemplate != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/Shared/GenericList.razor"
         foreach(var element in List)
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, 
#nullable restore
#line 27 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/Shared/GenericList.razor"
             ElementTemplate(element)

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 27 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/Shared/GenericList.razor"
                                     
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/Shared/GenericList.razor"
         
    } else 
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, 
#nullable restore
#line 31 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/Shared/GenericList.razor"
         WholeListTemplate

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 31 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/Shared/GenericList.razor"
                          
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/Shared/GenericList.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "/Users/erwinrebosura/Documents/Playground/Blazor/FelipeGavilan/BlazorMovies/Client/Shared/GenericList.razor"
       
    [Parameter] public List<TItem> List { get; set; } 
    [Parameter] public RenderFragment<TItem> ElementTemplate { get; set; }
    [Parameter] public RenderFragment WholeListTemplate { get; set; }
    [Parameter] public RenderFragment NullContent { get; set; }
    [Parameter] public RenderFragment EmptyContent { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
