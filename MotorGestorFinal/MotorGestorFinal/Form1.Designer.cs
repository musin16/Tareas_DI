namespace MotorGestorFinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtBaseDatos = new System.Windows.Forms.TextBox();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnContraseña = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnBaseDatos = new System.Windows.Forms.Button();
            this.btn_Server = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.listBD = new System.Windows.Forms.ListBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnImportarConetido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtConsulta
            // 
            resources.ApplyResources(this.txtConsulta, "txtConsulta");
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsulta_KeyPress);
            // 
            // txtContra
            // 
            resources.ApplyResources(this.txtContra, "txtContra");
            this.txtContra.Name = "txtContra";
            this.txtContra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContra_KeyPress);
            // 
            // txtUsuario
            // 
            resources.ApplyResources(this.txtUsuario, "txtUsuario");
            this.txtUsuario.Name = "txtUsuario";
            // 
            // txtBaseDatos
            // 
            resources.ApplyResources(this.txtBaseDatos, "txtBaseDatos");
            this.txtBaseDatos.Name = "txtBaseDatos";
            // 
            // txtServidor
            // 
            resources.ApplyResources(this.txtServidor, "txtServidor");
            this.txtServidor.Name = "txtServidor";
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnConsulta, "btnConsulta");
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnContraseña
            // 
            this.btnContraseña.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnContraseña, "btnContraseña");
            this.btnContraseña.Name = "btnContraseña";
            this.btnContraseña.UseVisualStyleBackColor = false;
            this.btnContraseña.Click += new System.EventHandler(this.btnContraseña_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnUsuario, "btnUsuario");
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnBaseDatos
            // 
            this.btnBaseDatos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnBaseDatos, "btnBaseDatos");
            this.btnBaseDatos.Name = "btnBaseDatos";
            this.btnBaseDatos.UseVisualStyleBackColor = false;
            this.btnBaseDatos.Click += new System.EventHandler(this.btnBaseDatos_Click);
            // 
            // btn_Server
            // 
            this.btn_Server.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btn_Server, "btn_Server");
            this.btn_Server.Name = "btn_Server";
            this.btn_Server.UseVisualStyleBackColor = false;
            this.btn_Server.Click += new System.EventHandler(this.btn_Server_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnSalir, "btnSalir");
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // listBD
            // 
            this.listBD.BackColor = System.Drawing.SystemColors.Info;
            this.listBD.FormattingEnabled = true;
            resources.ApplyResources(this.listBD, "listBD");
            this.listBD.Name = "listBD";
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnMostrar, "btnMostrar");
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnExportar, "btnExportar");
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnImportar, "btnImportar");
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.UseVisualStyleBackColor = false;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnImportarConetido
            // 
            this.btnImportarConetido.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnImportarConetido, "btnImportarConetido");
            this.btnImportarConetido.Name = "btnImportarConetido";
            this.btnImportarConetido.UseVisualStyleBackColor = false;
            this.btnImportarConetido.Click += new System.EventHandler(this.btnImportarConetido_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::MotorGestorFinal.Properties.Resources.dataBISE;
            this.Controls.Add(this.btnImportarConetido);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.listBD);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtBaseDatos);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnContraseña);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnBaseDatos);
            this.Controls.Add(this.btn_Server);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtBaseDatos;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnContraseña;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnBaseDatos;
        private System.Windows.Forms.Button btn_Server;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox listBD;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnImportarConetido;
    }
}

