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

  [ODataRoutePrefix("odata/TO/OrderTs")]
  [Route("mvc/odata/TO/OrderTs")]
  public partial class OrderTsController : ODataController
  {
    private Data.ToContext context;

    public OrderTsController(Data.ToContext context)
    {
      this.context = context;
    }
    // GET /odata/To/OrderTs
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.To.OrderT> GetOrderTs()
    {
      var items = this.context.OrderTs.AsQueryable<Models.To.OrderT>();
      this.OnOrderTsRead(ref items);

      return items;
    }

    partial void OnOrderTsRead(ref IQueryable<Models.To.OrderT> items);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{OrderID}")]
    public SingleResult<OrderT> GetOrderT(int key)
    {
        var items = this.context.OrderTs.Where(i=>i.OrderID == key);
        return SingleResult.Create(items);
    }
    partial void OnOrderTDeleted(Models.To.OrderT item);
    partial void OnAfterOrderTDeleted(Models.To.OrderT item);

    [HttpDelete("{OrderID}")]
    public IActionResult DeleteOrderT(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.OrderTs
                .Where(i => i.OrderID == key)
                .FirstOrDefault();

            if (item == null)
            {
                return BadRequest();
            }

            this.OnOrderTDeleted(item);
            this.context.OrderTs.Remove(item);
            this.context.SaveChanges();
            this.OnAfterOrderTDeleted(item);

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnOrderTUpdated(Models.To.OrderT item);
    partial void OnAfterOrderTUpdated(Models.To.OrderT item);

    [HttpPut("{OrderID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutOrderT(int key, [FromBody]Models.To.OrderT newItem)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (newItem == null || (newItem.OrderID != key))
            {
                return BadRequest();
            }

            this.OnOrderTUpdated(newItem);
            this.context.OrderTs.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.OrderTs.Where(i => i.OrderID == key);
            Request.QueryString = Request.QueryString.Add("$expand", "Customer,Product");
            this.OnAfterOrderTUpdated(newItem);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    [HttpPatch("{OrderID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PatchOrderT(int key, [FromBody]Delta<Models.To.OrderT> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.OrderTs.Where(i => i.OrderID == key).FirstOrDefault();

            if (item == null)
            {
                return BadRequest();
            }

            patch.Patch(item);

            this.OnOrderTUpdated(item);
            this.context.OrderTs.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.OrderTs.Where(i => i.OrderID == key);
            Request.QueryString = Request.QueryString.Add("$expand", "Customer,Product");
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnOrderTCreated(Models.To.OrderT item);
    partial void OnAfterOrderTCreated(Models.To.OrderT item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.To.OrderT item)
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

            this.OnOrderTCreated(item);
            this.context.OrderTs.Add(item);
            this.context.SaveChanges();

            var key = item.OrderID;

            var itemToReturn = this.context.OrderTs.Where(i => i.OrderID == key);

            Request.QueryString = Request.QueryString.Add("$expand", "Customer,Product");

            this.OnAfterOrderTCreated(item);

            return new ObjectResult(SingleResult.Create(itemToReturn))
            {
                StatusCode = 201
            };
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
