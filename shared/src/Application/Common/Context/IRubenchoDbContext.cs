using Microsoft.EntityFrameworkCore;
using Rubencho.Domain.Entities;

namespace Rubencho.Application.Common.Context;

/// <summary>
/// Defines rebencho db context entities and behavior.
/// </summary>
public interface IRubenchoDbContext : IDbContext
{
    public DbSet<Acompanamiento> Acompanamientos { get; set; }

    public DbSet<CategoriaProducto> CategoriaProductos { get; set; }

    public DbSet<Colaborador> Colaboradores { get; set; }

    public DbSet<EstadoPedido> EstadoPedidos { get; set; }

    public DbSet<Pedido> Pedidos { get; set; }

    public DbSet<Producto> Productos { get; set; }

    public DbSet<ProductoPedido> ProductoPedidos { get; set; }
}
