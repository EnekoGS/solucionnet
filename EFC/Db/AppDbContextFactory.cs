namespace EFC1.Db;
public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        // Crear configuración mysql
        string url = "server=localhost;port=3306;user=root;password=admin;database=cursonet";

        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseMySql(url, ServerVersion.AutoDetect(url))
            .Options;

        return new AppDbContext(options);
    }
}




