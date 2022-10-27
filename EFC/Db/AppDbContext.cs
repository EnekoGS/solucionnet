namespace EFC1.Db;
public class AppDbContext : DbContext
{


    // atributos
    public DbSet<Book> Books { get; set; } // Agregar un DbSet por cada clase en Models que tengamos


    // constructores
    public AppDbContext(DbContextOptions options) : base(options)
    {

    }
}