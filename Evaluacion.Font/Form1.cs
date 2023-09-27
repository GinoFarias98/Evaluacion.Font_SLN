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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void BtCrearUsuario_Click(object sender, EventArgs e)
        {           
            GrpCrearUsuario.Visible = false;
            GrpBtIngresar.Visible = false;
            GrpCreacion.Visible = true;

            GrpCreacion.Top = GrpCrearUsuario.Top;
            GrpCreacion.Left = GrpCrearUsuario.Left;


        }

        
        public void BtCrear_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            string Error = "";
            
            if (TxtNombC==null)
            {
                Error = 1;
            }
            if (TxtApllC == null)
            {
                Error = true;
            }
            if (TxtClaveC != TxtClaveRep)
            {
                Error = true;
            }

            switch ()
            {
                case TxtClaveC.Text:
                    errorProvider2.SetError(TxtNombC, "Campo incompleto");                  
                    GrpCreacion.Width = 220;
                    break;
                case false:
                    errorProvider3.SetError(TxtApllC, "Campo incompleto");
                    GrpCreacion.Width = 220;
                    break;
                case TxtClaveC.Text != TxtClaveRep:Text:
                    errorProvider1.SetError(TxtClaveC, "La contraseña debe ser la misma en ambos campos");
                    GrpCreacion.Width = 220;
                    break;
                    
                default:
                    Error = false;
                    break; 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GrpCrearUsuario.Visible = false;
            GrpBtIngresar.Visible = false;
            GrpIngresar.Visible = true;

            GrpIngresar.Top = GrpBtIngresar.Top;
            GrpIngresar.Left = GrpBtIngresar.Left;

        }

        private void BtRegresarCrear_Click(object sender, EventArgs e)
        {
            GrpCrearUsuario.Visible = true;
            GrpBtIngresar.Visible = true;
            GrpCreacion.Visible = false;
        }

        private void BtRegresarIngresar_Click(object sender, EventArgs e)
        {
            GrpCrearUsuario.Visible = true;
            GrpBtIngresar.Visible = true;
            GrpIngresar.Visible = false;
        }

        //incorporar progres bar para ver la seguridad de la clave si es debill o no
    }
}
