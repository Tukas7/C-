#pragma checksum "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\EventCreate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdb0ae2b8612ced8412077d0dd53b2311d060f12"
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
            __builder.AddMarkupContent(0, "<h3>Создать событие</h3>\r\n\r\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 6 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\EventCreate.razor"
                  newWidget

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "OnValidSubmit", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\EventCreate.razor"
                                            CreateWidget

#line default
#line hidden
#nullable disable
            ))));
            __builder.AddAttribute(4, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "form-group");
                __builder2.AddMarkupContent(7, "<label for=\"title\">Название</label>\r\n        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(8);
                __builder2.AddAttribute(9, "id", (object)("title"));
                __builder2.AddAttribute(10, "class", (object)("form-control"));
                __builder2.AddAttribute(11, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 9 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\EventCreate.razor"
                                                                 newWidget.Title

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(12, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newWidget.Title = __value, newWidget.Title)))));
                __builder2.AddAttribute(13, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newWidget.Title)));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n        ");
                global::__Blazor.BlazorApp2.Shared.EventCreate.TypeInference.CreateValidationMessage_0(__builder2, 15, 16, 
#nullable restore
#line 10 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\EventCreate.razor"
                                  () => newWidget.Title

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 11 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\EventCreate.razor"
         if (string.IsNullOrEmpty(newWidget.Title))
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(17, "<p class=\"text-danger\">Поле \'Название\' не может быть пустым.</p>");
#nullable restore
#line 14 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\EventCreate.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n    ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group");
                __builder2.AddMarkupContent(21, "<label for=\"description\">Описание</label>\r\n        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "id", (object)("description"));
                __builder2.AddAttribute(24, "class", (object)("form-control"));
                __builder2.AddAttribute(25, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 18 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\EventCreate.razor"
                                                                       newWidget.Description

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(26, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newWidget.Description = __value, newWidget.Description)))));
                __builder2.AddAttribute(27, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newWidget.Description)));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n        ");
                global::__Blazor.BlazorApp2.Shared.EventCreate.TypeInference.CreateValidationMessage_1(__builder2, 29, 30, 
#nullable restore
#line 19 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\EventCreate.razor"
                                  () => newWidget.Description

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 20 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\EventCreate.razor"
         if (string.IsNullOrEmpty(newWidget.Description))
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(31, "<p class=\"text-danger\">Поле \'Описание\' не может быть пустым.</p>");
#nullable restore
#line 23 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\EventCreate.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n    ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group");
                __builder2.AddMarkupContent(35, "<label for=\"eventDate\">Дата</label>\r\n        ");
                global::__Blazor.BlazorApp2.Shared.EventCreate.TypeInference.CreateInputDate_2(__builder2, 36, 37, "eventDate", 38, "form-control", 39, 
#nullable restore
#line 27 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\EventCreate.razor"
                                                                     newWidget.EventDate

#line default
#line hidden
#nullable disable
                , 40, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newWidget.EventDate = __value, newWidget.EventDate)), 41, () => newWidget.EventDate);
                __builder2.AddMarkupContent(42, "\r\n        ");
                global::__Blazor.BlazorApp2.Shared.EventCreate.TypeInference.CreateValidationMessage_3(__builder2, 43, 44, 
#nullable restore
#line 28 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\EventCreate.razor"
                                  () => newWidget.EventDate

#line default
#line hidden
#nullable disable
                , 45, "Неверный формат даты. Пожалуйста, введите корректную дату.");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n    ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "form-group");
                __builder2.AddMarkupContent(49, "<label for=\"widgetImages\">Картинка: </label>\r\n        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputFile>(50);
                __builder2.AddAttribute(51, "id", (object)("widgetImages"));
                __builder2.AddAttribute(52, "accept", (object)("image/*"));
                __builder2.AddAttribute(53, "multiple", (object)("true"));
                __builder2.AddAttribute(54, "max", (object)("52428800"));
                __builder2.AddAttribute(55, "OnChange", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\EventCreate.razor"
                                                                                               HandleFileChange

#line default
#line hidden
#nullable disable
                ))));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n    ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "form-group");
                __builder2.AddMarkupContent(59, "<button type=\"submit\" class=\"btn btn-primary\">Создать</button>");
#nullable restore
#line 36 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\EventCreate.razor"
         if (ValidationErrorsExist())
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(60, "<p class=\"text-danger\">Пожалуйста, исправьте все ошибки перед созданием события.</p>");
#nullable restore
#line 39 "C:\Users\Максим\source\repos\BlazorApp1\BlazorApp2\BlazorApp2\Shared\EventCreate.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
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
namespace __Blazor.BlazorApp2.Shared.EventCreate
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", (object)__arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", (object)__arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, global::System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", (object)__arg0);
        __builder.AddAttribute(__seq1, "class", (object)__arg1);
        __builder.AddAttribute(__seq2, "Value", (object)__arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", (object)__arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", (object)__arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, global::System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", (object)__arg0);
        __builder.AddAttribute(__seq1, "ErrorMessage", (object)__arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
