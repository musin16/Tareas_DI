﻿namespace MotorGestorFinal
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(27, 186);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(514, 20);
            this.txtConsulta.TabIndex = 19;
            // 
            // txtContra
            // 
            this.txtContra.Enabled = false;
            this.txtContra.Location = new System.Drawing.Point(423, 89);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(97, 20);
            this.txtContra.TabIndex = 18;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(297, 89);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(97, 20);
            this.txtUsuario.TabIndex = 17;
            // 
            // txtBaseDatos
            // 
            this.txtBaseDatos.Enabled = false;
            this.txtBaseDatos.Location = new System.Drawing.Point(170, 89);
            this.txtBaseDatos.Name = "txtBaseDatos";
            this.txtBaseDatos.Size = new System.Drawing.Size(96, 20);
            this.txtBaseDatos.TabIndex = 16;
            // 
            // txtServidor
            // 
            this.txtServidor.Enabled = false;
            this.txtServidor.Location = new System.Drawing.Point(42, 89);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(97, 20);
            this.txtServidor.TabIndex = 15;
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConsulta.Location = new System.Drawing.Point(223, 125);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(97, 41);
            this.btnConsulta.TabIndex = 14;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = false;
            // 
            // btnContraseña
            // 
            this.btnContraseña.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnContraseña.Location = new System.Drawing.Point(423, 27);
            this.btnContraseña.Name = "btnContraseña";
            this.btnContraseña.Size = new System.Drawing.Size(97, 41);
            this.btnContraseña.TabIndex = 13;
            this.btnContraseña.Text = "Contraseña";
            this.btnContraseña.UseVisualStyleBackColor = false;
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUsuario.Location = new System.Drawing.Point(297, 29);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(97, 41);
            this.btnUsuario.TabIndex = 12;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.UseVisualStyleBackColor = false;
            // 
            // btnBaseDatos
            // 
            this.btnBaseDatos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBaseDatos.Location = new System.Drawing.Point(170, 27);
            this.btnBaseDatos.Name = "btnBaseDatos";
            this.btnBaseDatos.Size = new System.Drawing.Size(97, 41);
            this.btnBaseDatos.TabIndex = 11;
            this.btnBaseDatos.Text = "BD";
            this.btnBaseDatos.UseVisualStyleBackColor = false;
            // 
            // btn_Server
            // 
            this.btn_Server.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Server.Location = new System.Drawing.Point(42, 27);
            this.btn_Server.Name = "btn_Server";
            this.btn_Server.Size = new System.Drawing.Size(97, 41);
            this.btn_Server.TabIndex = 10;
            this.btn_Server.Text = "Servidor";
            this.btn_Server.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(384, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalir.Location = new System.Drawing.Point(541, 27);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 41);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSalir;
    }
}

