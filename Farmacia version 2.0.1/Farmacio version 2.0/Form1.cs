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
using System.Security.Cryptography;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using Microsoft.VisualBasic;
using Image = System.Drawing.Image;

namespace Farmacia_version_2._0
{
    public partial class FormularioPrincipal : Form
    {
        ClaseConectarBD cnx=new ClaseConectarBD();
        List<ClaseMedicamento> listaMedicamento = new List<ClaseMedicamento>();
        List<ClaseMedicamento> listaCesta = new List<ClaseMedicamento>();
        List<ClaseMedicamento> MedEncontrados = new List<ClaseMedicamento>();
        List<ClaseEmpleado> listaEmpleado = new List<ClaseEmpleado>();
        List<ClaseTarjetaSanitaria> listaTarjetas = new List<ClaseTarjetaSanitaria>();
        List<ClaseTratamiento> listaTratamientos = new List<ClaseTratamiento>();
        
        public FormularioPrincipal()
        {
            InitializeComponent();

        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
           
        }

        private void grbFuncionalidad_Enter(object sender, EventArgs e)
        {

        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            listaMedicamento = cnx.listar();
            cargarTPV(listaMedicamento);
            txtdni.Focus();
        }

        private void cargarTPV(List<ClaseMedicamento> listaMedicamento)
        {
            int fila = Convert.ToInt16(numericUpDown1.Value);
            int columna = Convert.ToInt16(numericUpDown2.Value);
            int tabPaginas=(listaMedicamento.Count()/ (fila * columna));
            for (int i = 1; i < tabPaginas+1; i++) {
                TabPage tabP = new TabPage("Hoja " + i);
                Button btn = new Button();
                MemoryStream ms = new MemoryStream(listaMedicamento[2].Imagen);
                for (int j = 1; j < tabPaginas + 1; j++)
                {
                    btn.BackgroundImage = Image.FromStream(ms);
                    btn.Click += BotonX_Click;
                    tabP.Controls.Add(btn);
                    tabControl_Med.Controls.Add(tabP);
                }

            }
           /* for (int i = 0; i <2; i++)
            {*/

              /*  TableLayoutPanel tpl = new TableLayoutPanel();
                tpl.AutoSize = true;
                Button btn = new Button();
                MemoryStream ms = new MemoryStream(listaMedicamento[2].Imagen);
                btn.BackgroundImage = Image.FromStream(ms);
                btn.Click += BotonX_Click;
                tpl.Controls.Add(btn);*/
              //  tabControl_Med.Controls.Add(tpl);
          //  }

        }

        private void BotonX_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
        }

        private void BotonX_MouseHover(object sender, EventArgs e)
        {
          


        }

        public static string CrearMD5(string pwd)
        {
            // se pasa como parámetro el contenido del cuadro de texto pwd.txt
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(pwd);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // convertir el array de byte en un string hexadecimal
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    //x2 es un argumento, parámetro para decir que se formatea en hexadecimal
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString().ToLower();
            }
        }

        private void txtPwd_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void tabControl_Med_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
    
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtgCestaCompra_DoubleClick(object sender, EventArgs e)
        {
         
           
            
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            
          
        }

        private void mandar_mail(string pdfTicket)
        {
          
        }

        //private string imprimirTicket()
        //{
         
          
        //}

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {
            ClaseEmpleado emmpledo = new ClaseEmpleado();
           emmpledo= cnx.buscarUsuario(txtPwd.Text, CrearMD5(txtPwd.Text));
            if (emmpledo!=null)
            {
                tabControl_Med.Enabled = true;
                grbAccesorio.Enabled = true;
                grbFuncionalidad.Enabled = true;
                dtgCestaCompra.Enabled = true;
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
        
        }

        private void txtdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char) Keys.Enter)
            {
                e.Handled = true;
                txtPwd.Focus();
            }
        }
    }
}
