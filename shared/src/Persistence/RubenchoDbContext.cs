using Microsoft.EntityFrameworkCore;
using Rubencho.Application.Common.Context;
using Rubencho.Domain.Entities;

namespace Rubencho.Persistence;

public partial class RubenchoDbContext : DbContext, IRubenchoDbContext
{
    public RubenchoDbContext()
    {
    }

    public RubenchoDbContext(DbContextOptions<RubenchoDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Acompanamiento> Acompanamientos { get; set; }

    public virtual DbSet<CategoriaProducto> CategoriaProductos { get; set; }

    public virtual DbSet<Colaborador> Colaboradores { get; set; }

    public virtual DbSet<EstadoPedido> EstadoPedidos { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<ProductoPedido> ProductoPedidos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost;Database=RubenchoDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Command Timeout=0");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Acompanamiento>(entity =>
        {
            entity.HasKey(e => e.IdAcompanamiento);

            entity.ToTable("Acompanamiento");

            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<CategoriaProducto>(entity =>
        {
            entity.HasKey(e => e.IdCategoriaProducto);

            entity.ToTable("CategoriaProducto");

            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Colaborador>(entity =>
        {
            entity.HasKey(e => e.IdColaborador);

            entity.ToTable("Colaborador");

            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<EstadoPedido>(entity =>
        {
            entity.HasKey(e => e.IdEstadoPedido);

            entity.ToTable("EstadoPedido");

            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.IdPedido);

            entity.ToTable("Pedido");

            entity.Property(e => e.Fecha).HasColumnType("datetime");

            entity.HasOne(d => d.IdColaboradorNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.IdColaborador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pedido_Colaborador");

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.IdEstado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pedido_EstadoPedido");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProducto).HasName("PK_Productos");

            entity.ToTable("Producto");

            entity.Property(e => e.Nombre)
                .HasMaxLength(70)
                .IsUnicode(false);

            entity.HasOne(d => d.IdCategoriaProductoNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdCategoriaProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Producto_CategoriaProducto");
        });

        modelBuilder.Entity<ProductoPedido>(entity =>
        {
            entity.HasKey(e => e.IdProductoPedido);

            entity.ToTable("ProductoPedido");

            entity.Property(e => e.Observaciones).HasMaxLength(100);

            entity.HasOne(d => d.IdAcompanamientoNavigation).WithMany(p => p.ProductoPedidos)
                .HasForeignKey(d => d.IdAcompanamiento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductoPedido_Acompanamiento");

            entity.HasOne(d => d.IdPedidoNavigation).WithMany(p => p.ProductoPedidos)
                .HasForeignKey(d => d.IdPedido)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductoPedido_Pedido");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.ProductoPedidos)
                .HasForeignKey(d => d.IdProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductoPedido_Producto");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
