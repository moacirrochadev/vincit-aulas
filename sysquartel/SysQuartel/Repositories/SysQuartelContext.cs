using Microsoft.EntityFrameworkCore;
using SysQuartel.Models;

namespace SysQuartel.Repositories;

public class SysQuartelContext : DbContext
{
    public DbSet<Militar> Militares { get; set; }

    public SysQuartelContext(DbContextOptions<SysQuartelContext> options)
    : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseLazyLoadingProxies();
    }

}
