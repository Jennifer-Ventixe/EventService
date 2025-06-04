using Microsoft.EntityFrameworkCore;
using Data.Entities;
using System.Collections.Generic;

namespace Data.Contexts;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<EventEntity> Events { get; set; } = null!;
    public DbSet<PackageEntity> Packages { get; set; } = null!;
    public DbSet<EventPackageEntity> EventsPackages { get; set; } = null!;
}
