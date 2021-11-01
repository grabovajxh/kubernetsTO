using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiomsOrders.Models.To
{
  [Table("Product", Schema = "dbo")]
  public partial class Product
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProductID
    {
      get;
      set;
    }

    public IEnumerable<OrderT> OrderTs { get; set; }
    public string ProductName
    {
      get;
      set;
    }
    public double? Price
    {
      get;
      set;
    }
    public string Description
    {
      get;
      set;
    }
    public int? Stock
    {
      get;
      set;
    }
  }
}
