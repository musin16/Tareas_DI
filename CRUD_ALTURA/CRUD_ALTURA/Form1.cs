using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_ALTURA
{
    public partial class Form1 : Form
    {
        ConectarBd c=new ConectarBd();
        public Form1()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
                dataGridView1.DataSource = c.consultar();

        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {

            c.insertarAltura(tbProvincia.Text,tbSituacionMax.Text,Convert.ToInt32(tbAlturaMax.Text), tbSituacionMin.Text, Convert.ToInt32(tbAlturaMax.Text));
        }
    }
}
