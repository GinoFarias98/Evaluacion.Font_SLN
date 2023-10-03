using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion.Back
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Clave { get; set; }
        public int Codigo { get; set; }

       

        public string Listar()
        {
            string respuesta = Nombre + " - " + Apellido + " - " + Clave + " - " + Codigo;

            return respuesta;

        }

    }
}
