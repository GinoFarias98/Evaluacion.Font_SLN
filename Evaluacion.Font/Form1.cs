using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Evaluacion.Back;

namespace Evaluacion.Font
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void BtCrearUsuario_Click(object sender, EventArgs e)
        {
            GrpIngresar.Visible = false;
            GrpCreacion.Visible = true;
            GrpCrearUsuario.Visible = false;
            LblProgreso.Visible = true;
            PrgBarProgreso.Visible = true;
            if (TxtNombC.Text != null)
            {
                PrgBarProgreso.Value = 33;

            }

            if (TxtApllC.Text != null)
            {
                PrgBarProgreso.Value = 67;

            }
            if (TxtClaveC.Text != null)
            {
                PrgBarProgreso.Value = 100;

            }

        }
            
    public void BtCrear_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            bool Error = false;

            if (TxtClaveC.Text!=TxtClaveRep.Text)
            {
                Error = true;
            }
            else
            {
                GrpCreacion.Visible = false;
                GrpIngresar.Visible = true;

                usuario.Nombre = TxtNombC.Text;
                usuario.Apellido = TxtApllC.Text;
                usuario.Clave = TxtClave.Text;
                LblProgreso.Visible = false;
                PrgBarProgreso.Visible = false;
                errorProvider1.Clear();
            }
            if (Error)
            {
                errorProvider1.SetError(TxtClaveC, "La contraseña debe ser la misma en ambos campos");
            }
        }

       
    }
}
