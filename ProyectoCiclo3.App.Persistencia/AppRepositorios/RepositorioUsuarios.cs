using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioUsuarios
    {
        List<Usuario> usuarios;
 
    public RepositorioUsuarios()
        {
            usuarios= new List<Usuario>()
            {
                new Usuario{id=1,nombres="David Alexis",apellidos= "Peña Cruz", direccion= "Calle 4 # 3-27",telefono= "315698633"},
                new Usuario{id=2,nombres="Nicol Stefania",apellidos= "Peña Cruz", direccion= "Calle 3 # 5-36",telefono= "59865325"},
                new Usuario{id=3,nombres="Luciana Salome",apellidos= "Peña cruz", direccion= "Calle 2 # 8-65",telefono= "325489632"}
            };
        }
 
        public IEnumerable<Usuario> GetAll()
        {
            return usuarios;
        }
 
        public Usuario GetWithId(int id){
            return usuarios.SingleOrDefault(e => e.id == id);
        }
    }
}