using ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Configurations;

namespace Infrastructure
{
    public class AMContext : DbContext
    {
        public DbSet<Artiste> artistes { get; set; }
        public DbSet<chanson> chansons { get; set; }
        public DbSet<concerte> concertes { get; set; }
        public DbSet<festival> festivals { get; set; }
        

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            @"Data Source=(localdb)\mssqllocaldb;
                Initial Catalog=examenChanson;
                Integrated Security=true;
                MultipleActiveResultSets=true");
        optionsBuilder.UseLazyLoadingProxies();
        base.OnConfiguring(optionsBuilder);
    }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.ApplyConfiguration(new PlaneConfiguration());
            //modelBuilder.Entity<Plane>().HasKey(p => p.PlaneId);
            //modelBuilder.Entity<Plane>().ToTable("MyPlanes");
            //modelBuilder.Entity<Plane>().Property(p => p.Capacity)
               // .HasColumnName("PlaneCapacity");
            modelBuilder.ApplyConfiguration(new ConcertConfiguration());
            //configurer OwnedType
            //modelBuilder.Entity<Passenger>().OwnsOne(p => p.FullName);

            //configurer l'héritage table par Hierarchy
            //modelBuilder.Entity<Passenger>()
            //     .HasDiscriminator<int>("IsTraveller")
            //     .HasValue<Passenger>(2)
            //     .HasValue<Staff>(0)
            //     .HasValue<Traveller>(1);

            //Configurer l'heritage table par type
            //modelBuilder.Entity<Staff>().ToTable("Staffs");
            //modelBuilder.Entity<Traveller>().ToTable("Travellers");

            //Configurer la porteuse de données
            //modelBuilder.Entity<Ticket>()
                      //  .HasKey(t => new { t.FlightFk, t.PassengerFk });

            base.OnModelCreating(modelBuilder);
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>()
                .HaveMaxLength(50);
            base.ConfigureConventions(configurationBuilder);
        }

    }
}
