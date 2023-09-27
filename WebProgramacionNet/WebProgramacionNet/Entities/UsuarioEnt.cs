using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace WebProgramacionNet.Entities
{
    public class UsuarioEnt
    {

        // Propiedad con un tipo de dato y nombre
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }

    }
}