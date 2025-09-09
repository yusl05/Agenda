using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Utilidades
{
    public class Persona
    {
        public String nombre { get; set; }
        public String apPat { get; set; }
        public String apMat { get; set; }
        public String direccion { get; set; }
        public String telefono { get; set; }
        public String correo { get; set; }

        public Persona(string nombre, string apPat, string apMat, string direccion, string telefono, string correo)
        {
            this.nombre = nombre;
            this.apPat = apPat;
            this.apMat = apMat;
            this.direccion = direccion;
            this.telefono = telefono;
            this.correo = correo;
        }

        public Persona()
        {

        }
    }
}
