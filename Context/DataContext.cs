using EmailProject.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EmailProject.DataLayer.Context
{
    public class DataContext : DbContext
    {
        public DataContext() : base()
        {
            ChangeTracker.AutoDetectChangesEnabled = true;
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            ChangeTracker.AutoDetectChangesEnabled = true;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Email>();

        }

        public DbSet<Email> Email { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var test = Directory.GetCurrentDirectory();
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();

                var builder = new DbContextOptionsBuilder<DataContext>();
                var connectionString = configuration.GetConnectionString("UserConnectionString");
                builder.UseSqlServer(connectionString, b => b.MigrationsAssembly("EMAILSERVICEPROJECT"));
                optionsBuilder.EnableSensitiveDataLogging().UseSqlServer(connectionString);
            }
        }
    }

}
