using System;
using System.Net;
using System.Data;
using System.Linq;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNet.OData.Query;



namespace TiomsOrders.Controllers.To
{
  using Models;
  using Data;
  using Models.To;

  [ODataRoutePrefix("odata/TO/Customers")]
  [Route("mvc/odata/TO/Customers")]
  public partial class CustomersController : ODataController
  {
    private Data.ToContext context;

    public CustomersController(Data.ToContext context)
    {
      this.context = context;
    }
    // GET /odata/To/Customers
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.To.Customer> GetCustomers()
    {
      var items = this.context.Customers.AsQueryable<Models.To.Customer>();
      this.OnCustomersRead(ref items);

      return items;
    }

    partial void OnCustomersRead(ref IQueryable<Models.To.Customer> items);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{CustomerID}")]
    public SingleResult<Customer> GetCustomer(int key)
    {
        var items = this.context.Customers.Where(i=>i.CustomerID == key);
        return SingleResult.Create(items);
    }
    partial void OnCustomerDeleted(Models.To.Customer item);
    partial void OnAfterCustomerDeleted(Models.To.Customer item);

    [HttpDelete("{CustomerID}")]
    public IActionResult DeleteCustomer(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Customers
                .Where(i => i.CustomerID == key)
                .Include(i => i.OrderTs)
                .FirstOrDefault();

            if (item == null)
            {
                return BadRequest();
            }

            this.OnCustomerDeleted(item);
            this.context.Customers.Remove(item);
            this.context.SaveChanges();
            this.OnAfterCustomerDeleted(item);

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnCustomerUpdated(Models.To.Customer item);
    partial void OnAfterCustomerUpdated(Models.To.Customer item);

    [HttpPut("{CustomerID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutCustomer(int key, [FromBody]Models.To.Customer newItem)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (newItem == null || (newItem.CustomerID != key))
            {
                return BadRequest();
            }

            this.OnCustomerUpdated(newItem);
            this.context.Customers.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Customers.Where(i => i.CustomerID == key);
            this.OnAfterCustomerUpdated(newItem);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    [HttpPatch("{CustomerID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PatchCustomer(int key, [FromBody]Delta<Models.To.Customer> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Customers.Where(i => i.CustomerID == key).FirstOrDefault();

            if (item == null)
            {
                return BadRequest();
            }

            patch.Patch(item);

            this.OnCustomerUpdated(item);
            this.context.Customers.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Customers.Where(i => i.CustomerID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnCustomerCreated(Models.To.Customer item);
    partial void OnAfterCustomerCreated(Models.To.Customer item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.To.Customer item)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (item == null)
            {
                return BadRequest();
            }

            this.OnCustomerCreated(item);
            this.context.Customers.Add(item);
            this.context.SaveChanges();

            return Created($"odata/To/Customers/{item.CustomerID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
