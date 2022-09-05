using System;
using Mantenimiento.app.Dominio;
using Mantenimiento.app.Persistencia;

namespace Mantenimiento.app.Consola
{
    class Program
    {
        private static IRepositorioCliente _repoCliente= new RepositorioCliente(new Persistencia.AppContext);
        static void Main(string[] args)
        {
            Console.WriteLine("Hola tu y hola yo");
            AddCliente();
        }

        private static void AddCliente()
        {
            var cliente = new Cliente{
                Nombre="Nicolas",
                Apellido="Perez",
                Documento="10000000",
                Direccion="villa perdida",
                Telefono="6060000000",
                correo="done@notiene.com",
                User="elfue",
                Pass="theend"
            }
            _repoCliente.AddCliente(cliente);
        }
    }
}
