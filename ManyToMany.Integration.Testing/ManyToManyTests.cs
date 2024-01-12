namespace ManyToMany.Integration.Testing;

public class ManyToManyTests
{
    [Fact(DisplayName = "Dirty mode with EF Core")]
    public void CreateDataBaseDirtyModeWithEFCore() => new MyDbContextDirtyMode().EnsureCreated();
    
    [Fact(DisplayName = "Elegante mode with NHibernate")]
    public void CreateDataBaseEleganteModeWithNHibernate() => SessionFactory.EnsureCreated();

    [Fact(DisplayName = "Elegante mode with EF Core")]
    public void CreateDataBaseEleganteModeWithEFCore() => new MyDbContextEleganteModeWithEFCore().EnsureCreated();
}