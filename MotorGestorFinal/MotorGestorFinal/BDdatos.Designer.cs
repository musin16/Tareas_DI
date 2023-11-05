namespace MotorGestorFinal
{
    partial class BDdatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BaseDatos = new System.Windows.Forms.ListBox();
            this.Tablas = new System.Windows.Forms.ListBox();
            this.Atributos = new System.Windows.Forms.ListBox();
            this.Campos = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BaseDatos
            // 
            this.BaseDatos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BaseDatos.FormattingEnabled = true;
            this.BaseDatos.ItemHeight = 16;
            this.BaseDatos.Location = new System.Drawing.Point(15, 9);
            this.BaseDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BaseDatos.Name = "BaseDatos";
            this.BaseDatos.Size = new System.Drawing.Size(191, 340);
            this.BaseDatos.TabIndex = 0;
            this.BaseDatos.SelectedIndexChanged += new System.EventHandler(this.BaseDatos_SelectedIndexChanged);
            // 
            // Tablas
            // 
            this.Tablas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Tablas.FormattingEnabled = true;
            this.Tablas.ItemHeight = 16;
            this.Tablas.Location = new System.Drawing.Point(237, 9);
            this.Tablas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tablas.Name = "Tablas";
            this.Tablas.Size = new System.Drawing.Size(181, 340);
            this.Tablas.TabIndex = 1;
            this.Tablas.Visible = false;
            this.Tablas.SelectedIndexChanged += new System.EventHandler(this.Tablas_SelectedIndexChanged);
            // 
            // Atributos
            // 
            this.Atributos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Atributos.FormattingEnabled = true;
            this.Atributos.ItemHeight = 16;
            this.Atributos.Location = new System.Drawing.Point(663, 9);
            this.Atributos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Atributos.Name = "Atributos";
            this.Atributos.Size = new System.Drawing.Size(191, 340);
            this.Atributos.TabIndex = 2;
            this.Atributos.Visible = false;
            // 
            // Campos
            // 
            this.Campos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Campos.FormattingEnabled = true;
            this.Campos.ItemHeight = 16;
            this.Campos.Location = new System.Drawing.Point(439, 9);
            this.Campos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Campos.Name = "Campos";
            this.Campos.Size = new System.Drawing.Size(191, 340);
            this.Campos.TabIndex = 3;
            this.Campos.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSalir.Location = new System.Drawing.Point(15, 387);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(191, 43);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnExportarEspecifico_Click);
            // 
            // BDdatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MotorGestorFinal.Properties.Resources.oscuridad;
            this.ClientSize = new System.Drawing.Size(1048, 554);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.Campos);
            this.Controls.Add(this.Atributos);
            this.Controls.Add(this.Tablas);
            this.Controls.Add(this.BaseDatos);
            this.Location = new System.Drawing.Point(400, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BDdatos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BDdatos";
            this.Load += new System.EventHandler(this.BDdatos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox BaseDatos;
        private System.Windows.Forms.ListBox Tablas;
        private System.Windows.Forms.ListBox Atributos;
        private System.Windows.Forms.ListBox Campos;
        private System.Windows.Forms.Button btnSalir;
    }
}