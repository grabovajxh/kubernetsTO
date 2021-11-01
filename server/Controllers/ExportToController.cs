using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TiomsOrders.Data;

namespace TiomsOrders
{
    public partial class ExportToController : ExportController
    {
        private readonly ToContext context;

        public ExportToController(ToContext context)
        {
            this.context = context;
        }
        [HttpGet("/export/To/customers/csv")]
        [HttpGet("/export/To/customers/csv(fileName='{fileName}')")]
        public FileStreamResult ExportCustomersToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.Customers, Request.Query), fileName);
        }

        [HttpGet("/export/To/customers/excel")]
        [HttpGet("/export/To/customers/excel(fileName='{fileName}')")]
        public FileStreamResult ExportCustomersToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.Customers, Request.Query), fileName);
        }
        [HttpGet("/export/To/orderts/csv")]
        [HttpGet("/export/To/orderts/csv(fileName='{fileName}')")]
        public FileStreamResult ExportOrderTsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.OrderTs, Request.Query), fileName);
        }

        [HttpGet("/export/To/orderts/excel")]
        [HttpGet("/export/To/orderts/excel(fileName='{fileName}')")]
        public FileStreamResult ExportOrderTsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.OrderTs, Request.Query), fileName);
        }
        [HttpGet("/export/To/products/csv")]
        [HttpGet("/export/To/products/csv(fileName='{fileName}')")]
        public FileStreamResult ExportProductsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.Products, Request.Query), fileName);
        }

        [HttpGet("/export/To/products/excel")]
        [HttpGet("/export/To/products/excel(fileName='{fileName}')")]
        public FileStreamResult ExportProductsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.Products, Request.Query), fileName);
        }
    }
}
