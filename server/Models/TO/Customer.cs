using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiomsOrders.Models.To
{
  [Table("Customer", Schema = "dbo")]
  public partial class Customer
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CustomerID
    {
      get;
      set;
    }

    public IEnumerable<OrderT> OrderTs { get; set; }
    public string LastName
    {
      get;
      set;
    }
    public string FirstName
    {
      get;
      set;
    }
    public string FullName
    {
      get;
      set;
    }
    public string Address
    {
      get;
      set;
    }
    public string City
    {
      get;
      set;
    }
  }
}
