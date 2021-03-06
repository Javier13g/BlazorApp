#pragma checksum "C:\Users\abdie\Documents\GitHub\BlazorApp\BookCrudBlazor\Pages\Books.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f33fe2b77215589551d830790205c11505d95c10"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\abdie\Documents\GitHub\BlazorApp\BookCrudBlazor\Pages\Books.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\abdie\Documents\GitHub\BlazorApp\BookCrudBlazor\Pages\Books.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\abdie\Documents\GitHub\BlazorApp\BookCrudBlazor\Pages\Books.razor"
using BookCrudBlazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/libros")]
    public partial class Books : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Books2</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"row\" style=\"margin-bottom:10px\">\r\n    <div class=\"col-12 text-center\">\r\n        <a class=\"btn btn-primary btn-lg btn-block\" href=\"/formlibros\">\r\n            A??adir Libros\r\n        </a>\r\n    </div>\r\n</div>\r\n");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.AddMarkupContent(5, "<thead class=\"thead-dark\">\r\n            <tr>\r\n                <th>Titulo</th>\r\n                <th>Categoria</th>\r\n                <th>Sinopsis</th>\r\n                <th>Opciones</th>\r\n            </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(6, "tbody");
            __builder.AddAttribute(7, "class", "thead-light");
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 27 "C:\Users\abdie\Documents\GitHub\BlazorApp\BookCrudBlazor\Pages\Books.razor"
          if (Resp != null && Resp.CongragulationData != null)
         {
             

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\abdie\Documents\GitHub\BlazorApp\BookCrudBlazor\Pages\Books.razor"
              foreach (var x in Resp.CongragulationData)
                 {

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "                     ");
            __builder.OpenElement(10, "tr");
            __builder.AddMarkupContent(11, "\r\n                         ");
            __builder.OpenElement(12, "td");
#nullable restore
#line 32 "C:\Users\abdie\Documents\GitHub\BlazorApp\BookCrudBlazor\Pages\Books.razor"
__builder.AddContent(13, x.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                         ");
            __builder.OpenElement(15, "td");
#nullable restore
#line 33 "C:\Users\abdie\Documents\GitHub\BlazorApp\BookCrudBlazor\Pages\Books.razor"
__builder.AddContent(16, x.Category);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                         ");
            __builder.OpenElement(18, "td");
#nullable restore
#line 34 "C:\Users\abdie\Documents\GitHub\BlazorApp\BookCrudBlazor\Pages\Books.razor"
__builder.AddContent(19, x.Synopsis);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                         ");
            __builder.OpenElement(21, "td");
            __builder.AddMarkupContent(22, "\r\n                             ");
            __builder.OpenElement(23, "a");
            __builder.AddAttribute(24, "class", "btn btn-primary");
            __builder.AddAttribute(25, "href", "/editar/" + (
#nullable restore
#line 36 "C:\Users\abdie\Documents\GitHub\BlazorApp\BookCrudBlazor\Pages\Books.razor"
                                                                       x.IdBook

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, "Editar Libro");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                             ");
            __builder.OpenElement(28, "a");
            __builder.AddAttribute(29, "class", "btn btn-danger");
            __builder.AddAttribute(30, "href", "/eliminar/" + (
#nullable restore
#line 37 "C:\Users\abdie\Documents\GitHub\BlazorApp\BookCrudBlazor\Pages\Books.razor"
                                                                        x.IdBook

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, "Eliminar Libro");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                         ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                     ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 40 "C:\Users\abdie\Documents\GitHub\BlazorApp\BookCrudBlazor\Pages\Books.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\abdie\Documents\GitHub\BlazorApp\BookCrudBlazor\Pages\Books.razor"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "            ");
            __builder.AddMarkupContent(36, "<h5> NO HAY DATOS</h5>\r\n");
#nullable restore
#line 45 "C:\Users\abdie\Documents\GitHub\BlazorApp\BookCrudBlazor\Pages\Books.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(37, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\abdie\Documents\GitHub\BlazorApp\BookCrudBlazor\Pages\Books.razor"
       

    public string API = "/api/Books";
    public Data.RespuestaFront<List<Libros>> Resp = new Data.RespuestaFront<List<Libros>>();
    protected override async Task OnInitializedAsync() =>
        Resp = await Http.GetFromJsonAsync<RespuestaFront<List<Libros>>>(API);

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
