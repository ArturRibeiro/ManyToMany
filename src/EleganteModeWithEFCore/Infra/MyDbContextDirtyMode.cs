namespace EleganteModeWithEFCore.Infra;

public class MyDbContextEleganteModeWithEFCore : DbContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder) =>
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MyDbContextEleganteModeWithEFCore).Assembly);

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => 
        optionsBuilder.UseSqlite($"Data Source={Directory.GetCurrentDirectory()}/DataBaseEleganteModeWithEFCore.db");

    public void EnsureCreated() => this.Database.EnsureCreated();
}