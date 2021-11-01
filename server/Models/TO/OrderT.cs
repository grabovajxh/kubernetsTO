using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiomsOrders.Models.To
{
  [Table("OrderT", Schema = "dbo")]
  public partial class OrderT
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int OrderID
    {
      get;
      set;
    }
    public int? Quantity
    {
      get;
      set;
    }
    public int? CustomerID
    {
      get;
      set;
    }
    public Customer Customer { get; set; }
    public int? ProductID
    {
      get;
      set;
    }
    public Product Product { get; set; }
    public string Description
    {
      get;
      set;
    }
  }
}
