#pragma checksum "C:\Users\35568\Desktop\TO\client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbf91b19544bd0161c0e76923bfaaada705c8fa1"
// <auto-generated/>
#pragma warning disable 1591
namespace TiomsOrders.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\35568\Desktop\TO\client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\35568\Desktop\TO\client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\35568\Desktop\TO\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\35568\Desktop\TO\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\35568\Desktop\TO\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\35568\Desktop\TO\client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\35568\Desktop\TO\client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\35568\Desktop\TO\client\_Imports.razor"
using TiomsOrders.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\35568\Desktop\TO\client\_Imports.razor"
using TiomsOrders.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\35568\Desktop\TO\client\Shared\MainLayout.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\35568\Desktop\TO\client\Shared\MainLayout.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\35568\Desktop\TO\client\Shared\MainLayout.razor"
using TiomsOrders.Models.To;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : TiomsOrders.Layouts.MainLayoutComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenDialog>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenNotification>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenTooltip>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenContextMenu>(6);
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\n\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenHeader>(8);
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "row justify-content-start align-items-center");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "col-6 d-flex align-items-center");
                __builder2.OpenComponent<Radzen.Blazor.RadzenSidebarToggle>(14);
                __builder2.AddAttribute(15, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.EventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 15 "C:\Users\35568\Desktop\TO\client\Shared\MainLayout.razor"
                                     SidebarToggle0Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(17);
                __builder2.AddAttribute(18, "Text", "TiomsOrders");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\n      <div class=\"col-6 text-right\"></div>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenBody>(21);
            __builder.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenContentContainer>(23);
                __builder2.AddAttribute(24, "Name", "main");
                __builder2.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(26, 
#nullable restore
#line 28 "C:\Users\35568\Desktop\TO\client\Shared\MainLayout.razor"
     Body

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(27, (__value) => {
#nullable restore
#line 25 "C:\Users\35568\Desktop\TO\client\Shared\MainLayout.razor"
                  body0 = (Radzen.Blazor.RadzenBody)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(28, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenSidebar>(29);
            __builder.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenPanelMenu>(31);
                __builder2.AddAttribute(32, "style", "height: 100%");
                __builder2.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(34);
                    __builder3.AddAttribute(35, "Text", "Customer");
                    __builder3.AddAttribute(36, "Path", "customer");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(37, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(38);
                    __builder3.AddAttribute(39, "Text", "Product");
                    __builder3.AddAttribute(40, "Path", "product");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(42);
                    __builder3.AddAttribute(43, "Text", "OrderT");
                    __builder3.AddAttribute(44, "Path", "order-t");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(45, (__value) => {
#nullable restore
#line 32 "C:\Users\35568\Desktop\TO\client\Shared\MainLayout.razor"
                     sidebar0 = (Radzen.Blazor.RadzenSidebar)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(46, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenFooter>(47);
            __builder.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(49);
                __builder2.AddAttribute(50, "Text", "TiomsOrders, Copyright Ⓒ 2021");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
