#pragma checksum "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\Events.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6546c469a9d77133dbed6c7ce28955fe62714d7"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp2.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\_Imports.razor"
using BlazorApp2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\_Imports.razor"
using BlazorApp2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\_Imports.razor"
using Blazorise.Bootstrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\_Imports.razor"
using Blazorise.Icons.FontAwesome;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\_Imports.razor"
using Blazorise.DataGrid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\_Imports.razor"
using Blazorise.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\Events.razor"
using BlazorApp2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\Events.razor"
using BlazorApp2.Services;

#line default
#line hidden
#nullable disable
    public partial class Events : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\Events.razor"
 if (widgets == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p>Loading...</p>");
#nullable restore
#line 8 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\Events.razor"
}
else if (widgets.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p>Сегодня нет событий</p>");
#nullable restore
#line 12 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\Events.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "widget-container");
#nullable restore
#line 16 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\Events.razor"
         foreach (var widget in widgets)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "widget");
            __builder.OpenElement(6, "h4");
#nullable restore
#line 19 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\Events.razor"
__builder.AddContent(7, widget.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n                ");
            __builder.OpenElement(9, "p");
#nullable restore
#line 20 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\Events.razor"
__builder.AddContent(10, widget.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\Events.razor"
                 if (widget.Images != null && widget.Images.Count > 0)
                {
                    foreach (var image in widget.Images)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "img");
            __builder.AddAttribute(12, "class", "eventImg");
            __builder.AddAttribute(13, "src", "data:image/png;base64," + (
#nullable restore
#line 25 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\Events.razor"
                                                                          Convert.ToBase64String(image)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "alt", "Event Image");
            __builder.CloseElement();
#nullable restore
#line 26 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\Events.razor"
                    }
                }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "p");
#nullable restore
#line 28 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\Events.razor"
__builder.AddContent(16, widget.EventDate.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 30 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\Events.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\Events.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\Events.razor"
       
    List<EventWidget> widgets;

    protected override async Task OnInitializedAsync()
    {
        widgets = await WidgetService.GetWidgetsForCurrentDate();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEventWidgetService WidgetService { get; set; }
    }
}
#pragma warning restore 1591
