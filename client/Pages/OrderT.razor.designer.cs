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
    public partial class OrderTComponent : ComponentBase
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
        protected RadzenDataGrid<TiomsOrders.Models.To.OrderT> grid0;

        IEnumerable<TiomsOrders.Models.To.OrderT> _getOrderTsResult;
        protected IEnumerable<TiomsOrders.Models.To.OrderT> getOrderTsResult
        {
            get
            {
                return _getOrderTsResult;
            }
            set
            {
                if (!object.Equals(_getOrderTsResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getOrderTsResult", NewValue = value, OldValue = _getOrderTsResult };
                    _getOrderTsResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        int _getOrderTsCount;
        protected int getOrderTsCount
        {
            get
            {
                return _getOrderTsCount;
            }
            set
            {
                if (!object.Equals(_getOrderTsCount, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getOrderTsCount", NewValue = value, OldValue = _getOrderTsCount };
                    _getOrderTsCount = value;
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
            var dialogResult = await DialogService.OpenAsync<AddOrderT>("Add Order T", null);
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0LoadData(LoadDataArgs args)
        {
            try
            {
                var toGetOrderTsResult = await To.GetOrderTs(filter:$"{args.Filter}", orderby:$"{args.OrderBy}", expand:$"Customer,Product", top:args.Top, skip:args.Skip, count:args.Top != null && args.Skip != null);
                getOrderTsResult = toGetOrderTsResult.Value.AsODataEnumerable();

                getOrderTsCount = toGetOrderTsResult.Count;
            }
            catch (System.Exception toGetOrderTsException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to load OrderTs" });
            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(TiomsOrders.Models.To.OrderT args)
        {
            var dialogResult = await DialogService.OpenAsync<EditOrderT>("Edit Order T", new Dictionary<string, object>() { {"OrderID", args.OrderID} });
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var toDeleteOrderTResult = await To.DeleteOrderT(orderId:data.OrderID);
                    if (toDeleteOrderTResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception toDeleteOrderTException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to delete OrderT" });
            }
        }
    }
}
