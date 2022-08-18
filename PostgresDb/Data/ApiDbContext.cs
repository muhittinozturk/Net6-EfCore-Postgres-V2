using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PostgresDb.Models;

namespace PostgresDb.Data;

public class ApiDbContext : DbContext
{
    public virtual DbSet<Driver> Drivers {get; set;}
    public virtual DbSet<Team> Teams {get;set;}
    public virtual DbSet<DriverMedia> DriverMedias {get;set;}

    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
    {
        
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Driver>(entity => {
            // 1 - Many
            entity.HasOne(t => t.Team)
                .WithMany(d => d.Drivers)
                .HasForeignKey(x => x.TeamId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Driver_Team");

            // 1 - 1
            entity.HasOne(dm => dm.DriverMedia)
                    .WithOne(d => d.Driver)
                    .HasForeignKey<DriverMedia>(x => x.DriverId);

            entity.ToTable("F12022Drivers");

            entity.HasComment("This is a table for f1 drivers");

            entity.Property(x => x.RacingNumber)
                    .HasComment("This is the designated unique driver number");

            entity.Property(x => x.Id)
                .HasColumnName("driver_id");   

            entity.Property(x => x.TeamId)
                .HasColumnOrder(3);  

            entity.Property(x => x.Status)
                .HasColumnOrder(5); 
        });

        modelBuilder.Entity<Team>()
                    .HasComment("This table is for the F1 Teams to manage their Season")
                    .Ignore(x => x.NumberOfPoints)
                    .Property(x => x.Name)
                    .HasComment("This is a sample comment for a column");

    }
}
