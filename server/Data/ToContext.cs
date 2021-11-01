using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;

using TiomsOrders.Models.To;

namespace TiomsOrders.Data
{
  public partial class ToContext : Microsoft.EntityFrameworkCore.DbContext
  {
    public ToContext(DbContextOptions<ToContext> options):base(options)
    {
    }

    public ToContext()
    {
    }

    partial void OnModelBuilding(ModelBuilder builder);

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<TiomsOrders.Models.To.OrderT>()
              .HasOne(i => i.Customer)
              .WithMany(i => i.OrderTs)
              .HasForeignKey(i => i.CustomerID)
              .HasPrincipalKey(i => i.CustomerID);
        builder.Entity<TiomsOrders.Models.To.OrderT>()
              .HasOne(i => i.Product)
              .WithMany(i => i.OrderTs)
              .HasForeignKey(i => i.ProductID)
              .HasPrincipalKey(i => i.ProductID);


        builder.Entity<TiomsOrders.Models.To.Customer>()
              .Property(p => p.CustomerID)
              .HasPrecision(10, 0);

        builder.Entity<TiomsOrders.Models.To.OrderT>()
              .Property(p => p.OrderID)
              .HasPrecision(10, 0);

        builder.Entity<TiomsOrders.Models.To.OrderT>()
              .Property(p => p.Quantity)
              .HasPrecision(10, 0);

        builder.Entity<TiomsOrders.Models.To.OrderT>()
              .Property(p => p.CustomerID)
              .HasPrecision(10, 0);

        builder.Entity<TiomsOrders.Models.To.OrderT>()
              .Property(p => p.ProductID)
              .HasPrecision(10, 0);

        builder.Entity<TiomsOrders.Models.To.Product>()
              .Property(p => p.ProductID)
              .HasPrecision(10, 0);

        builder.Entity<TiomsOrders.Models.To.Product>()
              .Property(p => p.Price)
              .HasPrecision(53, 0);

        builder.Entity<TiomsOrders.Models.To.Product>()
              .Property(p => p.Stock)
              .HasPrecision(10, 0);
        this.OnModelBuilding(builder);
    }


    public DbSet<TiomsOrders.Models.To.Customer> Customers
    {
      get;
      set;
    }

    public DbSet<TiomsOrders.Models.To.OrderT> OrderTs
    {
      get;
      set;
    }

    public DbSet<TiomsOrders.Models.To.Product> Products
    {
      get;
      set;
    }
  }
}
