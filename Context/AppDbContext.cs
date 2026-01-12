using CodeFirstApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstApi.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<UserProfile> UserProfiles { get; set; }

}
