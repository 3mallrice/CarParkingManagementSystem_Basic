using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace DataObject.Models
{
    public partial class BookingCarParkingManagementContext : DbContext
    {
        public BookingCarParkingManagementContext()
        {
        }

        public BookingCarParkingManagementContext(DbContextOptions<BookingCarParkingManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Baixe> Baixes { get; set; } = null!;
        public virtual DbSet<Book> Books { get; set; } = null!;
        public virtual DbSet<Car> Cars { get; set; } = null!;
        public virtual DbSet<Slotxe> Slotxes { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer(GetConnectionString());
            }
            
        }
        private string GetConnectionString()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            return config["ConnectionStrings:DefaultConnectionStringDB"];
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Baixe>(entity =>
            {
                entity.ToTable("Baixe");

                entity.Property(e => e.BaixeId).HasColumnName("BaixeID");

                entity.Property(e => e.BaixeName).HasMaxLength(255);
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("Book");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.BookingTime).HasColumnType("datetime");

                entity.Property(e => e.CarId).HasColumnName("CarID");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.SlotxeId).HasColumnName("SlotxeID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.CarId)
                    .HasConstraintName("FK__Book__CarID__5441852A");

                entity.HasOne(d => d.Slotxe)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.SlotxeId)
                    .HasConstraintName("FK__Book__SlotxeID__534D60F1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Book__UserID__5FB337D6");
            });

            modelBuilder.Entity<Car>(entity =>
            {
                entity.ToTable("Car");

                entity.Property(e => e.CarId).HasColumnName("CarID");

                entity.Property(e => e.Bsx)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BSX");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Car__UserID__5070F446");
            });

            modelBuilder.Entity<Slotxe>(entity =>
            {
                entity.ToTable("Slotxe");

                entity.Property(e => e.SlotxeId).HasColumnName("SlotxeID");

                entity.Property(e => e.BaixeId).HasColumnName("BaixeID");

                entity.HasOne(d => d.Baixe)
                    .WithMany(p => p.Slotxes)
                    .HasForeignKey(d => d.BaixeId)
                    .HasConstraintName("FK__Slotxe__BaixeID__4BAC3F29");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.HasKey(e => e.UserId);
                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
