using ProyectoFinal.Modelos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ProyectoFinal.Modelos
{
    public class AlquilerDBContext : DbContext
    {
        public AlquilerDBContext(DbContextOptions<AlquilerDBContext> options) : base(options)
        {
        }

        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Alquiler> Alquileres { get; set; }
    }
}