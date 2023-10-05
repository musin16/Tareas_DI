namespace EmpleadosFrutas_Avanzado
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
            this.flp_menuPrincipal = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_sql = new System.Windows.Forms.Button();
            this.btn_buscarConsulta = new System.Windows.Forms.Button();
            this.btn_insertar = new System.Windows.Forms.Button();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.btn_importar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flp_menuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flp_menuPrincipal
            // 
            this.flp_menuPrincipal.Controls.Add(this.comboBox3);
            this.flp_menuPrincipal.Controls.Add(this.comboBox2);
            this.flp_menuPrincipal.Controls.Add(this.btn_modificar);
            this.flp_menuPrincipal.Controls.Add(this.btn_sql);
            this.flp_menuPrincipal.Controls.Add(this.btn_buscarConsulta);
            this.flp_menuPrincipal.Controls.Add(this.btn_insertar);
            this.flp_menuPrincipal.Controls.Add(this.btn_exportar);
            this.flp_menuPrincipal.Controls.Add(this.btn_importar);
            this.flp_menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.flp_menuPrincipal.Name = "flp_menuPrincipal";
            this.flp_menuPrincipal.Size = new System.Drawing.Size(949, 53);
            this.flp_menuPrincipal.TabIndex = 0;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(3, 3);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 32);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(130, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 32);
            this.comboBox2.TabIndex = 8;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(257, 3);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(116, 44);
            this.btn_modificar.TabIndex = 1;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_sql
            // 
            this.btn_sql.Location = new System.Drawing.Point(379, 3);
            this.btn_sql.Name = "btn_sql";
            this.btn_sql.Size = new System.Drawing.Size(97, 44);
            this.btn_sql.TabIndex = 2;
            this.btn_sql.Text = "SQL";
            this.btn_sql.UseVisualStyleBackColor = true;
            // 
            // btn_buscarConsulta
            // 
            this.btn_buscarConsulta.Location = new System.Drawing.Point(482, 3);
            this.btn_buscarConsulta.Name = "btn_buscarConsulta";
            this.btn_buscarConsulta.Size = new System.Drawing.Size(97, 44);
            this.btn_buscarConsulta.TabIndex = 3;
            this.btn_buscarConsulta.Text = "Buscar";
            this.btn_buscarConsulta.UseVisualStyleBackColor = true;
            // 
            // btn_insertar
            // 
            this.btn_insertar.Location = new System.Drawing.Point(585, 3);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(97, 44);
            this.btn_insertar.TabIndex = 4;
            this.btn_insertar.Text = "Insertar";
            this.btn_insertar.UseVisualStyleBackColor = true;
            this.btn_insertar.Click += new System.EventHandler(this.btn_insertar_Click);
            // 
            // btn_exportar
            // 
            this.btn_exportar.Location = new System.Drawing.Point(688, 3);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(97, 44);
            this.btn_exportar.TabIndex = 5;
            this.btn_exportar.Text = "Exportar";
            this.btn_exportar.UseVisualStyleBackColor = true;
            // 
            // btn_importar
            // 
            this.btn_importar.Location = new System.Drawing.Point(791, 3);
            this.btn_importar.Name = "btn_importar";
            this.btn_importar.Size = new System.Drawing.Size(97, 44);
            this.btn_importar.TabIndex = 6;
            this.btn_importar.Text = "Importar";
            this.btn_importar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(885, 379);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flp_menuPrincipal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flp_menuPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_menuPrincipal;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_sql;
        private System.Windows.Forms.Button btn_buscarConsulta;
        private System.Windows.Forms.Button btn_insertar;
        private System.Windows.Forms.Button btn_exportar;
        private System.Windows.Forms.Button btn_importar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}

