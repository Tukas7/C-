#pragma checksum "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6e038c5193b624786426f2f4b01d9d95cce029c"
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
    public partial class NavMenu : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", 
#nullable restore
#line 3 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "b-8klt50xt3z");
            __builder.OpenElement(4, "ul");
            __builder.AddAttribute(5, "class", "nav flex-column");
            __builder.AddAttribute(6, "b-8klt50xt3z");
            __builder.OpenElement(7, "li");
            __builder.AddAttribute(8, "class", "nav-item px-3");
            __builder.AddAttribute(9, "b-8klt50xt3z");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(10);
            __builder.AddAttribute(11, "class", (object)("nav-link"));
            __builder.AddAttribute(12, "href", (object)(""));
            __builder.AddAttribute(13, "Match", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 6 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(14, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(15, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-8klt50xt3z></span> Домой\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddAttribute(19, "b-8klt50xt3z");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", (object)("nav-link"));
            __builder.AddAttribute(22, "href", (object)("create-widget"));
            __builder.AddAttribute(23, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(24, "<span class=\"oi oi-plus\" aria-hidden=\"true\" b-8klt50xt3z></span> Добавить\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
