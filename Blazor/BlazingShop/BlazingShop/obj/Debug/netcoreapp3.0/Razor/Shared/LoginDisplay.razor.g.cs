#pragma checksum "C:\Projects\Courses\Blazor\BlazingShop\BlazingShop\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30749b821239647f24545b0cef8b036d3cf4a1dd"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingShop.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Projects\Courses\Blazor\BlazingShop\BlazingShop\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\Courses\Blazor\BlazingShop\BlazingShop\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\Courses\Blazor\BlazingShop\BlazingShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\Courses\Blazor\BlazingShop\BlazingShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projects\Courses\Blazor\BlazingShop\BlazingShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Projects\Courses\Blazor\BlazingShop\BlazingShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Projects\Courses\Blazor\BlazingShop\BlazingShop\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Projects\Courses\Blazor\BlazingShop\BlazingShop\_Imports.razor"
using BlazingShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Projects\Courses\Blazor\BlazingShop\BlazingShop\_Imports.razor"
using BlazingShop.Shared;

#line default
#line hidden
#nullable disable
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.OpenElement(3, "a");
                __builder2.AddAttribute(4, "href", "Identity/Account/Manage");
                __builder2.AddAttribute(5, "class", "text-white-50");
                __builder2.AddContent(6, "Hello, ");
                __builder2.AddContent(7, 
#nullable restore
#line 3 "C:\Projects\Courses\Blazor\BlazingShop\BlazingShop\Shared\LoginDisplay.razor"
                                                                        context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(8, "!");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.AddMarkupContent(10, "<form method=\"post\" action=\"Identity/Account/LogOut\">\r\n            <button type=\"submit\" class=\"text-white-50 nav-link btn btn-link\">Log out</button>\r\n        </form>\r\n    ");
            }
            ));
            __builder.AddAttribute(11, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.AddMarkupContent(13, "<a href=\"Identity/Account/Register\" class=\"text-white-50\">Register</a>\r\n        ");
                __builder2.AddMarkupContent(14, "<a href=\"Identity/Account/Login\" class=\"text-white-50\">Log in</a>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
