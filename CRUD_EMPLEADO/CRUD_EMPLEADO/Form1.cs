using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace CRUD_EMPLEADO
{
    public partial class Form1 : Form
    {
        ConectarBd cb=new ConectarBd();
        List<Empleados> listEmp = new List<Empleados>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_añadir_Click(object sender, EventArgs e)
        {
            FileStream f = new FileStream();
           Bye
            cb.insertar(txt_Dni.Text,txt_nombre.Text,Convert.ToInt16(txt_nivel.Text),txt_img.Text);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           listEmp= cb.conectar();
          dataGridView1.DataSource = listEmp;
        }
    }
}
