using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Modelos;
using ProyectoFinal.Repositorio;

namespace ProyectoFinal.Repositorio
{
    public class Repositorio : IRepositorio
    {
        private readonly AlquilerDBContext _context;
        public Repositorio(AlquilerDBContext context)
        {
            _context = context;
        }

        // Peliculas
        public async Task<Pelicula> AddPelicula(Pelicula pelicula)
        {
            await _context.Peliculas.AddAsync(pelicula);
            await _context.SaveChangesAsync();
            return pelicula;
        }

        public async Task DeletePelicula(int id)
        {
            var pelicula = await _context.Peliculas.FindAsync(id);
            if (pelicula != null)
            {
                _context.Peliculas.Remove(pelicula);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Pelicula?> GetPelicula(int id)
        {
            return await _context.Peliculas.Include(x => x.Alquileres).Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Pelicula>> GetAllPeliculas()
        {
            return await _context.Peliculas.ToListAsync();
        }

        public async Task UpdatePelicula(int id, Pelicula pelicula)
        {
            var currentPelicula = await _context.Peliculas.FindAsync(id);
            if (currentPelicula != null)
            {
                currentPelicula.Titulo = pelicula.Titulo;
                currentPelicula.AñoLanzamiento = pelicula.AñoLanzamiento;
                currentPelicula.Genero = pelicula.Genero;
                currentPelicula.Director = pelicula.Director;
                currentPelicula.ActoresPrincipales = pelicula.ActoresPrincipales;
                currentPelicula.Sinopsis = pelicula.Sinopsis;
                currentPelicula.PrecioAlquiler = pelicula.PrecioAlquiler;
                currentPelicula.DisponibleParaAlquiler = pelicula.DisponibleParaAlquiler;
                await _context.SaveChangesAsync();
            }
        }

        // Clientes
        public async Task<Cliente> AddCliente(Cliente cliente)
        {
            await _context.Clientes.AddAsync(cliente);
            await _context.SaveChangesAsync();
            return cliente;
        }

        public async Task DeleteCliente(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Cliente?> GetCliente(int id)
        {
            return await _context.Clientes.Include(x => x.Alquileres).Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Cliente>> GetAllClientes()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task UpdateCliente(int id, Cliente cliente)
        {
            var currentCliente = await _context.Clientes.FindAsync(id);
            if (currentCliente != null)
            {
                currentCliente.Nombre = cliente.Nombre;
                currentCliente.Correo = cliente.Correo;
                currentCliente.Telefono = cliente.Telefono;
                currentCliente.DetallesMembresia = cliente.DetallesMembresia;
                await _context.SaveChangesAsync();
            }
        }

        // Alquileres
        public async Task<Alquiler> AddAlquiler(Alquiler alquiler)
        {
            await _context.Alquileres.AddAsync(alquiler);
            await _context.SaveChangesAsync();
            return alquiler;
        }

        public async Task DeleteAlquiler(int id)
        {
            var alquiler = await _context.Alquileres.FindAsync(id);
            if (alquiler != null)
            {
                _context.Alquileres.Remove(alquiler);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Alquiler?> GetAlquiler(int id)
        {
            return await _context.Alquileres.FindAsync(id);
        }

        public async Task<List<Alquiler>> GetAllAlquileres()
        {
            return await _context.Alquileres.ToListAsync();
        }

        public async Task UpdateAlquiler(int id, Alquiler alquiler)
        {
            var currentAlquiler = await _context.Alquileres.FindAsync(id);
            if (currentAlquiler != null)
            {
                currentAlquiler.PeliculaId = alquiler.PeliculaId;
                currentAlquiler.ClienteId = alquiler.ClienteId;
                currentAlquiler.FechaAlquiler = alquiler.FechaAlquiler;
                currentAlquiler.FechaDevolucion = alquiler.FechaDevolucion;
                currentAlquiler.Monto = alquiler.Monto;
                currentAlquiler.EstadoAlquiler = alquiler.EstadoAlquiler;
                await _context.SaveChangesAsync();
            }
        }
    }
}
