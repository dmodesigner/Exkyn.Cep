using Data.EntityConfig;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Data.DB
{
    public class CepBrasilDB : DbContext
    {
        public CepBrasilDB(DbContextOptions<CepBrasilDB> options) : base(options)
        {
            
        }

        public virtual DbSet<States> States { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Neighborhoods> Neighborhoods { get; set; }
        public virtual DbSet<Adresses> Adresses { get; set; }

        public override int SaveChanges()
        {
            var entities = from e in ChangeTracker.Entries() where e.State == EntityState.Added || e.State == EntityState.Modified select e.Entity;

            foreach (var entity in entities)
            {
                var validationContext = new ValidationContext(entity);

                Validator.ValidateObject(entity, validationContext);
            }

            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StatesConfig());
            modelBuilder.ApplyConfiguration(new CitiesConfig());
            modelBuilder.ApplyConfiguration(new NeighborhoodsConfig());
            modelBuilder.ApplyConfiguration(new AdressesConfig());
        }
    }
}
