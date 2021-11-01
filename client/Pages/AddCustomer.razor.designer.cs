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
    public partial class AddCustomerComponent : ComponentBase
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

        TiomsOrders.Models.To.Customer _customer;
        protected TiomsOrders.Models.To.Customer customer
        {
            get
            {
                return _customer;
            }
            set
            {
                if (!object.Equals(_customer, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "customer", NewValue = value, OldValue = _customer };
                    _customer = value;
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
            customer = new TiomsOrders.Models.To.Customer(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(TiomsOrders.Models.To.Customer args)
        {
            customer.FullName = customer.FirstName +" "+ customer.LastName ;

            try
            {
                var toCreateCustomerResult = await To.CreateCustomer(customer:customer);
                DialogService.Close(customer);
            }
            catch (System.Exception toCreateCustomerException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to create new Customer!" });
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
