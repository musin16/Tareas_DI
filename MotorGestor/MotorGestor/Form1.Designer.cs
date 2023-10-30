namespace MotorGestor
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
            this.btn_Server = new System.Windows.Forms.Button();
            this.btnBaseDatos = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnContraseña = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.txtBaseDatos = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Server
            // 
            this.btn_Server.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Server.Location = new System.Drawing.Point(80, 72);
            this.btn_Server.Name = "btn_Server";
            this.btn_Server.Size = new System.Drawing.Size(111, 41);
            this.btn_Server.TabIndex = 0;
            this.btn_Server.Text = "Servidor";
            this.btn_Server.UseVisualStyleBackColor = false;
            this.btn_Server.Click += new System.EventHandler(this.btn_Server_Click);
            // 
            // btnBaseDatos
            // 
            this.btnBaseDatos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBaseDatos.Location = new System.Drawing.Point(208, 72);
            this.btnBaseDatos.Name = "btnBaseDatos";
            this.btnBaseDatos.Size = new System.Drawing.Size(111, 41);
            this.btnBaseDatos.TabIndex = 1;
            this.btnBaseDatos.Text = "BD";
            this.btnBaseDatos.UseVisualStyleBackColor = false;
            this.btnBaseDatos.Click += new System.EventHandler(this.btnBaseDatos_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUsuario.Location = new System.Drawing.Point(335, 74);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(111, 41);
            this.btnUsuario.TabIndex = 2;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnContraseña
            // 
            this.btnContraseña.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnContraseña.Location = new System.Drawing.Point(461, 72);
            this.btnContraseña.Name = "btnContraseña";
            this.btnContraseña.Size = new System.Drawing.Size(111, 41);
            this.btnContraseña.TabIndex = 3;
            this.btnContraseña.Text = "Contraseña";
            this.btnContraseña.UseVisualStyleBackColor = false;
            this.btnContraseña.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConsulta.Location = new System.Drawing.Point(261, 170);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(111, 41);
            this.btnConsulta.TabIndex = 4;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = false;
            // 
            // txtServidor
            // 
            this.txtServidor.Enabled = false;
            this.txtServidor.Location = new System.Drawing.Point(80, 134);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(111, 20);
            this.txtServidor.TabIndex = 5;
            // 
            // txtBaseDatos
            // 
            this.txtBaseDatos.Enabled = false;
            this.txtBaseDatos.Location = new System.Drawing.Point(208, 134);
            this.txtBaseDatos.Name = "txtBaseDatos";
            this.txtBaseDatos.Size = new System.Drawing.Size(110, 20);
            this.txtBaseDatos.TabIndex = 6;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(335, 134);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(111, 20);
            this.txtUsuario.TabIndex = 7;
            // 
            // txtContra
            // 
            this.txtContra.Enabled = false;
            this.txtContra.Location = new System.Drawing.Point(461, 134);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(111, 20);
            this.txtContra.TabIndex = 8;
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(65, 231);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(528, 20);
            this.txtConsulta.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(662, 450);
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
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Server;
        private System.Windows.Forms.Button btnBaseDatos;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnContraseña;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.TextBox txtBaseDatos;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtConsulta;
    }
}

