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

  [ODataRoutePrefix("odata/TO/Products")]
  [Route("mvc/odata/TO/Products")]
  public partial class ProductsController : ODataController
  {
    private Data.ToContext context;

    public ProductsController(Data.ToContext context)
    {
      this.context = context;
    }
    // GET /odata/To/Products
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.To.Product> GetProducts()
    {
      var items = this.context.Products.AsQueryable<Models.To.Product>();
      this.OnProductsRead(ref items);

      return items;
    }

    partial void OnProductsRead(ref IQueryable<Models.To.Product> items);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{ProductID}")]
    public SingleResult<Product> GetProduct(int key)
    {
        var items = this.context.Products.Where(i=>i.ProductID == key);
        return SingleResult.Create(items);
    }
    partial void OnProductDeleted(Models.To.Product item);
    partial void OnAfterProductDeleted(Models.To.Product item);

    [HttpDelete("{ProductID}")]
    public IActionResult DeleteProduct(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Products
                .Where(i => i.ProductID == key)
                .Include(i => i.OrderTs)
                .FirstOrDefault();

            if (item == null)
            {
                return BadRequest();
            }

            this.OnProductDeleted(item);
            this.context.Products.Remove(item);
            this.context.SaveChanges();
            this.OnAfterProductDeleted(item);

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnProductUpdated(Models.To.Product item);
    partial void OnAfterProductUpdated(Models.To.Product item);

    [HttpPut("{ProductID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutProduct(int key, [FromBody]Models.To.Product newItem)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (newItem == null || (newItem.ProductID != key))
            {
                return BadRequest();
            }

            this.OnProductUpdated(newItem);
            this.context.Products.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Products.Where(i => i.ProductID == key);
            this.OnAfterProductUpdated(newItem);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    [HttpPatch("{ProductID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PatchProduct(int key, [FromBody]Delta<Models.To.Product> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Products.Where(i => i.ProductID == key).FirstOrDefault();

            if (item == null)
            {
                return BadRequest();
            }

            patch.Patch(item);

            this.OnProductUpdated(item);
            this.context.Products.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Products.Where(i => i.ProductID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnProductCreated(Models.To.Product item);
    partial void OnAfterProductCreated(Models.To.Product item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.To.Product item)
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

            this.OnProductCreated(item);
            this.context.Products.Add(item);
            this.context.SaveChanges();

            return Created($"odata/To/Products/{item.ProductID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
