using Microsoft.EntityFrameworkCore;
using ProjectBaseIdentity.Entities;

namespace ProjectBaseIdentity;

public class ProjectBaseDbContext: DbContext
{
    public ProjectBaseDbContext(DbContextOptions options) : base(options)
    {

    }

    public ProjectBaseDbContext()
    {
    }

    public DbSet<User> Users { get; set; }

    public DbSet<UserClaims> Claims { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
      
    }
}
