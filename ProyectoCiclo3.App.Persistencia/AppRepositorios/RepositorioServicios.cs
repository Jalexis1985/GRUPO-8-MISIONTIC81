using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioServicios
    {
        List<Servicio> servicios;
 
    public RepositorioServicios()
        {
            servicios= new List<Servicio>()
            {
                new Servicio{id=1,origen="Cali",destino= "Tunja", hora= "14:00",fecha= "14/01/2022"},
                new Servicio{id=2,origen="Bogota",destino= "Cali", hora= "7:00",fecha= "15/02/2022"},
                new Servicio{id=3,origen="Tunja",destino= "Tunja", hora= "8:00",fecha= "15/02/2022"}
            };
        }
 
        public IEnumerable<Servicio> GetAll()
        {
            return servicios;
        }
 
        public Servicio GetWithId(int id){
            return servicios.SingleOrDefault(e => e.id == id);
        }
    }
}