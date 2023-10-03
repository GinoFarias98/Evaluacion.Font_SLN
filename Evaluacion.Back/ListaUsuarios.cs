using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion.Back
{
    public class ListaUsuarios
    {

        public Usuario[] Lista { get; set; } = new Usuario[10];
        int fila = 0;
        public void AgregarUsuario(Usuario dato)
        {
            Lista[fila] = dato;
            fila++;

        }
        
        public string Listar()
        {
            string respuesta = string.Empty;

            foreach (Usuario dato in Lista)
            {
                if (dato == null)
                {
                    break;
                }
                respuesta = respuesta + dato.Listar() + "\r\n";

            }

            return respuesta;
        }
    }
}
