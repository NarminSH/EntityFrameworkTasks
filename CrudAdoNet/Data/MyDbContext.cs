using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


    public partial class MyDbContext : DbContext
    {
        public virtual DbSet<Contact> Contacts { get; set; }
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=localhost,1433;uid=sa;database=MyDb;pwd=your_password123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>(model =>
            {
                model.HasKey(prop => prop.Id);
                model.Property(prop => prop.Name).HasMaxLength(50).IsRequired(true);
                model.Property(prop => prop.Surname).HasMaxLength(100).IsRequired(true);
                model.Property(prop => prop.Phone).HasMaxLength(30).IsRequired(true);
                model.Property(prop => prop.Mail).HasMaxLength(30).IsRequired(true);

            });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

