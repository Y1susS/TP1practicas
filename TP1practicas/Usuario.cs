using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1practicas
{
    internal class Usuario
    {
        public string NombreUsuario {get; set;}
        public string Contraseña {get; set;}
        public string Tipo {get; set;} 

        public Usuario(string nombreUsuario, string contraseña, string tipo)
        {
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
            Tipo = tipo;
        }
    }
}
