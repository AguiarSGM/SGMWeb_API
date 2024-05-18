using Microsoft.EntityFrameworkCore;
using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Infrastructure.Data.DataBase;

public class ModelContext : DbContext
{
    public DbSet<Address> Categories { get; set; }

    protected ModelContext()
    {
    }
    public ModelContext(DbContextOptions<ModelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Address { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    
}
