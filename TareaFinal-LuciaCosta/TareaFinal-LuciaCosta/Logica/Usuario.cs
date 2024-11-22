using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaFinal_LuciaCosta.Logica
{
    internal class Usuario
    {
        private String nombre_usuario;
        private String contrasenia;

        public Usuario(string nombre_usuario, string contrasenia)
        {
            this.nombre_usuario = nombre_usuario;
            this.contrasenia = contrasenia;
        }
        public string user 
        {  
            get { return nombre_usuario; } 
            set { nombre_usuario = value; }
        }
        public string pass
        {
            get { return contrasenia; }
            set { contrasenia = value; }
        }
        public object[] toObject()
        {
            object [] u = new object[2];
            u[0] = this.nombre_usuario;
            u[1] = this.contrasenia;
            return u;
        }
        
    }
}
