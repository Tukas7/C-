// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 1 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\EventCreate.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\EventCreate.razor"
using BlazorApp2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\EventCreate.razor"
using BlazorApp2.Services;

#line default
#line hidden
#nullable disable
    public partial class EventCreate : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\EventCreate.razor"
       
    private EventWidget newWidget = new EventWidget { EventDate = DateTime.Today };
    private List<byte[]> uploadedImages = new List<byte[]>();

    [Inject]
    private IEventWidgetService WidgetService { get; set; }

    [Inject]
    private NavigationManager NavigationManager { get; set; }


    private async Task CreateWidget()
    {
        if (!IsValidForm())
        {
            return;
        }

        await WidgetService.AddWidget(newWidget, uploadedImages);
        ClearForm();
        NavigationManager.NavigateTo(NavigationManager.Uri, forceLoad: true);
    }

    private bool IsValidForm()
    {
        return !string.IsNullOrEmpty(newWidget.Title)
            && !string.IsNullOrEmpty(newWidget.Description)
            && newWidget.EventDate != DateTime.MinValue;
    }

    private bool ValidationErrorsExist()
    {
        return !IsValidForm();
    }

    private async Task HandleFileChange(InputFileChangeEventArgs e)
    {
        foreach (var file in e.GetMultipleFiles())
        {
            await using var memoryStream = new MemoryStream();
            await file.OpenReadStream(10485760).CopyToAsync(memoryStream);
            uploadedImages.Add(memoryStream.ToArray());
        }
    }

    private void ClearForm()
    {
        newWidget = new EventWidget();
        uploadedImages.Clear();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
