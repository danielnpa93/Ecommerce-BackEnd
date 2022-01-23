using ECommerce.API.Models.Entities;
using ECommerce.API.Utils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.API.Context
{
    public class OrderContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<DeliveryTeam> DeliveryTeam { get; set; }

        public DbSet<OrderProduct> OrdersProducts { get; set; }

        public DbSet<User> User { get; set; }

        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasOne<DeliveryTeam>(order => order.DeliveryTeam)
                .WithMany(dt => dt.Orders)
                .HasForeignKey(order => order.DeliveryTeamId);

            modelBuilder.Entity<OrderProduct>()
                .HasKey(op => new { op.ProductId, op.OrderId });

            modelBuilder.Entity<OrderProduct>()
                .HasData(SeedData.SeedOrderProduct());

            modelBuilder.Entity<Order>()
                .HasData(SeedData.SeedOrders());

            modelBuilder.Entity<Product>()
                .HasData(SeedData.SeedProducts());

            modelBuilder.Entity<DeliveryTeam>()
                .HasData(SeedData.SeedDeliveryTeams());

        }
    }
}
