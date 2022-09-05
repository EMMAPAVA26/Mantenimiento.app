using System.Collections.Generic;
using Mantenimiento.app.Dominio;

namespace Mantenimiento.app.Persistencia
{
    public interface IRepositorioCliente
    {
        IEnumerable<Cliente> GetAllClientes();
        Cliente AddCliente(Cliente cliente);
        Cliente UpdateCliente(Cliente cliente);
        void DeleteCliente(int idCliente);
        Cliente GetCliente(int idCliente);
    }
}