#pragma checksum "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\Components\ChildComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "902662fa363f4c4e9ceec7ce1e563593f9285b21"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingShop.Pages.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\_Imports.razor"
using BlazingShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\_Imports.razor"
using BlazingShop.Shared;

#line default
#line hidden
#nullable disable
    public class ChildComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "panel panel-default");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "panel-heading alert alert-info");
            __builder.AddContent(5, 
#nullable restore
#line 2 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\Components\ChildComponent.razor"
                                                 Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "panel-body alert alert-success");
            __builder.AddContent(9, 
#nullable restore
#line 3 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\Components\ChildComponent.razor"
                                                 ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n    ");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "class", "btn btn-danger");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\Components\ChildComponent.razor"
                                             OnClickMethod

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(14, "\r\n        Button to be clicked!\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\Components\ChildComponent.razor"
       
    [Parameter]
    public string Title { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public EventCallback<MouseEventArgs> OnClickMethod { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
