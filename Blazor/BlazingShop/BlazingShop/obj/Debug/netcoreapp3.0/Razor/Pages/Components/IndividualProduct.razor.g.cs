#pragma checksum "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\Components\IndividualProduct.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "303dd8c62c5b6a9bebdf314b4889ec9cc0df0c6a"
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
#nullable restore
#line 1 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\Components\IndividualProduct.razor"
using BlazingShop.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\Components\IndividualProduct.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    public class IndividualProduct : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-3");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", " card-background card mb-4");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card-header");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "h4");
            __builder.AddAttribute(10, "class", "my-0 font-weight-normal text-center");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "label");
            __builder.AddAttribute(13, "style", "font-size:23px;color:steelblue;");
            __builder.AddContent(14, 
#nullable restore
#line 8 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\Components\IndividualProduct.razor"
                                                                product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n        ");
            __builder.OpenElement(18, "img");
            __builder.AddAttribute(19, "class", "card-img-top");
            __builder.AddAttribute(20, "style", "height:100%;");
            __builder.AddAttribute(21, "src", 
#nullable restore
#line 12 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\Components\IndividualProduct.razor"
                                                             convertImageToDisplay(product.Image)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(22, "alt", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "card-body card-background");
            __builder.AddAttribute(26, "style", "background-color:#F7F7F7");
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "d-flex justify-content-between align-items-center");
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "btn-group");
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.OpenElement(34, "label");
            __builder.AddAttribute(35, "style", "font-size:20px; color:#a51313");
            __builder.OpenElement(36, "b");
            __builder.AddContent(37, "$");
            __builder.AddContent(38, 
#nullable restore
#line 16 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\Components\IndividualProduct.razor"
                                                                      product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(39, "/sq.ft");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(42);
            __builder.AddAttribute(43, "href", 
#nullable restore
#line 18 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\Components\IndividualProduct.razor"
                                 $"/details/{product.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(44, "class", "btn btn-success pull-right btn-outline-info text-white");
            __builder.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(46, "Details");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(47, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\Components\IndividualProduct.razor"
       
    [Parameter]
    public Product product { get; set; }

     string convertImageToDisplay(byte[] image)
    {
        string finalStr;
        string base64;
        if (image != null)
        {
            base64 = Convert.ToBase64String(image);
            finalStr = string.Format("data:image/jpg;base64,{0}", base64);
            return finalStr;
        }

        var defImage = File.ReadAllBytes(@"wwwroot/images/stones.jpg");
        base64 = Convert.ToBase64String(defImage);
        finalStr = string.Format("data:image/jpg;base64,{0}", base64);
        return finalStr;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
