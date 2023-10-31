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
            this.SuspendLayout();
            // 
            // BaseDatos
            // 
            this.BaseDatos.FormattingEnabled = true;
            this.BaseDatos.ItemHeight = 20;
            this.BaseDatos.Location = new System.Drawing.Point(33, 11);
            this.BaseDatos.Name = "BaseDatos";
            this.BaseDatos.Size = new System.Drawing.Size(332, 424);
            this.BaseDatos.TabIndex = 0;
            this.BaseDatos.SelectedIndexChanged += new System.EventHandler(this.BaseDatos_SelectedIndexChanged);
            // 
            // Tablas
            // 
            this.Tablas.FormattingEnabled = true;
            this.Tablas.ItemHeight = 20;
            this.Tablas.Location = new System.Drawing.Point(382, 11);
            this.Tablas.Name = "Tablas";
            this.Tablas.Size = new System.Drawing.Size(332, 424);
            this.Tablas.TabIndex = 1;
            this.Tablas.SelectedIndexChanged += new System.EventHandler(this.Tablas_SelectedIndexChanged);
            // 
            // Atributos
            // 
            this.Atributos.FormattingEnabled = true;
            this.Atributos.ItemHeight = 20;
            this.Atributos.Location = new System.Drawing.Point(738, 11);
            this.Atributos.Name = "Atributos";
            this.Atributos.Size = new System.Drawing.Size(332, 424);
            this.Atributos.TabIndex = 2;
            // 
            // BDdatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 478);
            this.Controls.Add(this.Atributos);
            this.Controls.Add(this.Tablas);
            this.Controls.Add(this.BaseDatos);
            this.Name = "BDdatos";
            this.Text = "BDdatos";
            this.Load += new System.EventHandler(this.BDdatos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox BaseDatos;
        private System.Windows.Forms.ListBox Tablas;
        private System.Windows.Forms.ListBox Atributos;
    }
}