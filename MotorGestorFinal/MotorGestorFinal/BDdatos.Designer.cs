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
            this.SuspendLayout();
            // 
            // BaseDatos
            // 
            this.BaseDatos.FormattingEnabled = true;
            this.BaseDatos.Location = new System.Drawing.Point(11, 7);
            this.BaseDatos.Margin = new System.Windows.Forms.Padding(2);
            this.BaseDatos.Name = "BaseDatos";
            this.BaseDatos.Size = new System.Drawing.Size(144, 277);
            this.BaseDatos.TabIndex = 0;
            this.BaseDatos.SelectedIndexChanged += new System.EventHandler(this.BaseDatos_SelectedIndexChanged);
            // 
            // Tablas
            // 
            this.Tablas.FormattingEnabled = true;
            this.Tablas.Location = new System.Drawing.Point(178, 7);
            this.Tablas.Margin = new System.Windows.Forms.Padding(2);
            this.Tablas.Name = "Tablas";
            this.Tablas.Size = new System.Drawing.Size(137, 277);
            this.Tablas.TabIndex = 1;
            this.Tablas.Visible = false;
            this.Tablas.SelectedIndexChanged += new System.EventHandler(this.Tablas_SelectedIndexChanged);
            // 
            // Atributos
            // 
            this.Atributos.FormattingEnabled = true;
            this.Atributos.Location = new System.Drawing.Point(497, 7);
            this.Atributos.Margin = new System.Windows.Forms.Padding(2);
            this.Atributos.Name = "Atributos";
            this.Atributos.Size = new System.Drawing.Size(144, 277);
            this.Atributos.TabIndex = 2;
            this.Atributos.Visible = false;
            // 
            // Campos
            // 
            this.Campos.FormattingEnabled = true;
            this.Campos.Location = new System.Drawing.Point(329, 7);
            this.Campos.Margin = new System.Windows.Forms.Padding(2);
            this.Campos.Name = "Campos";
            this.Campos.Size = new System.Drawing.Size(144, 277);
            this.Campos.TabIndex = 3;
            this.Campos.Visible = false;
            // 
            // BDdatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 353);
            this.Controls.Add(this.Campos);
            this.Controls.Add(this.Atributos);
            this.Controls.Add(this.Tablas);
            this.Controls.Add(this.BaseDatos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BDdatos";
            this.Text = "BDdatos";
            this.Load += new System.EventHandler(this.BDdatos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox BaseDatos;
        private System.Windows.Forms.ListBox Tablas;
        private System.Windows.Forms.ListBox Atributos;
        private System.Windows.Forms.ListBox Campos;
    }
}