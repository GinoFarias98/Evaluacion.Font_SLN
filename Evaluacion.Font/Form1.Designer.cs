namespace Evaluacion.Font
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LblNombre = new System.Windows.Forms.Label();
            this.GrpCrearUsuario = new System.Windows.Forms.GroupBox();
            this.BtCrearUsuario = new System.Windows.Forms.Button();
            this.LblProgreso = new System.Windows.Forms.Label();
            this.GrpIngresar = new System.Windows.Forms.GroupBox();
            this.BtIngresar = new System.Windows.Forms.Button();
            this.LblClave = new System.Windows.Forms.Label();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.TxtApll = new System.Windows.Forms.TextBox();
            this.LblApellido = new System.Windows.Forms.Label();
            this.TxtNomb = new System.Windows.Forms.TextBox();
            this.GrpCreacion = new System.Windows.Forms.GroupBox();
            this.LblRepetirClave = new System.Windows.Forms.Label();
            this.BtCrear = new System.Windows.Forms.Button();
            this.TxtClaveRep = new System.Windows.Forms.TextBox();
            this.LblClaveCreacion = new System.Windows.Forms.Label();
            this.TxtClaveC = new System.Windows.Forms.TextBox();
            this.TxtApllC = new System.Windows.Forms.TextBox();
            this.LblApellidoCreacion = new System.Windows.Forms.Label();
            this.TxtNombC = new System.Windows.Forms.TextBox();
            this.LblNombreCreacion = new System.Windows.Forms.Label();
            this.PrgBarProgreso = new System.Windows.Forms.ProgressBar();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.GrpCrearUsuario.SuspendLayout();
            this.GrpIngresar.SuspendLayout();
            this.GrpCreacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(6, 30);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(58, 17);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre";
            // 
            // GrpCrearUsuario
            // 
            this.GrpCrearUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GrpCrearUsuario.Controls.Add(this.BtCrearUsuario);
            this.GrpCrearUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpCrearUsuario.Location = new System.Drawing.Point(57, 12);
            this.GrpCrearUsuario.Name = "GrpCrearUsuario";
            this.GrpCrearUsuario.Size = new System.Drawing.Size(200, 342);
            this.GrpCrearUsuario.TabIndex = 1;
            this.GrpCrearUsuario.TabStop = false;
            this.GrpCrearUsuario.Text = "Crear usuario";
            // 
            // BtCrearUsuario
            // 
            this.BtCrearUsuario.Location = new System.Drawing.Point(64, 123);
            this.BtCrearUsuario.Name = "BtCrearUsuario";
            this.BtCrearUsuario.Size = new System.Drawing.Size(75, 58);
            this.BtCrearUsuario.TabIndex = 7;
            this.BtCrearUsuario.Text = "Crear Usuario";
            this.BtCrearUsuario.UseVisualStyleBackColor = true;
            this.BtCrearUsuario.Click += new System.EventHandler(this.BtCrearUsuario_Click);
            // 
            // LblProgreso
            // 
            this.LblProgreso.AutoSize = true;
            this.LblProgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProgreso.Location = new System.Drawing.Point(89, 42);
            this.LblProgreso.Name = "LblProgreso";
            this.LblProgreso.Size = new System.Drawing.Size(66, 17);
            this.LblProgreso.TabIndex = 5;
            this.LblProgreso.Text = "Progreso";
            this.LblProgreso.Visible = false;
            // 
            // GrpIngresar
            // 
            this.GrpIngresar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GrpIngresar.Controls.Add(this.BtIngresar);
            this.GrpIngresar.Controls.Add(this.LblClave);
            this.GrpIngresar.Controls.Add(this.TxtClave);
            this.GrpIngresar.Controls.Add(this.TxtApll);
            this.GrpIngresar.Controls.Add(this.LblApellido);
            this.GrpIngresar.Controls.Add(this.TxtNomb);
            this.GrpIngresar.Controls.Add(this.LblNombre);
            this.GrpIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpIngresar.Location = new System.Drawing.Point(470, 12);
            this.GrpIngresar.Name = "GrpIngresar";
            this.GrpIngresar.Size = new System.Drawing.Size(200, 342);
            this.GrpIngresar.TabIndex = 2;
            this.GrpIngresar.TabStop = false;
            this.GrpIngresar.Text = "Ingresar";
            // 
            // BtIngresar
            // 
            this.BtIngresar.Location = new System.Drawing.Point(60, 209);
            this.BtIngresar.Name = "BtIngresar";
            this.BtIngresar.Size = new System.Drawing.Size(75, 26);
            this.BtIngresar.TabIndex = 6;
            this.BtIngresar.Text = "Ingresar";
            this.BtIngresar.UseVisualStyleBackColor = true;
            // 
            // LblClave
            // 
            this.LblClave.AutoSize = true;
            this.LblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClave.Location = new System.Drawing.Point(6, 144);
            this.LblClave.Name = "LblClave";
            this.LblClave.Size = new System.Drawing.Size(43, 17);
            this.LblClave.TabIndex = 4;
            this.LblClave.Text = "Clave";
            // 
            // TxtClave
            // 
            this.TxtClave.Location = new System.Drawing.Point(6, 164);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.Size = new System.Drawing.Size(188, 23);
            this.TxtClave.TabIndex = 5;
            // 
            // TxtApll
            // 
            this.TxtApll.Location = new System.Drawing.Point(6, 106);
            this.TxtApll.Name = "TxtApll";
            this.TxtApll.Size = new System.Drawing.Size(188, 23);
            this.TxtApll.TabIndex = 3;
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellido.Location = new System.Drawing.Point(6, 86);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(58, 17);
            this.LblApellido.TabIndex = 2;
            this.LblApellido.Text = "Apellido";
            // 
            // TxtNomb
            // 
            this.TxtNomb.Location = new System.Drawing.Point(6, 50);
            this.TxtNomb.Name = "TxtNomb";
            this.TxtNomb.Size = new System.Drawing.Size(188, 23);
            this.TxtNomb.TabIndex = 1;
            // 
            // GrpCreacion
            // 
            this.GrpCreacion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GrpCreacion.Controls.Add(this.LblRepetirClave);
            this.GrpCreacion.Controls.Add(this.BtCrear);
            this.GrpCreacion.Controls.Add(this.TxtClaveRep);
            this.GrpCreacion.Controls.Add(this.LblClaveCreacion);
            this.GrpCreacion.Controls.Add(this.TxtClaveC);
            this.GrpCreacion.Controls.Add(this.TxtApllC);
            this.GrpCreacion.Controls.Add(this.LblApellidoCreacion);
            this.GrpCreacion.Controls.Add(this.TxtNombC);
            this.GrpCreacion.Controls.Add(this.LblNombreCreacion);
            this.GrpCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpCreacion.Location = new System.Drawing.Point(263, 12);
            this.GrpCreacion.Name = "GrpCreacion";
            this.GrpCreacion.Size = new System.Drawing.Size(201, 342);
            this.GrpCreacion.TabIndex = 3;
            this.GrpCreacion.TabStop = false;
            this.GrpCreacion.Text = "Creacion";
            this.GrpCreacion.Visible = false;
            // 
            // LblRepetirClave
            // 
            this.LblRepetirClave.AutoSize = true;
            this.LblRepetirClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRepetirClave.Location = new System.Drawing.Point(6, 243);
            this.LblRepetirClave.Name = "LblRepetirClave";
            this.LblRepetirClave.Size = new System.Drawing.Size(189, 17);
            this.LblRepetirClave.TabIndex = 6;
            this.LblRepetirClave.Text = "Ingrese la clave nuevamente";
            // 
            // BtCrear
            // 
            this.BtCrear.Location = new System.Drawing.Point(57, 301);
            this.BtCrear.Name = "BtCrear";
            this.BtCrear.Size = new System.Drawing.Size(75, 26);
            this.BtCrear.TabIndex = 6;
            this.BtCrear.Text = "Crear";
            this.BtCrear.UseVisualStyleBackColor = true;
            this.BtCrear.Click += new System.EventHandler(this.BtCrear_Click);
            // 
            // TxtClaveRep
            // 
            this.TxtClaveRep.Location = new System.Drawing.Point(6, 263);
            this.TxtClaveRep.Name = "TxtClaveRep";
            this.TxtClaveRep.Size = new System.Drawing.Size(188, 23);
            this.TxtClaveRep.TabIndex = 7;
            // 
            // LblClaveCreacion
            // 
            this.LblClaveCreacion.AutoSize = true;
            this.LblClaveCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClaveCreacion.Location = new System.Drawing.Point(6, 144);
            this.LblClaveCreacion.Name = "LblClaveCreacion";
            this.LblClaveCreacion.Size = new System.Drawing.Size(43, 17);
            this.LblClaveCreacion.TabIndex = 4;
            this.LblClaveCreacion.Text = "Clave";
            // 
            // TxtClaveC
            // 
            this.TxtClaveC.Location = new System.Drawing.Point(6, 164);
            this.TxtClaveC.Name = "TxtClaveC";
            this.TxtClaveC.Size = new System.Drawing.Size(188, 23);
            this.TxtClaveC.TabIndex = 5;
            // 
            // TxtApllC
            // 
            this.TxtApllC.Location = new System.Drawing.Point(6, 106);
            this.TxtApllC.Name = "TxtApllC";
            this.TxtApllC.Size = new System.Drawing.Size(188, 23);
            this.TxtApllC.TabIndex = 3;
            // 
            // LblApellidoCreacion
            // 
            this.LblApellidoCreacion.AutoSize = true;
            this.LblApellidoCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellidoCreacion.Location = new System.Drawing.Point(6, 86);
            this.LblApellidoCreacion.Name = "LblApellidoCreacion";
            this.LblApellidoCreacion.Size = new System.Drawing.Size(58, 17);
            this.LblApellidoCreacion.TabIndex = 2;
            this.LblApellidoCreacion.Text = "Apellido";
            // 
            // TxtNombC
            // 
            this.TxtNombC.Location = new System.Drawing.Point(6, 50);
            this.TxtNombC.Name = "TxtNombC";
            this.TxtNombC.Size = new System.Drawing.Size(188, 23);
            this.TxtNombC.TabIndex = 1;
            // 
            // LblNombreCreacion
            // 
            this.LblNombreCreacion.AutoSize = true;
            this.LblNombreCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreCreacion.Location = new System.Drawing.Point(6, 30);
            this.LblNombreCreacion.Name = "LblNombreCreacion";
            this.LblNombreCreacion.Size = new System.Drawing.Size(58, 17);
            this.LblNombreCreacion.TabIndex = 0;
            this.LblNombreCreacion.Text = "Nombre";
            // 
            // PrgBarProgreso
            // 
            this.PrgBarProgreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PrgBarProgreso.Location = new System.Drawing.Point(92, 62);
            this.PrgBarProgreso.Name = "PrgBarProgreso";
            this.PrgBarProgreso.Size = new System.Drawing.Size(100, 23);
            this.PrgBarProgreso.TabIndex = 4;
            this.PrgBarProgreso.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblProgreso);
            this.Controls.Add(this.GrpCreacion);
            this.Controls.Add(this.GrpCrearUsuario);
            this.Controls.Add(this.PrgBarProgreso);
            this.Controls.Add(this.GrpIngresar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GrpCrearUsuario.ResumeLayout(false);
            this.GrpIngresar.ResumeLayout(false);
            this.GrpIngresar.PerformLayout();
            this.GrpCreacion.ResumeLayout(false);
            this.GrpCreacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.GroupBox GrpCrearUsuario;
        private System.Windows.Forms.GroupBox GrpIngresar;
        private System.Windows.Forms.TextBox TxtNomb;
        private System.Windows.Forms.Label LblClave;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.TextBox TxtApll;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Button BtIngresar;
        private System.Windows.Forms.Button BtCrearUsuario;
        private System.Windows.Forms.GroupBox GrpCreacion;
        private System.Windows.Forms.Label LblRepetirClave;
        private System.Windows.Forms.Button BtCrear;
        private System.Windows.Forms.TextBox TxtClaveRep;
        private System.Windows.Forms.Label LblClaveCreacion;
        private System.Windows.Forms.TextBox TxtClaveC;
        private System.Windows.Forms.TextBox TxtApllC;
        private System.Windows.Forms.Label LblApellidoCreacion;
        private System.Windows.Forms.TextBox TxtNombC;
        private System.Windows.Forms.Label LblNombreCreacion;
        private System.Windows.Forms.ProgressBar PrgBarProgreso;
        private System.Windows.Forms.Label LblProgreso;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

