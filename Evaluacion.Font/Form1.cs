using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Evaluacion.Back;

namespace Evaluacion.Font
{
    public partial class FmCearUsuario : Form
    {
        int cod = 0;
        ListaUsuarios Listita = new ListaUsuarios();
        public FmCearUsuario()
        {
            InitializeComponent();
        }
       
        public void BtCrear_Click(object sender, EventArgs e)
        {                       
            if (Validacion()==false )
            {
                errorProvider1.Clear();
                MessageBox.Show("datos cargados correctamente","Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
                Usuario usuario = new Usuario();
                

                usuario.Nombre = TxtNombC.Text.ToLower();
                usuario.Apellido = TxtApllC.Text.ToLower();
                usuario.Clave = TxtClaveC.Text;
                usuario.Codigo = cod;
                cod++;
                TxtNombC.Clear();
                TxtApllC.Clear();
                TxtClaveC.Clear();
                TxtClaveRep.Clear();
                Listita.AgregarUsuario(usuario);
                label1.Text = Listita.Listar();
            }
            else
            {
                
                MessageBox.Show("Ha ocurrido un error. Posicione el cursor encima del icono de advertencia",
                "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }


        public bool Validacion()
        {
            bool Error = false;

            if (String.IsNullOrEmpty(TxtNombC.Text))
            {
                errorProvider1.SetError(TxtNombC, "El campo no puede ser vacio");
                Error = true;
                GrpCreacion.Width = 230;
            }

            else if (string.IsNullOrEmpty(TxtApllC.Text))
            {      
                    errorProvider1.Clear();
                    errorProvider1.SetError(TxtApllC, "campo vacio");
                    Error = true;
                GrpCreacion.Width = 230;

            }

            else if (string.IsNullOrEmpty(TxtClaveC.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(TxtClaveC, "campo vacio");
                Error = true;
                GrpCreacion.Width = 230;

            }
            else if (TxtClaveC.Text!=TxtClaveRep.Text)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(TxtClaveC, "campo vacio");
                Error = true;
                GrpCreacion.Width = 230;

            }
            

            return Error;
        }

        private void BtIngresar_Click(object sender, EventArgs e)
        {
            if (Validacion2()==false)
            {
                if (Listita.Listar().Contains(TxtClave.Text))
                {
                    this.Hide();
                }
                else
                {
                    errorProvider1.SetError(TxtClave, "Error credenciales");
                    GrpIngresar.Width = 230;
                    MessageBox.Show("Ha ocurrido un error. Posicione el cursor encima del icono de advertencia",
                "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error. Posicione el cursor encima del icono de advertencia",
                "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool Validacion2()
        {
            bool EnableBoton = false;
            bool Error2 = false;

            if (String.IsNullOrEmpty(TxtNomb.Text))
            {
                errorProvider1.SetError(TxtNomb, "El campo no puede ser vacio");
                Error2 = true;
                GrpIngresar.Width = 230;
            }
            else if (string.IsNullOrEmpty(TxtApll.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(TxtApll, "campo vacio");
                Error2 = true;
                GrpIngresar.Width = 230;

            }
            else if (string.IsNullOrEmpty(TxtClave.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(TxtClave, "campo vacio");
                Error2 = true;
                GrpIngresar.Width = 230;
                
            }
            else if(Listita.Listar().Contains(TxtClave.Text))
            {
                EnableBoton = true;
            }

           
            return Error2;  
        }

        private void BtCrear10_Click(object sender, EventArgs e)
        {
            GrpCrear10.Visible = false;
            GrpIngresar10.Visible = false;
            GrpCreacion.Visible = true;
            GrpCreacion.Top = GrpCrear10.Top;
            GrpCreacion.Left = GrpCrear10.Left;
        }

        private void BtIngresar10_Click(object sender, EventArgs e)
        {
            GrpCrear10.Visible = false;
            GrpIngresar10.Visible = false;
            GrpIngresar.Visible = true;
            GrpIngresar.Top = GrpIngresar10.Top;
            GrpIngresar.Left = GrpIngresar10.Left;
        }

        private void BtRegresarCrear_Click(object sender, EventArgs e)
        {
            GrpCrear10.Visible = true;
            GrpIngresar10.Visible = true;
            GrpCreacion.Visible = false;

        }

        private void BtRegresarIngresar_Click(object sender, EventArgs e)
        {
            GrpCrear10.Visible = true;
            GrpIngresar10.Visible = true;
            GrpIngresar.Visible = false;
        }

        //incorporar progres bar para ver la seguridad de la clave si es debill o no
    }
}
