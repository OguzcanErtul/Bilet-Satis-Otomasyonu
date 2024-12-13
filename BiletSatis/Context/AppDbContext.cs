using BiletSatis.Configurations;
using BiletSatis.Entities;
using BiletSatis.Entities.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BiletSatis.Context
{
    public class AppDbContext : DbContext
    {
        
        public DbSet<Bilet> Biletler { get; set; }
        public DbSet<Etkinlik> Etkinlikler { get; set; }
        public DbSet<EtkinlikSalon> EtkinlikSsalon { get; set; }
        
        public DbSet<Salon> Salonlar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-HL6R8FL\\SQLEXPRESS;Database=HS14DBEtkinlik;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True").UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

            }
            base.OnConfiguring(optionsBuilder);


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //new BiletConfiguration().Configure(modelBuilder.Entity<Bilet>());
            //new SalonConfiguration().Configure(modelBuilder.Entity<Salon>());
            //new EtkinlikConfiguration().Configure(modelBuilder.Entity<Etkinlik>());
            //new EtkinlikSalonConfiguration().Configure(modelBuilder.Entity<EtkinlikSalon>());

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(IEntityConfiguration).Assembly);

            base.OnModelCreating(modelBuilder);
        }
        public override int SaveChanges()
        {

            SetBaseProperties();

            return base.SaveChanges();
        }

        private void SetBaseProperties()
        {
            var entries = ChangeTracker.Entries<BaseEntity>();
            foreach (var entry in entries)
            {
                SetIfAdded(entry);
                SetIfModified(entry);
                SetIfDeleted(entry);
                
            }
        }

        private void SetIfDeleted(EntityEntry<BaseEntity> entry)
        {
            if (entry.State == EntityState.Deleted)
            {
                entry.State = EntityState.Modified;
                entry.Entity.Status = Enum.Status.Deleted;
                entry.Entity.SilmeTarihi = DateTime.Now;

            }
        }

        private void SetIfModified(EntityEntry<BaseEntity> entry)
        {
            if (entry.State == EntityState.Modified)
            {
                entry.Entity.Status = Enum.Status.Modified;
                entry.Entity.DegisimTarihi = DateTime.Now;

            }
        }

        private void SetIfAdded(EntityEntry<BaseEntity> entry)
        {
            if (entry.State == EntityState.Added)
            {
                entry.Entity.Status = Enum.Status.Added;
                entry.Entity.OlusturmaTarihi = DateTime.Now;
                    
            }
        }
    }
}
