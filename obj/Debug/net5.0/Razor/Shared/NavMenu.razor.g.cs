#pragma checksum "C:\Users\Administrator\Desktop\signalr-blazorserver\Shared\NavMenu.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "cd2d97b9829a581a16b8d43c97f2cfc30bdb4eee855ce68e1b60c74f7b3c47db"
// <auto-generated/>
#pragma warning disable 1591
namespace Chatty.Shared
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Administrator\Desktop\signalr-blazorserver\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\signalr-blazorserver\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\signalr-blazorserver\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\Desktop\signalr-blazorserver\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator\Desktop\signalr-blazorserver\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrator\Desktop\signalr-blazorserver\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrator\Desktop\signalr-blazorserver\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Administrator\Desktop\signalr-blazorserver\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administrator\Desktop\signalr-blazorserver\_Imports.razor"
using Chatty;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Administrator\Desktop\signalr-blazorserver\_Imports.razor"
using Chatty.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-1vmgr2qkbe");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-1vmgr2qkbe>DChat V1.0</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\signalr-blazorserver\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-1vmgr2qkbe");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-1vmgr2qkbe></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "C:\Users\Administrator\Desktop\signalr-blazorserver\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Administrator\Desktop\signalr-blazorserver\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-1vmgr2qkbe");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddAttribute(16, "b-1vmgr2qkbe");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddAttribute(19, "b-1vmgr2qkbe");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", (object)("nav-link"));
            __builder.AddAttribute(22, "href", (object)(""));
            __builder.AddAttribute(23, "Match", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 11 "C:\Users\Administrator\Desktop\signalr-blazorserver\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(24, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-1vmgr2qkbe></span> Chat\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "li");
            __builder.AddAttribute(28, "class", "nav-item px-3");
            __builder.AddAttribute(29, "b-1vmgr2qkbe");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(30);
            __builder.AddAttribute(31, "class", (object)("nav-link"));
            __builder.AddAttribute(32, "href", (object)("counter"));
            __builder.AddAttribute(33, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(34, "<span class=\"oi oi-plus\" aria-hidden=\"true\" b-1vmgr2qkbe></span> User\'s\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "li");
            __builder.AddAttribute(37, "class", "nav-item px-3");
            __builder.AddAttribute(38, "b-1vmgr2qkbe");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(39);
            __builder.AddAttribute(40, "class", (object)("nav-link"));
            __builder.AddAttribute(41, "href", (object)("fetchdata"));
            __builder.AddAttribute(42, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(43, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-1vmgr2qkbe></span> Date\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(45, @"<style b-1vmgr2qkbe>
    .top-row {
        background-color: #343a40;
        padding: 0.5rem 1rem;
        box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
    }

    .navbar-brand {
        font-size: 1.5rem;
        font-weight: bold;
        color: #fff;
        text-decoration: none;
    }

    .navbar-toggler {
        border: none;
        background-color: transparent;
        color: #fff;
        cursor: pointer;
    }

    .collapse {
        display: none;
    }

    .nav-menu {
        transition: height 0.3s ease;
    }

    .nav-link {
        color: #fff;
        font-size: 1.2rem;
        text-decoration: none;
        transition: color 0.3s ease;
    }

        .nav-link:hover {
            color: #17a2b8;
        }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\Administrator\Desktop\signalr-blazorserver\Shared\NavMenu.razor"
       
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
