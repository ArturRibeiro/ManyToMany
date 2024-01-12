namespace DirtyModeWithEFCore.Infra;

public class MyDbContextDirtyMode : DbContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder) =>
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MyDbContextDirtyMode).Assembly);

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => 
        optionsBuilder.UseSqlite($"Data Source={Directory.GetCurrentDirectory()}/DataBaseEFManyToManyDirtyMode.db");

    public void EnsureCreated() => this.Database.EnsureCreated();
}