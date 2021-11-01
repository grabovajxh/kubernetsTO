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
    public partial class AddOrderTComponent : ComponentBase
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

        TiomsOrders.Models.To.OrderT _ordert;
        protected TiomsOrders.Models.To.OrderT ordert
        {
            get
            {
                return _ordert;
            }
            set
            {
                if (!object.Equals(_ordert, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "ordert", NewValue = value, OldValue = _ordert };
                    _ordert = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<TiomsOrders.Models.To.Customer> _getCustomersForCustomerIDResult;
        protected IEnumerable<TiomsOrders.Models.To.Customer> getCustomersForCustomerIDResult
        {
            get
            {
                return _getCustomersForCustomerIDResult;
            }
            set
            {
                if (!object.Equals(_getCustomersForCustomerIDResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getCustomersForCustomerIDResult", NewValue = value, OldValue = _getCustomersForCustomerIDResult };
                    _getCustomersForCustomerIDResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        int _getCustomersForCustomerIDCount;
        protected int getCustomersForCustomerIDCount
        {
            get
            {
                return _getCustomersForCustomerIDCount;
            }
            set
            {
                if (!object.Equals(_getCustomersForCustomerIDCount, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getCustomersForCustomerIDCount", NewValue = value, OldValue = _getCustomersForCustomerIDCount };
                    _getCustomersForCustomerIDCount = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<TiomsOrders.Models.To.Product> _getProductsForProductIDResult;
        protected IEnumerable<TiomsOrders.Models.To.Product> getProductsForProductIDResult
        {
            get
            {
                return _getProductsForProductIDResult;
            }
            set
            {
                if (!object.Equals(_getProductsForProductIDResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getProductsForProductIDResult", NewValue = value, OldValue = _getProductsForProductIDResult };
                    _getProductsForProductIDResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        int _getProductsForProductIDCount;
        protected int getProductsForProductIDCount
        {
            get
            {
                return _getProductsForProductIDCount;
            }
            set
            {
                if (!object.Equals(_getProductsForProductIDCount, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getProductsForProductIDCount", NewValue = value, OldValue = _getProductsForProductIDCount };
                    _getProductsForProductIDCount = value;
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
            ordert = new TiomsOrders.Models.To.OrderT(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(TiomsOrders.Models.To.OrderT args)
        {
            try
            {
                var toCreateOrderTResult = await To.CreateOrderT(orderT:ordert);
                DialogService.Close(ordert);
            }
            catch (System.Exception toCreateOrderTException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to create new OrderT!" });
            }
        }

        protected async System.Threading.Tasks.Task CustomerIdLoadData(LoadDataArgs args)
        {
            var toGetCustomersResult = await To.GetCustomers(filter:$"{args.Filter}", orderby:$"{args.OrderBy}", top:args.Top, skip:args.Skip, count:true);
            getCustomersForCustomerIDResult = toGetCustomersResult.Value.AsODataEnumerable();

            getCustomersForCustomerIDCount = toGetCustomersResult.Count;
        }

        protected async System.Threading.Tasks.Task ProductIdLoadData(LoadDataArgs args)
        {
            var toGetProductsResult = await To.GetProducts(filter:$"{args.Filter}", orderby:$"{args.OrderBy}", top:args.Top, skip:args.Skip, count:true);
            getProductsForProductIDResult = toGetProductsResult.Value.AsODataEnumerable();

            getProductsForProductIDCount = toGetProductsResult.Count;
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
