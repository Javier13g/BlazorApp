// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BookCrudBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\abdie\Documents\GitHub\BlazorApp\BookCrudBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\abdie\Documents\GitHub\BlazorApp\BookCrudBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\abdie\Documents\GitHub\BlazorApp\BookCrudBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\abdie\Documents\GitHub\BlazorApp\BookCrudBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\abdie\Documents\GitHub\BlazorApp\BookCrudBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\abdie\Documents\GitHub\BlazorApp\BookCrudBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\abdie\Documents\GitHub\BlazorApp\BookCrudBlazor\_Imports.razor"
using BookCrudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\abdie\Documents\GitHub\BlazorApp\BookCrudBlazor\_Imports.razor"
using BookCrudBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\abdie\Documents\GitHub\BlazorApp\BookCrudBlazor\_Imports.razor"
using BookCrudBlazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\abdie\Documents\GitHub\BlazorApp\BookCrudBlazor\Pages\Editar.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\abdie\Documents\GitHub\BlazorApp\BookCrudBlazor\Pages\Editar.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\abdie\Documents\GitHub\BlazorApp\BookCrudBlazor\Pages\Editar.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editar/{Id:int}")]
    public partial class Editar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\abdie\Documents\GitHub\BlazorApp\BookCrudBlazor\Pages\Editar.razor"
       
    [Parameter]
    public int Id { get; set; }
    Libros libros = new Libros();
    RespuestaFront<object> resp = new RespuestaFront<object>();
    RespuestaFront<Libros> respBook = new RespuestaFront<Libros>();
    public string API = "/api/Books";

    //Funcion asincrona para guardar datos insertados en el formulario
    private async Task EditarBook()
    {
        var x = await Http.PutAsJsonAsync(API, libros);
        resp = x.Content.ReadFromJsonAsync<RespuestaFront<object>>().Result;


        Nav.NavigateTo("/libros");
    }

    protected override async Task OnInitializedAsync()
    {
        if (Id != 0)
        {
            respBook = await Http.GetFromJsonAsync<RespuestaFront<Libros>>(API +"/"+ Id);
            libros = respBook.CongragulationData;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Nav { get; set; }
    }
}
#pragma warning restore 1591
