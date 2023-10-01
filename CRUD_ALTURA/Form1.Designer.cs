namespace CRUD_ALTURA
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_insertar = new System.Windows.Forms.Button();
            this.tbAlturaMax = new System.Windows.Forms.TextBox();
            this.tbAlturaMin = new System.Windows.Forms.TextBox();
            this.tbProvincia = new System.Windows.Forms.TextBox();
            this.tbSituacionMax = new System.Windows.Forms.TextBox();
            this.tbSituacionMin = new System.Windows.Forms.TextBox();
            this.lbl_provincia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(133, 19);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(626, 169);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_insertar
            // 
            this.btn_insertar.Location = new System.Drawing.Point(133, 226);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(113, 60);
            this.btn_insertar.TabIndex = 1;
            this.btn_insertar.Text = "Insertar";
            this.btn_insertar.UseVisualStyleBackColor = true;
            this.btn_insertar.Click += new System.EventHandler(this.btn_insertar_Click);
            // 
            // tbAlturaMax
            // 
            this.tbAlturaMax.Location = new System.Drawing.Point(388, 323);
            this.tbAlturaMax.Name = "tbAlturaMax";
            this.tbAlturaMax.Size = new System.Drawing.Size(159, 26);
            this.tbAlturaMax.TabIndex = 2;
            // 
            // tbAlturaMin
            // 
            this.tbAlturaMin.Location = new System.Drawing.Point(388, 439);
            this.tbAlturaMin.Name = "tbAlturaMin";
            this.tbAlturaMin.Size = new System.Drawing.Size(159, 26);
            this.tbAlturaMin.TabIndex = 3;
            // 
            // tbProvincia
            // 
            this.tbProvincia.Location = new System.Drawing.Point(388, 213);
            this.tbProvincia.Name = "tbProvincia";
            this.tbProvincia.Size = new System.Drawing.Size(159, 26);
            this.tbProvincia.TabIndex = 4;
            // 
            // tbSituacionMax
            // 
            this.tbSituacionMax.Location = new System.Drawing.Point(388, 269);
            this.tbSituacionMax.Name = "tbSituacionMax";
            this.tbSituacionMax.Size = new System.Drawing.Size(159, 26);
            this.tbSituacionMax.TabIndex = 5;
            // 
            // tbSituacionMin
            // 
            this.tbSituacionMin.Location = new System.Drawing.Point(388, 383);
            this.tbSituacionMin.Name = "tbSituacionMin";
            this.tbSituacionMin.Size = new System.Drawing.Size(159, 26);
            this.tbSituacionMin.TabIndex = 6;
            // 
            // lbl_provincia
            // 
            this.lbl_provincia.AutoSize = true;
            this.lbl_provincia.Location = new System.Drawing.Point(384, 190);
            this.lbl_provincia.Name = "lbl_provincia";
            this.lbl_provincia.Size = new System.Drawing.Size(72, 20);
            this.lbl_provincia.TabIndex = 7;
            this.lbl_provincia.Text = "Provincia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "SituacionMax";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "AlturaMax";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "SituacionMin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "AlturaMin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 551);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_provincia);
            this.Controls.Add(this.tbSituacionMin);
            this.Controls.Add(this.tbSituacionMax);
            this.Controls.Add(this.tbProvincia);
            this.Controls.Add(this.tbAlturaMin);
            this.Controls.Add(this.tbAlturaMax);
            this.Controls.Add(this.btn_insertar);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_insertar;
        private System.Windows.Forms.TextBox tbAlturaMax;
        private System.Windows.Forms.TextBox tbAlturaMin;
        private System.Windows.Forms.TextBox tbProvincia;
        private System.Windows.Forms.TextBox tbSituacionMax;
        private System.Windows.Forms.TextBox tbSituacionMin;
        private System.Windows.Forms.Label lbl_provincia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

