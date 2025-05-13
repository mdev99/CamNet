using System;
using Core.Entities;
using infrastructure.Config;
using Microsoft.EntityFrameworkCore;

namespace infrastructure.Data;

public class StoreContext(DbContextOptions options) : DbContext(options)
{
    public required DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductConfiguration).Assembly);
    }
}
