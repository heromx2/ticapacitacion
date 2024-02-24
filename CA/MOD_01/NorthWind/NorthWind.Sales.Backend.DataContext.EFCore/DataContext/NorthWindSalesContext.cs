namespace NorthWind.Sales.Backend.DataContext.EFCore.DataContext;
internal class NorthWindSalesContext(IOptions<DBOptions> dBOptions) : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            dBOptions.Value.ConnectionString);
    }

    public DbSet<Order> Orders { get; set; }
    public DbSet<Repositories.Entities.OrderDetail> OrdersDetails { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
