using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EmpleadosFrutas_Avanzado
{
    public partial class Form1 : Form
    {
        ConectarBaseDeDatos conectar = new ConectarBaseDeDatos();
        List<Frutas> lisFrut = new List<Frutas>();
        List<Empleados> lisEmp = new List<Empleados>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("Privilegios");
            comboBox2.Items.Add("Operaciones");
            comboBox2.Items.Add("Disparadores");
            comboBox3.Items.Add("Frutas");
            comboBox3.Items.Add("Empleados");
            dataGridView1.DataSource = lisFrut;
            flp_menuPrincipal.Controls.Add(comboBox3);
            flp_menuPrincipal.Controls.Add(comboBox2);
        }
        public void refrescarVentandaFruta()
        {
            lisFrut.Clear();
            lisEmp.Clear();
            lisFrut = conectar.examinar();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lisFrut;
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            FormInsertar frm = new FormInsertar();
            frm.ShowDialog();
            refrescarVentandaFruta();
        }


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem.ToString() == "Frutas")
            {
                refrescarVentandaFruta();
            }
            else
            {
                refrescarVentandaEmpelado();
            }
        }

        private void refrescarVentandaEmpelado()
        {
            lisFrut.Clear();
            lisEmp.Clear();
            lisEmp = conectar.examinarEMP();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource =lisEmp;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            FormModificar fm=new FormModificar();
            fm.ShowDialog();
            refrescarVentandaFruta();
        }
    }
}
