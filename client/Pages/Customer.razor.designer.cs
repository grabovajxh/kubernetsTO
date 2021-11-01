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
    public partial class CustomerComponent : ComponentBase
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
        protected RadzenDataGrid<TiomsOrders.Models.To.Customer> grid0;

        IEnumerable<TiomsOrders.Models.To.Customer> _getCustomersResult;
        protected IEnumerable<TiomsOrders.Models.To.Customer> getCustomersResult
        {
            get
            {
                return _getCustomersResult;
            }
            set
            {
                if (!object.Equals(_getCustomersResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getCustomersResult", NewValue = value, OldValue = _getCustomersResult };
                    _getCustomersResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        int _getCustomersCount;
        protected int getCustomersCount
        {
            get
            {
                return _getCustomersCount;
            }
            set
            {
                if (!object.Equals(_getCustomersCount, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getCustomersCount", NewValue = value, OldValue = _getCustomersCount };
                    _getCustomersCount = value;
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

        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddCustomer>("Add Customer", null);
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0LoadData(LoadDataArgs args)
        {
            try
            {
                var toGetCustomersResult = await To.GetCustomers(filter:$"{args.Filter}", orderby:$"{args.OrderBy}", top:args.Top, skip:args.Skip, count:args.Top != null && args.Skip != null);
                getCustomersResult = toGetCustomersResult.Value.AsODataEnumerable();

                getCustomersCount = toGetCustomersResult.Count;
            }
            catch (System.Exception toGetCustomersException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to load Customers" });
            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(TiomsOrders.Models.To.Customer args)
        {
            var dialogResult = await DialogService.OpenAsync<EditCustomer>("Edit Customer", new Dictionary<string, object>() { {"CustomerID", args.CustomerID} });
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var toDeleteCustomerResult = await To.DeleteCustomer(customerId:data.CustomerID);
                    if (toDeleteCustomerResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception toDeleteCustomerException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to delete Customer" });
            }
        }
    }
}
