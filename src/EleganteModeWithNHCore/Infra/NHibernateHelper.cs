namespace EleganteModeWithNHCore.Infra;

public sealed class SessionFactory
{
    private static ISessionFactory CreateSession() =>
        Fluently
            .Configure()
            .Database
            (SQLiteConfiguration
                .Standard
                .UsingFile($"{AppDomain.CurrentDomain.BaseDirectory}/DataBaseNHManyToManyEleganteMode.db"))
            .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
            .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(false, true))
            .BuildSessionFactory();

    public static void EnsureCreated() => CreateSession().OpenSession();
}