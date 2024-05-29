using ProyectoFinal.Modelos;
namespace ProyectoFinal.Repositorio
{
    public interface IRepositorio
    {
        // Peliculas
        Task<List<Pelicula>> GetAllPeliculas();
        Task<Pelicula> GetPelicula(int id);
        Task<Pelicula> AddPelicula(Pelicula pelicula);
        Task UpdatePelicula(int id, Pelicula pelicula);
        Task DeletePelicula(int id);

        // Clientes
        Task<List<Cliente>> GetAllClientes();
        Task<Cliente> GetCliente(int id);
        Task<Cliente> AddCliente(Cliente cliente);
        Task UpdateCliente(int id, Cliente cliente);
        Task DeleteCliente(int id);

        // Alquileres
        Task<List<Alquiler>> GetAllAlquileres();
        Task<Alquiler> GetAlquiler(int id);
        Task<Alquiler> AddAlquiler(Alquiler alquiler);
        Task UpdateAlquiler(int id, Alquiler alquiler);
        Task DeleteAlquiler(int id);
    }
}
