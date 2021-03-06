#pragma checksum "C:\Users\35568\Desktop\TO\client\Pages\Product.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3ab562e7178c384c9485b8f919f7777f047cc33"
// <auto-generated/>
#pragma warning disable 1591
namespace TiomsOrders.Client.Pages
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
#line 5 "C:\Users\35568\Desktop\TO\client\Pages\Product.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\35568\Desktop\TO\client\Pages\Product.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\35568\Desktop\TO\client\Pages\Product.razor"
using TiomsOrders.Models.To;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/product")]
    public partial class Product : TiomsOrders.Pages.ProductComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(3);
                __builder2.AddAttribute(4, "Size", "H1");
                __builder2.AddAttribute(5, "Text", "Product");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(11);
                __builder2.AddAttribute(12, "Icon", "add_circle_outline");
                __builder2.AddAttribute(13, "style", "margin-bottom: 10px");
                __builder2.AddAttribute(14, "Text", "Add");
                __builder2.AddAttribute(15, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\35568\Desktop\TO\client\Pages\Product.razor"
                                                                                               Button0Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<TiomsOrders.Models.To.Product>>(17);
                __builder2.AddAttribute(18, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\35568\Desktop\TO\client\Pages\Product.razor"
                                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 16 "C:\Users\35568\Desktop\TO\client\Pages\Product.razor"
                                                                       FilterMode.Advanced

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\35568\Desktop\TO\client\Pages\Product.razor"
                                                                                                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\35568\Desktop\TO\client\Pages\Product.razor"
                                                                                                                             true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<TiomsOrders.Models.To.Product>>(
#nullable restore
#line 16 "C:\Users\35568\Desktop\TO\client\Pages\Product.razor"
                                                                                                                                          getProductsResult

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "Count", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 16 "C:\Users\35568\Desktop\TO\client\Pages\Product.razor"
                                                                                                                                                                     getProductsCount

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "LoadData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.LoadDataArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.LoadDataArgs>(this, 
#nullable restore
#line 16 "C:\Users\35568\Desktop\TO\client\Pages\Product.razor"
                                                                                                                                                                                                                                        Grid0LoadData

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(25, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<TiomsOrders.Models.To.Product>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<TiomsOrders.Models.To.Product>(this, 
#nullable restore
#line 16 "C:\Users\35568\Desktop\TO\client\Pages\Product.razor"
                                                                                                                                                                                                                                                                   Grid0RowSelect

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(26, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<TiomsOrders.Models.To.Product>>(27);
                    __builder3.AddAttribute(28, "Property", "ProductName");
                    __builder3.AddAttribute(29, "Title", "Product Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(30, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<TiomsOrders.Models.To.Product>>(31);
                    __builder3.AddAttribute(32, "Property", "Price");
                    __builder3.AddAttribute(33, "Title", "Price");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(34, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<TiomsOrders.Models.To.Product>>(35);
                    __builder3.AddAttribute(36, "Property", "Description");
                    __builder3.AddAttribute(37, "Title", "Description");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(38, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<TiomsOrders.Models.To.Product>>(39);
                    __builder3.AddAttribute(40, "Property", "Stock");
                    __builder3.AddAttribute(41, "Title", "Stock");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(42, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<TiomsOrders.Models.To.Product>>(43);
                    __builder3.AddAttribute(44, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\Users\35568\Desktop\TO\client\Pages\Product.razor"
                                                                                    false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(45, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\Users\35568\Desktop\TO\client\Pages\Product.razor"
                                                                                                     false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(46, "Width", "70px");
                    __builder3.AddAttribute(47, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 26 "C:\Users\35568\Desktop\TO\client\Pages\Product.razor"
                                                                                                                                    TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(48, "Template", (Microsoft.AspNetCore.Components.RenderFragment<TiomsOrders.Models.To.Product>)((tiomsOrdersModelsToProduct) => (__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(49);
                        __builder4.AddAttribute(50, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 28 "C:\Users\35568\Desktop\TO\client\Pages\Product.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(51, "Icon", "close");
                        __builder4.AddAttribute(52, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#nullable restore
#line 28 "C:\Users\35568\Desktop\TO\client\Pages\Product.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(53, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\35568\Desktop\TO\client\Pages\Product.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, tiomsOrdersModelsToProduct)

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddEventStopPropagationAttribute(54, "onclick", 
#nullable restore
#line 28 "C:\Users\35568\Desktop\TO\client\Pages\Product.razor"
                                                                                                                                                                                                          true

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddComponentReferenceCapture(55, (__value) => {
#nullable restore
#line 16 "C:\Users\35568\Desktop\TO\client\Pages\Product.razor"
                              grid0 = (Radzen.Blazor.RadzenDataGrid<TiomsOrders.Models.To.Product>)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
