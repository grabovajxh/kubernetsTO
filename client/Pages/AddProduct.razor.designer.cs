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
    public partial class AddProductComponent : ComponentBase
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
            product = new TiomsOrders.Models.To.Product(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(TiomsOrders.Models.To.Product args)
        {
            try
            {
                var toCreateProductResult = await To.CreateProduct(product:product);
                DialogService.Close(product);
            }
            catch (System.Exception toCreateProductException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to create new Product!" });
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
