#pragma checksum "C:\Users\35568\Desktop\TO\client\Pages\AddProduct.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a4647c70d0e749f02ebeacd84138d1af7d80247"
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
#line 5 "C:\Users\35568\Desktop\TO\client\Pages\AddProduct.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\35568\Desktop\TO\client\Pages\AddProduct.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\35568\Desktop\TO\client\Pages\AddProduct.razor"
using TiomsOrders.Models.To;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-product")]
    public partial class AddProduct : TiomsOrders.Pages.AddProductComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "row");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<TiomsOrders.Models.To.Product>>(7);
                __builder2.AddAttribute(8, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<TiomsOrders.Models.To.Product>(
#nullable restore
#line 12 "C:\Users\35568\Desktop\TO\client\Pages\AddProduct.razor"
                                   product

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Users\35568\Desktop\TO\client\Pages\AddProduct.razor"
                                                       product != null

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<TiomsOrders.Models.To.Product>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<TiomsOrders.Models.To.Product>(this, 
#nullable restore
#line 12 "C:\Users\35568\Desktop\TO\client\Pages\AddProduct.razor"
                                                                                                                        Form0Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenElement(12, "div");
                    __builder3.AddAttribute(13, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(14, "class", "row");
                    __builder3.OpenElement(15, "div");
                    __builder3.AddAttribute(16, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(17);
                    __builder3.AddAttribute(18, "Text", "Product Name");
                    __builder3.AddAttribute(19, "Component", "ProductName");
                    __builder3.AddAttribute(20, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(21, "\n              ");
                    __builder3.OpenElement(22, "div");
                    __builder3.AddAttribute(23, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(24);
                    __builder3.AddAttribute(25, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#nullable restore
#line 20 "C:\Users\35568\Desktop\TO\client\Pages\AddProduct.razor"
                                          255

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(26, "style", "width: 100%");
                    __builder3.AddAttribute(27, "Name", "ProductName");
                    __builder3.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\35568\Desktop\TO\client\Pages\AddProduct.razor"
                                                                                  product.ProductName

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.ProductName = __value, product.ProductName))));
                    __builder3.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => product.ProductName));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(31, "\n            ");
                    __builder3.OpenElement(32, "div");
                    __builder3.AddAttribute(33, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(34, "class", "row");
                    __builder3.OpenElement(35, "div");
                    __builder3.AddAttribute(36, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(37);
                    __builder3.AddAttribute(38, "Text", "Price");
                    __builder3.AddAttribute(39, "Component", "Price");
                    __builder3.AddAttribute(40, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(41, "\n              ");
                    __builder3.OpenElement(42, "div");
                    __builder3.AddAttribute(43, "class", "col-md-9");
                    __Blazor.TiomsOrders.Client.Pages.AddProduct.TypeInference.CreateRadzenNumeric_0(__builder3, 44, 45, "width: 100%", 46, "Price", 47, 
#nullable restore
#line 30 "C:\Users\35568\Desktop\TO\client\Pages\AddProduct.razor"
                                                                  product.Price

#line default
#line hidden
#nullable disable
                    , 48, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.Price = __value, product.Price)), 49, () => product.Price);
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(50, "\n            ");
                    __builder3.OpenElement(51, "div");
                    __builder3.AddAttribute(52, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(53, "class", "row");
                    __builder3.OpenElement(54, "div");
                    __builder3.AddAttribute(55, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(56);
                    __builder3.AddAttribute(57, "Text", "Description");
                    __builder3.AddAttribute(58, "Component", "Description");
                    __builder3.AddAttribute(59, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(60, "\n              ");
                    __builder3.OpenElement(61, "div");
                    __builder3.AddAttribute(62, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(63);
                    __builder3.AddAttribute(64, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#nullable restore
#line 40 "C:\Users\35568\Desktop\TO\client\Pages\AddProduct.razor"
                                          255

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(65, "style", "width: 100%");
                    __builder3.AddAttribute(66, "Name", "Description");
                    __builder3.AddAttribute(67, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "C:\Users\35568\Desktop\TO\client\Pages\AddProduct.razor"
                                                                                  product.Description

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(68, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.Description = __value, product.Description))));
                    __builder3.AddAttribute(69, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => product.Description));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(70, "\n            ");
                    __builder3.OpenElement(71, "div");
                    __builder3.AddAttribute(72, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(73, "class", "row");
                    __builder3.OpenElement(74, "div");
                    __builder3.AddAttribute(75, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(76);
                    __builder3.AddAttribute(77, "Text", "Stock");
                    __builder3.AddAttribute(78, "Component", "Stock");
                    __builder3.AddAttribute(79, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(80, "\n              ");
                    __builder3.OpenElement(81, "div");
                    __builder3.AddAttribute(82, "class", "col-md-9");
                    __Blazor.TiomsOrders.Client.Pages.AddProduct.TypeInference.CreateRadzenNumeric_1(__builder3, 83, 84, "width: 100%", 85, "Stock", 86, 
#nullable restore
#line 50 "C:\Users\35568\Desktop\TO\client\Pages\AddProduct.razor"
                                                                  product.Stock

#line default
#line hidden
#nullable disable
                    , 87, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.Stock = __value, product.Stock)), 88, () => product.Stock);
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(89, "\n            ");
                    __builder3.OpenElement(90, "div");
                    __builder3.AddAttribute(91, "class", "row");
                    __builder3.OpenElement(92, "div");
                    __builder3.AddAttribute(93, "class", "col offset-sm-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(94);
                    __builder3.AddAttribute(95, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 56 "C:\Users\35568\Desktop\TO\client\Pages\AddProduct.razor"
                                          ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(96, "Icon", "save");
                    __builder3.AddAttribute(97, "Text", "Save");
                    __builder3.AddAttribute(98, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 56 "C:\Users\35568\Desktop\TO\client\Pages\AddProduct.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(99, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(100);
                    __builder3.AddAttribute(101, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 58 "C:\Users\35568\Desktop\TO\client\Pages\AddProduct.razor"
                                           ButtonStyle.Light

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(102, "style", "margin-left: 1rem");
                    __builder3.AddAttribute(103, "Text", "Cancel");
                    __builder3.AddAttribute(104, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\Users\35568\Desktop\TO\client\Pages\AddProduct.razor"
                                                                                                              Button2Click

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
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
namespace __Blazor.TiomsOrders.Client.Pages.AddProduct
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenNumeric_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateRadzenNumeric_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
