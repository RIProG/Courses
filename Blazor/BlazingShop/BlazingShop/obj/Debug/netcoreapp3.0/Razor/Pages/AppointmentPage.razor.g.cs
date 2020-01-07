#pragma checksum "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\AppointmentPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "066d16b93a81bddf33f58218f96f17622a64bb5a"
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
#line 2 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\AppointmentPage.razor"
using BlazingShop.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\AppointmentPage.razor"
using BlazingShop.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/appointment")]
    public class AppointmentPage : OwningComponentBase<AppointmentService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((Auth) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n\r\n");
#nullable restore
#line 11 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\AppointmentPage.razor"
         if (appointments == null)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(3, "            ");
                __builder2.AddMarkupContent(4, "<p><em>Loading or No appointments exist</em></p>\r\n");
#nullable restore
#line 14 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\AppointmentPage.razor"
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
                __builder2.AddMarkupContent(9, "<div class=\"row\">\r\n                    <div class=\"col-5\">\r\n                        <h3 class=\"text-info\">Appointment List</h3>\r\n                    </div>\r\n                </div>\r\n                ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "row pt-4");
                __builder2.AddMarkupContent(12, "\r\n                    ");
                __builder2.OpenElement(13, "table");
                __builder2.AddAttribute(14, "class", "table table-striped");
                __builder2.AddMarkupContent(15, "\r\n                        ");
                __builder2.AddMarkupContent(16, @"<thead>
                            <tr>
                                <th>Name</th>
                                <th>Email</th>
                                <th>Phone</th>
                                <th>Product Name</th>
                                <th>Date</th>
                                <th>Confirmed</th>
                                <th></th>
                            </tr>
                        </thead>
                        ");
                __builder2.OpenElement(17, "tbody");
                __builder2.AddMarkupContent(18, "\r\n");
#nullable restore
#line 37 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\AppointmentPage.razor"
                             foreach (var appointment in appointments)
                            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(19, "                                ");
                __builder2.OpenElement(20, "tr");
                __builder2.AddMarkupContent(21, "\r\n                                    ");
                __builder2.OpenElement(22, "td");
                __builder2.AddContent(23, 
#nullable restore
#line 40 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\AppointmentPage.razor"
                                         appointment.CustomerName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                                    ");
                __builder2.OpenElement(25, "td");
                __builder2.AddContent(26, 
#nullable restore
#line 41 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\AppointmentPage.razor"
                                         appointment.CustomerEmail

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n                                    ");
                __builder2.OpenElement(28, "td");
                __builder2.AddContent(29, 
#nullable restore
#line 42 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\AppointmentPage.razor"
                                         appointment.CustomerPhone

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                                    ");
                __builder2.OpenElement(31, "td");
                __builder2.AddContent(32, 
#nullable restore
#line 43 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\AppointmentPage.razor"
                                         appointment.AppointmentDate.ToShortDateString()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                                    ");
                __builder2.OpenElement(34, "td");
                __builder2.AddContent(35, 
#nullable restore
#line 44 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\AppointmentPage.razor"
                                         appointment.Product.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                                    ");
                __builder2.OpenElement(37, "td");
                __builder2.OpenElement(38, "input");
                __builder2.AddAttribute(39, "type", "checkbox");
                __builder2.AddAttribute(40, "checked", 
#nullable restore
#line 45 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\AppointmentPage.razor"
                                                                          appointment.IsConfirmed

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(41, "class", "form-control");
                __builder2.AddAttribute(42, "disabled", true);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                                    ");
                __builder2.OpenElement(44, "td");
                __builder2.AddMarkupContent(45, "\r\n                                        ");
                __builder2.OpenElement(46, "button");
                __builder2.AddAttribute(47, "class", "btn btn-primary");
                __builder2.AddAttribute(48, "style", "width:150px;");
                __builder2.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\AppointmentPage.razor"
                                                          (() => EditAppointment(appointment))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(50, "\r\n                                            Edit\r\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n");
#nullable restore
#line 54 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\AppointmentPage.razor"
                            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(54, "                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n");
#nullable restore
#line 59 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\AppointmentPage.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\AppointmentPage.razor"
         if (ShowPopup)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(59, "            ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "modal");
                __builder2.AddAttribute(62, "tabindex", "-1");
                __builder2.AddAttribute(63, "style", "display:block");
                __builder2.AddAttribute(64, "role", "dialog");
                __builder2.AddMarkupContent(65, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(66);
                __builder2.AddAttribute(67, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 63 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\AppointmentPage.razor"
                                  objAppointment

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(68, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 63 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\AppointmentPage.razor"
                                                                  ValidSubmit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(70, "\r\n                    ");
                    __builder3.OpenElement(71, "div");
                    __builder3.AddAttribute(72, "class", "modal-dialog");
                    __builder3.AddMarkupContent(73, "\r\n                        ");
                    __builder3.OpenElement(74, "div");
                    __builder3.AddAttribute(75, "class", "modal-content");
                    __builder3.AddMarkupContent(76, "\r\n                            ");
                    __builder3.OpenElement(77, "div");
                    __builder3.AddAttribute(78, "class", "modal-header");
                    __builder3.AddMarkupContent(79, "\r\n                                ");
                    __builder3.AddMarkupContent(80, "<h3 class=\"text-info\">Edit Appointment</h3>\r\n\r\n                                ");
                    __builder3.OpenElement(81, "button");
                    __builder3.AddAttribute(82, "type", "button");
                    __builder3.AddAttribute(83, "class", "close");
                    __builder3.AddAttribute(84, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\AppointmentPage.razor"
                                                                              ClosePopup

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(85, "\r\n                                    ");
                    __builder3.AddMarkupContent(86, "<span aria-hidden=\"true\">X</span>\r\n                                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(87, "\r\n                            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(88, "\r\n                            ");
                    __builder3.OpenElement(89, "div");
                    __builder3.AddAttribute(90, "class", "modal-body");
                    __builder3.AddMarkupContent(91, "\r\n                                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(92);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(93, "\r\n                                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(94);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(95, "\r\n                                ");
                    __builder3.OpenElement(96, "div");
                    __builder3.AddAttribute(97, "class", "row");
                    __builder3.AddMarkupContent(98, "\r\n                                    ");
                    __builder3.OpenElement(99, "div");
                    __builder3.AddAttribute(100, "class", "col-9");
                    __builder3.AddMarkupContent(101, "\r\n                                        ");
                    __builder3.OpenElement(102, "div");
                    __builder3.AddAttribute(103, "class", "row py-2");
                    __builder3.AddMarkupContent(104, "\r\n                                            ");
                    __builder3.AddMarkupContent(105, "<div class=\"col-4\">\r\n                                                Name\r\n                                            </div>\r\n                                            ");
                    __builder3.OpenElement(106, "div");
                    __builder3.AddAttribute(107, "class", "col-8");
                    __builder3.AddMarkupContent(108, "\r\n                                                ");
                    __builder3.OpenElement(109, "input");
                    __builder3.AddAttribute(110, "class", "form-control");
                    __builder3.AddAttribute(111, "type", "text");
                    __builder3.AddAttribute(112, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 83 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\AppointmentPage.razor"
                                                                                               objAppointment.CustomerName

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(113, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objAppointment.CustomerName = __value, objAppointment.CustomerName));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(114, "\r\n                                            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(115, "\r\n                                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(116, "\r\n\r\n                                        ");
                    __builder3.OpenElement(117, "div");
                    __builder3.AddAttribute(118, "class", "row py-2");
                    __builder3.AddMarkupContent(119, "\r\n                                            ");
                    __builder3.AddMarkupContent(120, "<div class=\"col-4\">\r\n                                                Email\r\n                                            </div>\r\n                                            ");
                    __builder3.OpenElement(121, "div");
                    __builder3.AddAttribute(122, "class", "col-8");
                    __builder3.AddMarkupContent(123, "\r\n                                                ");
                    __builder3.OpenElement(124, "input");
                    __builder3.AddAttribute(125, "class", "form-control");
                    __builder3.AddAttribute(126, "type", "text");
                    __builder3.AddAttribute(127, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 92 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\AppointmentPage.razor"
                                                                                               objAppointment.CustomerEmail

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(128, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objAppointment.CustomerEmail = __value, objAppointment.CustomerEmail));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(129, "\r\n                                            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(130, "\r\n                                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(131, "\r\n\r\n                                        ");
                    __builder3.OpenElement(132, "div");
                    __builder3.AddAttribute(133, "class", "row py-2");
                    __builder3.AddMarkupContent(134, "\r\n                                            ");
                    __builder3.AddMarkupContent(135, "<div class=\"col-4\">\r\n                                                Phone\r\n                                            </div>\r\n                                            ");
                    __builder3.OpenElement(136, "div");
                    __builder3.AddAttribute(137, "class", "col-8");
                    __builder3.AddMarkupContent(138, "\r\n                                                ");
                    __builder3.OpenElement(139, "input");
                    __builder3.AddAttribute(140, "class", "form-control");
                    __builder3.AddAttribute(141, "type", "text");
                    __builder3.AddAttribute(142, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 101 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\AppointmentPage.razor"
                                                                                               objAppointment.CustomerPhone

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(143, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objAppointment.CustomerPhone = __value, objAppointment.CustomerPhone));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(144, "\r\n                                            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(145, "\r\n                                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(146, "\r\n\r\n                                        ");
                    __builder3.OpenElement(147, "div");
                    __builder3.AddAttribute(148, "class", "row py-2");
                    __builder3.AddMarkupContent(149, "\r\n                                            ");
                    __builder3.AddMarkupContent(150, "<div class=\"col-4\">\r\n                                                Product\r\n                                            </div>\r\n                                            ");
                    __builder3.OpenElement(151, "div");
                    __builder3.AddAttribute(152, "class", "col-8");
                    __builder3.AddMarkupContent(153, "\r\n                                                ");
                    __builder3.OpenElement(154, "input");
                    __builder3.AddAttribute(155, "class", "form-control");
                    __builder3.AddAttribute(156, "type", "text");
                    __builder3.AddAttribute(157, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 110 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\AppointmentPage.razor"
                                                                                               objAppointment.Product.Name

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(158, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objAppointment.Product.Name = __value, objAppointment.Product.Name));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(159, "\r\n                                            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(160, "\r\n                                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(161, "\r\n\r\n                                        ");
                    __builder3.OpenElement(162, "div");
                    __builder3.AddAttribute(163, "class", "row py-2");
                    __builder3.AddMarkupContent(164, "\r\n                                            ");
                    __builder3.AddMarkupContent(165, "<div class=\"col-4\">\r\n                                                Date\r\n                                            </div>\r\n                                            ");
                    __builder3.OpenElement(166, "div");
                    __builder3.AddAttribute(167, "class", "col-8");
                    __builder3.AddMarkupContent(168, "\r\n                                                ");
                    __builder3.OpenElement(169, "input");
                    __builder3.AddAttribute(170, "class", "form-control");
                    __builder3.AddAttribute(171, "type", "text");
                    __builder3.AddAttribute(172, "value", 
#nullable restore
#line 119 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\AppointmentPage.razor"
                                                                                                objAppointment.AppointmentDate.ToShortDateString()

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(173, "\r\n                                            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(174, "\r\n                                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(175, "\r\n\r\n                                        ");
                    __builder3.OpenElement(176, "div");
                    __builder3.AddAttribute(177, "class", "row py-2");
                    __builder3.AddMarkupContent(178, "\r\n                                            ");
                    __builder3.AddMarkupContent(179, "<div class=\" offset-4 col\">\r\n                                                <button class=\"btn btn-success form-control\" type=\"submit\">Confirm!</button>\r\n                                            </div>\r\n                                            ");
                    __builder3.OpenElement(180, "div");
                    __builder3.AddAttribute(181, "class", "col");
                    __builder3.AddMarkupContent(182, "\r\n                                                ");
                    __builder3.OpenElement(183, "button");
                    __builder3.AddAttribute(184, "class", "btn btn-danger form-control");
                    __builder3.AddAttribute(185, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 128 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\AppointmentPage.razor"
                                                                                                      DeleteAppointment

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(186, "\r\n                                                    Delete\r\n                                                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(187, "\r\n                                            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(188, "\r\n                                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(189, "\r\n                                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(190, "\r\n                                    ");
                    __builder3.OpenElement(191, "div");
                    __builder3.AddAttribute(192, "class", "col-3 ");
                    __builder3.AddMarkupContent(193, "\r\n                                        ");
                    __builder3.OpenElement(194, "img");
                    __builder3.AddAttribute(195, "src", 
#nullable restore
#line 135 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\AppointmentPage.razor"
                                                   convertImageToDisplay(objAppointment.Product.Image)

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(196, "width", "100%");
                    __builder3.AddAttribute(197, "style", "border-radius:5px; border:1px solid #bbb9b9;");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(198, "\r\n                                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(199, "\r\n                                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(200, "\r\n                            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(201, "\r\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(202, "\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(203, "\r\n\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(204, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(205, "\r\n");
#nullable restore
#line 144 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\AppointmentPage.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(206, "\r\n    ");
            }
            ));
            __builder.AddAttribute(207, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(208, "\r\n        ");
                __builder2.AddMarkupContent(209, "<p>You\'re not signed in.</p>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 152 "C:\Project\Kursrepo\Blazor\BlazingShop\BlazingShop\Pages\AppointmentPage.razor"
       

    List<Appointment> appointments;
    Appointment objAppointment = new Appointment();

    public byte[] ImageUploaded { get; set; }

    protected override void OnInitialized()
    {
        appointments = Service.GetAppointments();
    }

    bool ShowPopup = false;
    void ClosePopup()
    {
        ShowPopup = false;
    }

    void EditAppointment(Appointment appointment)
    {
        objAppointment = appointment;
        appointments = Service.GetAppointments();
        ShowPopup = true;
    }

    void DeleteAppointment()
    {
        ShowPopup = false;
        var result = Service.DeleteAppointment(objAppointment);
        appointments.Clear();
        appointments = Service.GetAppointments();
    }


    void ValidSubmit()
    {
        var result = false;
        ShowPopup = false;
        result = Service.ConfirmAppointment(objAppointment);
        appointments = Service.GetAppointments();
    }

    string convertImageToDisplay(byte[] image)
    {
        if (image != null)
        {
            var base64 = Convert.ToBase64String(image);
            var finalStr = string.Format("data:image/jpg;base64,{0}", base64);
            return finalStr;
        }

        else { return ""; }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
