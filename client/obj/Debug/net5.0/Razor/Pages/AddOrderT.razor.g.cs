#pragma checksum "C:\Users\35568\Desktop\TO\client\Pages\AddOrderT.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0bd7dfd1f9ec708ce5ada9d64201a286a026998"
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
#line 5 "C:\Users\35568\Desktop\TO\client\Pages\AddOrderT.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\35568\Desktop\TO\client\Pages\AddOrderT.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\35568\Desktop\TO\client\Pages\AddOrderT.razor"
using TiomsOrders.Models.To;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-order-t")]
    public partial class AddOrderT : TiomsOrders.Pages.AddOrderTComponent
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
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<TiomsOrders.Models.To.OrderT>>(7);
                __builder2.AddAttribute(8, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<TiomsOrders.Models.To.OrderT>(
#nullable restore
#line 12 "C:\Users\35568\Desktop\TO\client\Pages\AddOrderT.razor"
                                   ordert

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Users\35568\Desktop\TO\client\Pages\AddOrderT.razor"
                                                                                           ordert != null

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<TiomsOrders.Models.To.OrderT>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<TiomsOrders.Models.To.OrderT>(this, 
#nullable restore
#line 12 "C:\Users\35568\Desktop\TO\client\Pages\AddOrderT.razor"
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
                    __builder3.AddAttribute(18, "Component", "Quantity");
                    __builder3.AddAttribute(19, "style", "width: 100%");
                    __builder3.AddAttribute(20, "Text", "Quantity");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(21, "\n              ");
                    __builder3.OpenElement(22, "div");
                    __builder3.AddAttribute(23, "class", "col-md-9");
                    __Blazor.TiomsOrders.Client.Pages.AddOrderT.TypeInference.CreateRadzenNumeric_0(__builder3, 24, 25, "width: 100%", 26, "Quantity", 27, 
#nullable restore
#line 20 "C:\Users\35568\Desktop\TO\client\Pages\AddOrderT.razor"
                                                                  ordert.Quantity

#line default
#line hidden
#nullable disable
                    , 28, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ordert.Quantity = __value, ordert.Quantity)), 29, () => ordert.Quantity);
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(30, "\n            ");
                    __builder3.OpenElement(31, "div");
                    __builder3.AddAttribute(32, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(33, "class", "row");
                    __builder3.OpenElement(34, "div");
                    __builder3.AddAttribute(35, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(36);
                    __builder3.AddAttribute(37, "Component", "CustomerID");
                    __builder3.AddAttribute(38, "style", "width: 100%");
                    __builder3.AddAttribute(39, "Text", "Customer");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(40, "\n              ");
                    __builder3.OpenElement(41, "div");
                    __builder3.AddAttribute(42, "class", "col-md-9");
                    __Blazor.TiomsOrders.Client.Pages.AddOrderT.TypeInference.CreateRadzenDropDownDataGrid_1(__builder3, 43, 44, 
#nullable restore
#line 30 "C:\Users\35568\Desktop\TO\client\Pages\AddOrderT.razor"
                                                getCustomersForCustomerIDCount

#line default
#line hidden
#nullable disable
                    , 45, 
#nullable restore
#line 30 "C:\Users\35568\Desktop\TO\client\Pages\AddOrderT.razor"
                                                                                       getCustomersForCustomerIDResult

#line default
#line hidden
#nullable disable
                    , 46, 
#nullable restore
#line 30 "C:\Users\35568\Desktop\TO\client\Pages\AddOrderT.razor"
                                                                                                                                    false

#line default
#line hidden
#nullable disable
                    , 47, "width: 100%", 48, "FullName", 49, "CustomerID", 50, "CustomerID", 51, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.LoadDataArgs>(this, 
#nullable restore
#line 30 "C:\Users\35568\Desktop\TO\client\Pages\AddOrderT.razor"
                                                                                                                                                                                                                                                                                  CustomerIdLoadData

#line default
#line hidden
#nullable disable
                    ), 52, 
#nullable restore
#line 30 "C:\Users\35568\Desktop\TO\client\Pages\AddOrderT.razor"
                                                                                                                                                                                                      ordert.CustomerID

#line default
#line hidden
#nullable disable
                    , 53, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ordert.CustomerID = __value, ordert.CustomerID)), 54, () => ordert.CustomerID);
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(55, "\n            ");
                    __builder3.OpenElement(56, "div");
                    __builder3.AddAttribute(57, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(58, "class", "row");
                    __builder3.OpenElement(59, "div");
                    __builder3.AddAttribute(60, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(61);
                    __builder3.AddAttribute(62, "Component", "ProductID");
                    __builder3.AddAttribute(63, "style", "width: 100%");
                    __builder3.AddAttribute(64, "Text", "Product");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(65, "\n              ");
                    __builder3.OpenElement(66, "div");
                    __builder3.AddAttribute(67, "class", "col-md-9");
                    __Blazor.TiomsOrders.Client.Pages.AddOrderT.TypeInference.CreateRadzenDropDownDataGrid_2(__builder3, 68, 69, 
#nullable restore
#line 40 "C:\Users\35568\Desktop\TO\client\Pages\AddOrderT.razor"
                                                getProductsForProductIDCount

#line default
#line hidden
#nullable disable
                    , 70, 
#nullable restore
#line 40 "C:\Users\35568\Desktop\TO\client\Pages\AddOrderT.razor"
                                                                                     getProductsForProductIDResult

#line default
#line hidden
#nullable disable
                    , 71, "Choose Product", 72, 
#nullable restore
#line 40 "C:\Users\35568\Desktop\TO\client\Pages\AddOrderT.razor"
                                                                                                                                                             false

#line default
#line hidden
#nullable disable
                    , 73, "width: 100%", 74, "ProductName", 75, "ProductID", 76, "ProductID", 77, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.LoadDataArgs>(this, 
#nullable restore
#line 40 "C:\Users\35568\Desktop\TO\client\Pages\AddOrderT.razor"
                                                                                                                                                                                                                                                                                                           ProductIdLoadData

#line default
#line hidden
#nullable disable
                    ), 78, 
#nullable restore
#line 40 "C:\Users\35568\Desktop\TO\client\Pages\AddOrderT.razor"
                                                                                                                                                                                                                                  ordert.ProductID

#line default
#line hidden
#nullable disable
                    , 79, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ordert.ProductID = __value, ordert.ProductID)), 80, () => ordert.ProductID);
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(81, "\n            ");
                    __builder3.OpenElement(82, "div");
                    __builder3.AddAttribute(83, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(84, "class", "row");
                    __builder3.OpenElement(85, "div");
                    __builder3.AddAttribute(86, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(87);
                    __builder3.AddAttribute(88, "Component", "Description");
                    __builder3.AddAttribute(89, "style", "width: 100%");
                    __builder3.AddAttribute(90, "Text", "Description");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(91, "\n              ");
                    __builder3.OpenElement(92, "div");
                    __builder3.AddAttribute(93, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(94);
                    __builder3.AddAttribute(95, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#nullable restore
#line 50 "C:\Users\35568\Desktop\TO\client\Pages\AddOrderT.razor"
                                          255

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(96, "style", "width: 100%");
                    __builder3.AddAttribute(97, "Name", "Description");
                    __builder3.AddAttribute(98, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 50 "C:\Users\35568\Desktop\TO\client\Pages\AddOrderT.razor"
                                                                                  ordert.Description

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(99, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ordert.Description = __value, ordert.Description))));
                    __builder3.AddAttribute(100, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ordert.Description));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(101, "\n            ");
                    __builder3.OpenElement(102, "div");
                    __builder3.AddAttribute(103, "class", "row");
                    __builder3.OpenElement(104, "div");
                    __builder3.AddAttribute(105, "class", "col offset-sm-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(106);
                    __builder3.AddAttribute(107, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 56 "C:\Users\35568\Desktop\TO\client\Pages\AddOrderT.razor"
                                           ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(108, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 56 "C:\Users\35568\Desktop\TO\client\Pages\AddOrderT.razor"
                                                                            ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(109, "Icon", "save");
                    __builder3.AddAttribute(110, "Text", "Save");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(111, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(112);
                    __builder3.AddAttribute(113, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 58 "C:\Users\35568\Desktop\TO\client\Pages\AddOrderT.razor"
                                           ButtonStyle.Light

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(114, "style", "margin-left: 1rem");
                    __builder3.AddAttribute(115, "Text", "Cancel");
                    __builder3.AddAttribute(116, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\Users\35568\Desktop\TO\client\Pages\AddOrderT.razor"
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
namespace __Blazor.TiomsOrders.Client.Pages.AddOrderT
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
        public static void CreateRadzenDropDownDataGrid_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Int32 __arg0, int __seq1, global::System.Collections.IEnumerable __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, System.Object __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.String __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<global::Radzen.LoadDataArgs> __arg7, int __seq8, global::System.Object __arg8, int __seq9, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg9, int __seq10, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg10)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDownDataGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Count", __arg0);
        __builder.AddAttribute(__seq1, "Data", __arg1);
        __builder.AddAttribute(__seq2, "ShowSearch", __arg2);
        __builder.AddAttribute(__seq3, "style", __arg3);
        __builder.AddAttribute(__seq4, "TextProperty", __arg4);
        __builder.AddAttribute(__seq5, "ValueProperty", __arg5);
        __builder.AddAttribute(__seq6, "Name", __arg6);
        __builder.AddAttribute(__seq7, "LoadData", __arg7);
        __builder.AddAttribute(__seq8, "Value", __arg8);
        __builder.AddAttribute(__seq9, "ValueChanged", __arg9);
        __builder.AddAttribute(__seq10, "ValueExpression", __arg10);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDropDownDataGrid_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Int32 __arg0, int __seq1, global::System.Collections.IEnumerable __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, System.Object __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.String __arg6, int __seq7, global::System.String __arg7, int __seq8, global::Microsoft.AspNetCore.Components.EventCallback<global::Radzen.LoadDataArgs> __arg8, int __seq9, global::System.Object __arg9, int __seq10, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg10, int __seq11, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg11)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDownDataGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Count", __arg0);
        __builder.AddAttribute(__seq1, "Data", __arg1);
        __builder.AddAttribute(__seq2, "Placeholder", __arg2);
        __builder.AddAttribute(__seq3, "ShowSearch", __arg3);
        __builder.AddAttribute(__seq4, "style", __arg4);
        __builder.AddAttribute(__seq5, "TextProperty", __arg5);
        __builder.AddAttribute(__seq6, "ValueProperty", __arg6);
        __builder.AddAttribute(__seq7, "Name", __arg7);
        __builder.AddAttribute(__seq8, "LoadData", __arg8);
        __builder.AddAttribute(__seq9, "Value", __arg9);
        __builder.AddAttribute(__seq10, "ValueChanged", __arg10);
        __builder.AddAttribute(__seq11, "ValueExpression", __arg11);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
