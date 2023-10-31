using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorGestorFinal
{
    
    public partial class BDdatos : Form
    {
        concectarBD cn= new concectarBD();
        
        List<String> listaBaseDatos = new List<String>();
        List<String> listTablas = new List<String>();
        public BDdatos()
        {
            InitializeComponent();
        }

        private void BDdatos_Load(object sender, EventArgs e)
        {
            cargarBaseDatos();
        }
        private void cargarBaseDatos()
        {
            cn = new concectarBD(concectarBD.conectarse[0], concectarBD.conectarse[1], concectarBD.conectarse[2], concectarBD.conectarse[3]);
            listaBaseDatos = cn.listarBasesDeDatos("show databases");

            for (int i = 0; i < listaBaseDatos.Count; i++)
            {
                BaseDatos.Items.Add(listaBaseDatos[i]);
            }
            BaseDatos.Visible = true;
        }

        private void BaseDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tablas.Items.Clear();
            cn = new concectarBD(concectarBD.conectarse[0], BaseDatos.Text, concectarBD.conectarse[2], concectarBD.conectarse[3]);
            listTablas =cn.listarBasesDeDatos("show tables");
            for (int i = 0; i < listaBaseDatos.Count; i++)
            {
               Tablas.Items.Add(listTablas[i]);
            }
            Tablas.Visible = true;
        }

        private void Tablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Atributos.Items.Clear();
            listTablas = cn.select(Tablas.Text);
            for (int i = 0; i < listTablas.Count; i++)
            {
                Atributos.Items.Add(listTablas[i]);
            }
            Atributos.Visible = true;
        }
    }
}
