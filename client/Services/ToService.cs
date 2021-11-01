
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Web;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Components;
using Radzen;
using TiomsOrders.Models.To;

namespace TiomsOrders
{
    public partial class ToService
    {
        private readonly HttpClient httpClient;
        private readonly Uri baseUri;
        private readonly NavigationManager navigationManager;
        public ToService(NavigationManager navigationManager, HttpClient httpClient, IConfiguration configuration)
        {
            this.httpClient = httpClient;

            this.navigationManager = navigationManager;
            this.baseUri = new Uri($"{navigationManager.BaseUri}odata/TO/");
        }

        public async System.Threading.Tasks.Task ExportCustomersToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/to/customers/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/to/customers/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportCustomersToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/to/customers/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/to/customers/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetCustomers(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<ODataServiceResult<Customer>> GetCustomers(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string))
        {
            var uri = new Uri(baseUri, $"Customers");
            uri = uri.GetODataUri(filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:null, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetCustomers(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<ODataServiceResult<Customer>>();
        }
        partial void OnCreateCustomer(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Customer> CreateCustomer(Customer customer = default(Customer))
        {
            var uri = new Uri(baseUri, $"Customers");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, uri);


            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(customer), Encoding.UTF8, "application/json");

            OnCreateCustomer(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<Customer>();
        }

        public async System.Threading.Tasks.Task ExportOrderTsToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/to/orderts/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/to/orderts/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportOrderTsToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/to/orderts/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/to/orderts/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetOrderTs(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<ODataServiceResult<OrderT>> GetOrderTs(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string))
        {
            var uri = new Uri(baseUri, $"OrderTs");
            uri = uri.GetODataUri(filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:null, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetOrderTs(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<ODataServiceResult<OrderT>>();
        }
        partial void OnCreateOrderT(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<OrderT> CreateOrderT(OrderT orderT = default(OrderT))
        {
            var uri = new Uri(baseUri, $"OrderTs");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, uri);


            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(orderT), Encoding.UTF8, "application/json");

            OnCreateOrderT(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<OrderT>();
        }

        public async System.Threading.Tasks.Task ExportProductsToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/to/products/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/to/products/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportProductsToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/to/products/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/to/products/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetProducts(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<ODataServiceResult<Product>> GetProducts(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string))
        {
            var uri = new Uri(baseUri, $"Products");
            uri = uri.GetODataUri(filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:null, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetProducts(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<ODataServiceResult<Product>>();
        }
        partial void OnCreateProduct(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Product> CreateProduct(Product product = default(Product))
        {
            var uri = new Uri(baseUri, $"Products");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, uri);


            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(product), Encoding.UTF8, "application/json");

            OnCreateProduct(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<Product>();
        }
        partial void OnDeleteCustomer(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> DeleteCustomer(int? customerId = default(int?))
        {
            var uri = new Uri(baseUri, $"Customers({customerId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, uri);

            OnDeleteCustomer(httpRequestMessage);
            return await httpClient.SendAsync(httpRequestMessage);
        }
        partial void OnGetCustomerByCustomerId(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Customer> GetCustomerByCustomerId(int? customerId = default(int?))
        {
            var uri = new Uri(baseUri, $"Customers({customerId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetCustomerByCustomerId(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<Customer>();
        }
        partial void OnUpdateCustomer(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> UpdateCustomer(int? customerId = default(int?), Customer customer = default(Customer))
        {
            var uri = new Uri(baseUri, $"Customers({customerId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Patch, uri);


            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(customer), Encoding.UTF8, "application/json");

            OnUpdateCustomer(httpRequestMessage);
            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<HttpResponseMessage>();
        }
        partial void OnDeleteOrderT(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> DeleteOrderT(int? orderId = default(int?))
        {
            var uri = new Uri(baseUri, $"OrderTs({orderId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, uri);

            OnDeleteOrderT(httpRequestMessage);
            return await httpClient.SendAsync(httpRequestMessage);
        }
        partial void OnGetOrderTByOrderId(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<OrderT> GetOrderTByOrderId(int? orderId = default(int?))
        {
            var uri = new Uri(baseUri, $"OrderTs({orderId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetOrderTByOrderId(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<OrderT>();
        }
        partial void OnUpdateOrderT(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> UpdateOrderT(int? orderId = default(int?), OrderT orderT = default(OrderT))
        {
            var uri = new Uri(baseUri, $"OrderTs({orderId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Patch, uri);


            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(orderT), Encoding.UTF8, "application/json");

            OnUpdateOrderT(httpRequestMessage);
            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<HttpResponseMessage>();
        }
        partial void OnDeleteProduct(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> DeleteProduct(int? productId = default(int?))
        {
            var uri = new Uri(baseUri, $"Products({productId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, uri);

            OnDeleteProduct(httpRequestMessage);
            return await httpClient.SendAsync(httpRequestMessage);
        }
        partial void OnGetProductByProductId(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Product> GetProductByProductId(int? productId = default(int?))
        {
            var uri = new Uri(baseUri, $"Products({productId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetProductByProductId(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<Product>();
        }
        partial void OnUpdateProduct(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> UpdateProduct(int? productId = default(int?), Product product = default(Product))
        {
            var uri = new Uri(baseUri, $"Products({productId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Patch, uri);


            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(product), Encoding.UTF8, "application/json");

            OnUpdateProduct(httpRequestMessage);
            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<HttpResponseMessage>();
        }
    }
}
