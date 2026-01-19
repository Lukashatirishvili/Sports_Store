using Microsoft.EntityFrameworkCore;

namespace Sports_Store.Models;

public class SportsStoreDb : DbContext
{
    public SportsStoreDb(DbContextOptions<SportsStoreDb> options) : base(options) {}
    
    public DbSet<Product> Products => Set<Product>();
}