using Microsoft.EntityFrameworkCore;



public class Contexto: DbContext{
    public DbSet<Inventario> Inventario {get; set;}

    public DbSet<Caja> Cajas {get; set;}

    public DbSet<Fundita> Funditas {get; set;}

    // public Contexto(DbContextOptions<Contexto> options) : base(options){}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        
        optionsBuilder.UseSqlite("Data Source=Data/Inventario.db");
        
    }

}