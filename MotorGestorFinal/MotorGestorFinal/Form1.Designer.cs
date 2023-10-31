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
            this.SuspendLayout();
            // 
            // txtConsulta
            // 
            this.txtConsulta.Enabled = false;
            this.txtConsulta.Location = new System.Drawing.Point(63, 286);
            this.txtConsulta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(715, 26);
            this.txtConsulta.TabIndex = 19;
            this.txtConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsulta_KeyPress);
            // 
            // txtContra
            // 
            this.txtContra.Enabled = false;
            this.txtContra.Location = new System.Drawing.Point(634, 137);
            this.txtContra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(144, 26);
            this.txtContra.TabIndex = 18;
            this.txtContra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContra_KeyPress);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(446, 137);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(144, 26);
            this.txtUsuario.TabIndex = 17;
            this.txtUsuario.Text = "root";
            // 
            // txtBaseDatos
            // 
            this.txtBaseDatos.Enabled = false;
            this.txtBaseDatos.Location = new System.Drawing.Point(255, 137);
            this.txtBaseDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBaseDatos.Name = "txtBaseDatos";
            this.txtBaseDatos.Size = new System.Drawing.Size(142, 26);
            this.txtBaseDatos.TabIndex = 16;
            this.txtBaseDatos.Text = "dam2023";
            // 
            // txtServidor
            // 
            this.txtServidor.Enabled = false;
            this.txtServidor.Location = new System.Drawing.Point(63, 137);
            this.txtServidor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(144, 26);
            this.txtServidor.TabIndex = 15;
            this.txtServidor.Text = "localhost";
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConsulta.Location = new System.Drawing.Point(334, 192);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(146, 63);
            this.btnConsulta.TabIndex = 14;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnContraseña
            // 
            this.btnContraseña.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnContraseña.Location = new System.Drawing.Point(634, 42);
            this.btnContraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnContraseña.Name = "btnContraseña";
            this.btnContraseña.Size = new System.Drawing.Size(146, 63);
            this.btnContraseña.TabIndex = 13;
            this.btnContraseña.Text = "Contraseña";
            this.btnContraseña.UseVisualStyleBackColor = false;
            this.btnContraseña.Click += new System.EventHandler(this.btnContraseña_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUsuario.Location = new System.Drawing.Point(446, 45);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(146, 63);
            this.btnUsuario.TabIndex = 12;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnBaseDatos
            // 
            this.btnBaseDatos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBaseDatos.Location = new System.Drawing.Point(255, 42);
            this.btnBaseDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBaseDatos.Name = "btnBaseDatos";
            this.btnBaseDatos.Size = new System.Drawing.Size(146, 63);
            this.btnBaseDatos.TabIndex = 11;
            this.btnBaseDatos.Text = "BD";
            this.btnBaseDatos.UseVisualStyleBackColor = false;
            this.btnBaseDatos.Click += new System.EventHandler(this.btnBaseDatos_Click);
            // 
            // btn_Server
            // 
            this.btn_Server.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Server.Location = new System.Drawing.Point(63, 42);
            this.btn_Server.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Server.Name = "btn_Server";
            this.btn_Server.Size = new System.Drawing.Size(146, 63);
            this.btn_Server.TabIndex = 10;
            this.btn_Server.Text = "Servidor";
            this.btn_Server.UseVisualStyleBackColor = false;
            this.btn_Server.Click += new System.EventHandler(this.btn_Server_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalir.Location = new System.Drawing.Point(812, 42);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(146, 63);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // listBD
            // 
            this.listBD.FormattingEnabled = true;
            this.listBD.ItemHeight = 20;
            this.listBD.Location = new System.Drawing.Point(812, 137);
            this.listBD.Name = "listBD";
            this.listBD.Size = new System.Drawing.Size(246, 184);
            this.listBD.TabIndex = 23;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMostrar.Location = new System.Drawing.Point(63, 335);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(108, 44);
            this.btnMostrar.TabIndex = 24;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 692);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

