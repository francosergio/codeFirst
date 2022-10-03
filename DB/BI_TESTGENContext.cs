using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace DB
{
    public class BI_TESTGENContext : DbContext
    {
        public BI_TESTGENContext(DbContextOptions<BI_TESTGENContext> options)
            : base(options) 
        {        
        }       
        /*la clase Dbset : permite la creacion de tablas */
        public DbSet<Client>   Clients   { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Genger>   Gengers   { get; set; }   
    
        /*sobre escribiendo el siguiente metodo, permite cambiar el nombre de la 
        tabla en el sql server 
        */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Document>().ToTable("Document");
            modelBuilder.Entity<Genger>().ToTable("Genger");
        }
    }
}
