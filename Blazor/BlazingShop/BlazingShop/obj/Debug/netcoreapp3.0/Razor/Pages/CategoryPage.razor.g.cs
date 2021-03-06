#pragma checksum "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fe93917f655de03eae51d3fe353e10138447632"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingShop.Pages
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
#line 2 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
using BlazingShop.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
using BlazingShop.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/category")]
    public class CategoryPage : OwningComponentBase<CategoryService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((Auth) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n\r\n");
#nullable restore
#line 11 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
         if (categories == null)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(3, "            ");
                __builder2.AddMarkupContent(4, "<p><em>Loading or No categories exist</em></p>\r\n");
#nullable restore
#line 14 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(5, "            ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "container border p-3");
                __builder2.AddMarkupContent(8, "\r\n                ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "row");
                __builder2.AddMarkupContent(11, "\r\n                    ");
                __builder2.AddMarkupContent(12, "<div class=\"col-5\">\r\n                        <h3 class=\"text-info\">Category List</h3>\r\n                    </div>\r\n                    ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "col-3");
                __builder2.AddMarkupContent(15, "\r\n                        ");
                __builder2.OpenElement(16, "button");
                __builder2.AddAttribute(17, "class", "btn btn-info form-control");
                __builder2.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                                                                            AddNewCategory

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(19, "\r\n                            Add New Category\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n                ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "row pt-4");
                __builder2.AddMarkupContent(25, "\r\n                    ");
                __builder2.OpenElement(26, "table");
                __builder2.AddAttribute(27, "class", "table table-striped");
                __builder2.AddMarkupContent(28, "\r\n                        ");
                __builder2.AddMarkupContent(29, "<thead>\r\n                            <tr>\r\n                                <th>Category Name</th>\r\n                                <th></th>\r\n                            </tr>\r\n                        </thead>\r\n                        ");
                __builder2.OpenElement(30, "tbody");
                __builder2.AddMarkupContent(31, "\r\n");
#nullable restore
#line 37 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                             foreach (var obj in categories)
                            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(32, "                                ");
                __builder2.OpenElement(33, "tr");
                __builder2.AddMarkupContent(34, "\r\n                                    ");
                __builder2.OpenElement(35, "td");
                __builder2.AddContent(36, 
#nullable restore
#line 40 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                                         obj.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                                    ");
                __builder2.OpenElement(38, "td");
                __builder2.AddMarkupContent(39, "\r\n                                        ");
                __builder2.OpenElement(40, "button");
                __builder2.AddAttribute(41, "class", "btn btn-primary");
                __builder2.AddAttribute(42, "style", "width:150px");
                __builder2.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                                                                                                      (() => EditCategory(obj))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(44, "\r\n                                            Edit\r\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n");
#nullable restore
#line 47 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(48, "                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n");
#nullable restore
#line 52 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
         if (ShowPopup)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(53, "            ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "modal");
                __builder2.AddAttribute(56, "tabindex", "-1");
                __builder2.AddAttribute(57, "style", "display:block");
                __builder2.AddAttribute(58, "role", "dialog");
                __builder2.AddMarkupContent(59, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(60);
                __builder2.AddAttribute(61, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 56 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                                  objCategory

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 56 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                                                               ValidSubmit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(64, "\r\n                    ");
                    __builder3.OpenElement(65, "div");
                    __builder3.AddAttribute(66, "class", "modal-dialog");
                    __builder3.AddMarkupContent(67, "\r\n                        ");
                    __builder3.OpenElement(68, "div");
                    __builder3.AddAttribute(69, "class", "modal-content");
                    __builder3.AddMarkupContent(70, "\r\n                            ");
                    __builder3.OpenElement(71, "div");
                    __builder3.AddAttribute(72, "class", "modal-header");
                    __builder3.AddMarkupContent(73, "\r\n                                ");
                    __builder3.OpenElement(74, "h3");
                    __builder3.AddAttribute(75, "class", "text-info");
                    __builder3.AddContent(76, 
#nullable restore
#line 60 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                                                        objCategory.Id != 0 ? "Update" : "Create"

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(77, " Category");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(78, "\r\n                                ");
                    __builder3.OpenElement(79, "button");
                    __builder3.AddAttribute(80, "type", "button");
                    __builder3.AddAttribute(81, "class", "close");
                    __builder3.AddAttribute(82, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                                                                              ClosePopup

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(83, "\r\n                                    ");
                    __builder3.AddMarkupContent(84, "<span aria-hidden=\"true\">X</span>\r\n                                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(85, "\r\n                            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(86, "\r\n                            ");
                    __builder3.OpenElement(87, "div");
                    __builder3.AddAttribute(88, "class", "modal-body");
                    __builder3.AddMarkupContent(89, "\r\n                                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(90);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(91, "\r\n                                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(92);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(93, "\r\n                                ");
                    __builder3.OpenElement(94, "div");
                    __builder3.AddAttribute(95, "class", "row");
                    __builder3.AddMarkupContent(96, "\r\n                                    ");
                    __builder3.OpenElement(97, "div");
                    __builder3.AddAttribute(98, "class", "col-9");
                    __builder3.AddMarkupContent(99, "\r\n                                        ");
                    __builder3.OpenElement(100, "div");
                    __builder3.AddAttribute(101, "class", "row py-2");
                    __builder3.AddMarkupContent(102, "\r\n                                            ");
                    __builder3.AddMarkupContent(103, "<div class=\"col-4\">\r\n                                                Category Name\r\n                                            </div>\r\n                                            ");
                    __builder3.OpenElement(104, "div");
                    __builder3.AddAttribute(105, "class", "col-8");
                    __builder3.AddMarkupContent(106, "\r\n                                                ");
                    __builder3.OpenElement(107, "input");
                    __builder3.AddAttribute(108, "class", "form-control");
                    __builder3.AddAttribute(109, "type", "text");
                    __builder3.AddAttribute(110, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 75 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                                                                                               objCategory.Name

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(111, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objCategory.Name = __value, objCategory.Name));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(112, "\r\n                                            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(113, "\r\n                                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(114, "\r\n                                        ");
                    __builder3.OpenElement(115, "div");
                    __builder3.AddAttribute(116, "class", "row py-2");
                    __builder3.AddMarkupContent(117, "\r\n\r\n                                            ");
                    __builder3.AddMarkupContent(118, "<div class=\"col offset-4\">\r\n                                                <button class=\"btn btn-primary form-control\" type=\"submit\">Submit</button>\r\n                                            </div>\r\n");
#nullable restore
#line 83 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                                             if (objCategory.Id > 0)
                                            {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(119, "                                                ");
                    __builder3.OpenElement(120, "div");
                    __builder3.AddAttribute(121, "class", "col");
                    __builder3.AddMarkupContent(122, "\r\n                                                    ");
                    __builder3.OpenElement(123, "button");
                    __builder3.AddAttribute(124, "class", "btn btn-danger form-control");
                    __builder3.AddAttribute(125, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 87 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                                                                      DeleteCategory

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(126, "type", "submit");
                    __builder3.AddMarkupContent(127, "\r\n                                                        Delete\r\n                                                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(128, "\r\n                                                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(129, "\r\n");
#nullable restore
#line 92 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                                            }

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(130, "\r\n                                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(131, "\r\n                                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(132, "\r\n                                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(133, "\r\n                            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(134, "\r\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(135, "\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(136, "\r\n\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(137, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(138, "\r\n");
#nullable restore
#line 103 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(139, "\r\n    ");
            }
            ));
            __builder.AddAttribute(140, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(141, "\r\n        ");
                __builder2.AddMarkupContent(142, "<p>You\'re not signed in.</p>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 111 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
       

    //[CascadingParameter]
    //private Task<AuthenticationState> authenticationState { get; set; }

    List<Category> categories;
    Category objCategory = new Category();
    bool ShowPopup = false;

    protected override void OnInitialized()
    {
        //var user = (await authenticationState).User;
        //var emailOfUser = user.Identity.Name;
        categories = Service.GetCategories();
    }

    void AddNewCategory()
    {
        objCategory = new Category();
        objCategory.Id = 0;
        ShowPopup = true;
    }

    void EditCategory(Category category)
    {
        objCategory = category;
        ShowPopup = true;
    }

    void DeleteCategory()
    {
        ShowPopup = false;
        var result = Service.DeleteCategory(objCategory);
        categories.Clear();
        categories = Service.GetCategories();
    }

    void ClosePopup()
    {
        ShowPopup = false;
    }

    void ValidSubmit()
    {
        var result = false;
        ShowPopup = false;


        if (objCategory.Id > 0)
        {
            result = Service.UpdateCategory(objCategory);
        }
        else
        {
            result = Service.CreateCategory(objCategory);
        }

        categories = Service.GetCategories();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
