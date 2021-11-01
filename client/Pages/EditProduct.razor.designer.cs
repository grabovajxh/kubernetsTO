using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using TiomsOrders.Models.To;
using TiomsOrders.Client.Pages;

namespace TiomsOrders.Pages
{
    public partial class EditProductComponent : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }

        public void Reload()
        {
            InvokeAsync(StateHasChanged);
        }

        public void OnPropertyChanged(PropertyChangedEventArgs args)
        {
        }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected TooltipService TooltipService { get; set; }

        [Inject]
        protected ContextMenuService ContextMenuService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        [Inject]
        protected ToService To { get; set; }

        [Parameter]
        public dynamic ProductID { get; set; }

        TiomsOrders.Models.To.Product _product;
        protected TiomsOrders.Models.To.Product product
        {
            get
            {
                return _product;
            }
            set
            {
                if (!object.Equals(_product, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "product", NewValue = value, OldValue = _product };
                    _product = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Load();
        }
        protected async System.Threading.Tasks.Task Load()
        {
            var toGetProductByProductIdResult = await To.GetProductByProductId(productId:ProductID);
            product = toGetProductByProductIdResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(TiomsOrders.Models.To.Product args)
        {
            try
            {
                var toUpdateProductResult = await To.UpdateProduct(productId:ProductID, product:product);
                DialogService.Close(product);
            }
            catch (System.Exception toUpdateProductException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to update Product" });
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
