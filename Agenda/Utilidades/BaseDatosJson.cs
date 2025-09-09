using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Utilidades
{
    public class BaseDatosJson
    {
        public List<Persona> personas { get; set; }

        public DateTime actualizacion { get; set; }

        public int totalRegistros { get; set; }

        public BaseDatosJson() {
            personas = new List<Persona>();
            actualizacion = DateTime.Now; 
        }  

    }
}
