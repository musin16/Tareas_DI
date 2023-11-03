using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
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
    public partial class  Form1 : Form
    {
        List<String> listaBaseDatos = new List<String>();
        String nombre = "";
        concectarBD cn;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Quíeres salir?", "Gestor Musin", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             cn = new concectarBD(txtServidor.Text, txtBaseDatos.Text, txtUsuario.Text, txtContra.Text);
        }

        private void btn_Server_Click(object sender, EventArgs e)
        {
            txtServidor.Text = Interaction.InputBox("");
        }

        private void btnBaseDatos_Click(object sender, EventArgs e)
        {
            txtBaseDatos.Text = Interaction.InputBox("");
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = Interaction.InputBox("");
        }

        private void btnContraseña_Click(object sender, EventArgs e)
        {
            txtContra.Enabled = true;
            txtContra.Focus();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            txtConsulta.Enabled = true;
            txtConsulta.Focus();
            btnConsulta.Enabled = false;
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                consultorio();
                e.Handled = true;
            }
        }

        private void txtConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                consultorio();
            }
        }
        private void consultorio()
        {

            if (txtConsulta.Text != "")
            {
                concectarBD cn = new concectarBD(txtServidor.Text, txtBaseDatos.Text, txtUsuario.Text, txtContra.Text);
                String consulta = txtConsulta.Text;
                if (consulta.StartsWith("Select"))
                {
                    cn.select(consulta);
                }
                else if (consulta.StartsWith("Update") || consulta.StartsWith("Insert"))
                {
                    cn.executarInserModiMucho(consulta);
                }
                else
                {
                    if (consulta.Equals("show databases"))
                    {
                        BDdatos bd = new BDdatos();
                        bd.ShowDialog();
                        this.Hide();
                    }
                    else if (consulta.StartsWith("show tables"))
                    {
                        listaBaseDatos = cn.listarBasesDeDatos(txtConsulta.Text);

                        for (int i = 0; i < listaBaseDatos.Count; i++)
                        {
                            listBD.Items.Add(listaBaseDatos[i]);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Consula Vacia");
            }
            txtConsulta.Enabled = false;
            btnConsulta.Enabled = true;
            btnConsulta.Focus();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            consultorio();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            concectarBD cn = new concectarBD(txtServidor.Text, txtBaseDatos.Text, txtUsuario.Text, txtContra.Text);
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                nombre = ofd.FileName;
                cn.importar(nombre);
            }

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            List<string> n = cn.listarBasesDeDatos("SHOW DATABASES");

            foreach (string bd in n)
            {
                if (!bd.Equals("information_schema") && !bd.Equals("performance_schema") && !bd.Equals("mysql") && !bd.Equals("phpmyadmin") && !bd.Equals("test"))
                {
                    concectarBD cn = new concectarBD(txtServidor.Text, bd, txtUsuario.Text, txtContra.Text);
                    cn.exportar("C:\\Seguridad\\" + bd);
                }
            }
               
        }
    }
}
