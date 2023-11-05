namespace AudioLibraryApp.Data;

using AudioLibraryApp.Entities;
using Microsoft.EntityFrameworkCore;

public class AudioLibraryDbContext : DbContext
{
    public DbSet<CDMusic> CDMusics => Set<CDMusic>();

    public DbSet<VinylMusic> VinylMusics => Set<VinylMusic>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseInMemoryDatabase("AudioLibraryAppDb");
    }
}

