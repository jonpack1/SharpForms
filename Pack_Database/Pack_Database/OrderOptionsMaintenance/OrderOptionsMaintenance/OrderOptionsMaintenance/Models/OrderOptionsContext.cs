using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Configuration;


namespace OrderOptionsMaintenance.Models;

public partial class OrderOptionsContext : DbContext
{
    public OrderOptionsContext()
    {
    }

    public OrderOptionsContext(DbContextOptions<OrderOptionsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<InvoiceLineItem> InvoiceLineItems { get; set; }

    public virtual DbSet<OrderOption> OrderOptions { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<State> States { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["OrderOptionsContext"].ConnectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Address)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.State)
                .IsRequired()
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ZipCode)
                .IsRequired()
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.StateNavigation).WithMany(p => p.Customers)
                .HasForeignKey(d => d.State)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Customers_States");
        });

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceTotal).HasColumnType("money");
            entity.Property(e => e.ProductTotal).HasColumnType("money");
            entity.Property(e => e.SalesTax).HasColumnType("money");
            entity.Property(e => e.Shipping).HasColumnType("money");

            entity.HasOne(d => d.Customer).WithMany(p => p.Invoices)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_Invoices_Customers");
        });

        modelBuilder.Entity<InvoiceLineItem>(entity =>
        {
            entity.HasKey(e => new { e.InvoiceId, e.ProductCode });

            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.ProductCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ItemTotal).HasColumnType("money");
            entity.Property(e => e.UnitPrice).HasColumnType("money");

            entity.HasOne(d => d.Invoice).WithMany(p => p.InvoiceLineItems)
                .HasForeignKey(d => d.InvoiceId)
                .HasConstraintName("FK_InvoiceLineItems_Invoices");

            entity.HasOne(d => d.ProductCodeNavigation).WithMany(p => p.InvoiceLineItems)
                .HasForeignKey(d => d.ProductCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InvoiceLineItems_Products");
        });

        modelBuilder.Entity<OrderOption>(entity =>
        {
            entity.HasKey(e => e.OptionId);

            entity.Property(e => e.OptionId).HasColumnName("OptionID");
            entity.Property(e => e.AdditionalBookShipCharge).HasColumnType("money");
            entity.Property(e => e.FirstBookShipCharge).HasColumnType("money");
            entity.Property(e => e.SalesTaxRate).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductCode);

            entity.Property(e => e.ProductCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UnitPrice).HasColumnType("money");
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.HasKey(e => e.StateCode);

            entity.Property(e => e.StateCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.StateName)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
