﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PostgresDb.Data;

#nullable disable

namespace PostgresDb.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20220814121050_update_columns_order_1")]
    partial class update_columns_order_1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PostgresDb.Models.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("driver_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FavoriteColor")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RacingNumber")
                        .HasColumnType("integer")
                        .HasComment("This is the designated unique driver number");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnOrder(5);

                    b.Property<int>("TeamId")
                        .HasColumnType("integer")
                        .HasColumnOrder(3);

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("F12022Drivers", (string)null);

                    b.HasComment("This is a table for f1 drivers");
                });

            modelBuilder.Entity("PostgresDb.Models.DriverMedia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DriverId")
                        .HasColumnType("integer");

                    b.Property<string>("Media")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("DriverId")
                        .IsUnique();

                    b.ToTable("DriverMedias");
                });

            modelBuilder.Entity("PostgresDb.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasComment("This is a sample comment for a column");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<int>("Year")
                        .HasColumnType("integer")
                        .HasColumnName("racing_year");

                    b.HasKey("Id");

                    b.ToTable("Teams");

                    b.HasComment("This table is for the F1 Teams to manage their Season");
                });

            modelBuilder.Entity("PostgresDb.Models.Driver", b =>
                {
                    b.HasOne("PostgresDb.Models.Team", "Team")
                        .WithMany("Drivers")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("FK_Driver_Team");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("PostgresDb.Models.DriverMedia", b =>
                {
                    b.HasOne("PostgresDb.Models.Driver", "Driver")
                        .WithOne("DriverMedia")
                        .HasForeignKey("PostgresDb.Models.DriverMedia", "DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Driver");
                });

            modelBuilder.Entity("PostgresDb.Models.Driver", b =>
                {
                    b.Navigation("DriverMedia")
                        .IsRequired();
                });

            modelBuilder.Entity("PostgresDb.Models.Team", b =>
                {
                    b.Navigation("Drivers");
                });
#pragma warning restore 612, 618
        }
    }
}
