using DominandoEFCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominandoEFCore.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //const string strConnectionSQLServer = "Data Source=DESKTOP-B76722G\\SQLEXPRESS; Initial Catalog=DominandoEFCoreV2; User ID=developer; Password=dev*10; Integrated Security=True; Persist Security Info=False; Pooling=False; MultipleActiveResultSets=False; Encrypt=False; Trusted_Connection=False";
            //const string strConnectionPostgreSQL = "Host=localhost; Database=DominandoEFCoreV2; Username=postgres; Password=123";
            //const string strConnectionSQLite = "Data source=DominandoEFCoreV2.db";

            optionsBuilder//.UseSqlServer(strConnectionSQLServer)
                          //.UseNpgsql(strConnectionPostgreSQL)
                          //.UseSqlite(strConnectionSQLite)
                          //.UseInMemoryDatabase(databaseName: "Teste-DominandoEFCoreV2")
                          .UseCosmos("https://localhost:8081/",
                                     "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==",
                                     "DominandoEFCoreV2")
                          .LogTo(Console.WriteLine, LogLevel.Information)
                          .EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>(conf => 
            {
                conf.HasKey(pessoa => pessoa.Id);
                
                conf.ToContainer("Pessoas");

                //conf.Property(pessoa => pessoa.Nome)
                //    .HasMaxLength(60)
                //    .IsUnicode(false);
            });
        }
    }
}
