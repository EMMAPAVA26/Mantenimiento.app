using System;
namespace Mantenimiento.app.Dominio
{
    public class Servicio
    {
        public int IdServicio{get;set;}
        public DateTime FechaRevision{get;set;}
        public int IdTecnico{get;set;}
        public int IdVehiculo{get;set;}
        public bool Aceite{get;set;}  
        public bool FiltroAire{get;set;} 
        public bool FiltroGas{get;set;}  
        public string repuestos{get;set;}  
        public void recibirVehiculo(){

        }
        public void facturarRevision(){

        }
        public void asignarTecnico(){

        }
        public void informarCliente(){

        }
        public void entregarVehiculo(){

        }
    }
}